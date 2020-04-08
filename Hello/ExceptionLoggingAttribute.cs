using System;
using System.Diagnostics;
using PostSharp.Aspects;

namespace Hello
{
	/// <summary>
	/// Exception logging aspect.
	/// </summary>
	[Serializable]
	internal class ExceptionLoggingAttribute : MethodInterceptionAspect
	{
		/// <summary>
		/// Method invoked <i>instead</i> of the method to which the aspect has been applied.
		/// </summary>
		/// <param name="args">Advice arguments.</param>
		public override void OnInvoke(MethodInterceptionArgs args)
		{
			string methodName = args.Method.Name;
			Arguments arguments = args.Arguments;
			Log.LogMethodCall(TraceLevel.Verbose, methodName, arguments);

			try
			{
				args.Proceed();
			}
			catch (Exception e)
			{
				Log.LogException(methodName, arguments, e);
				if (Configuration.Rethrow) throw;
			}
		}
	}
}
