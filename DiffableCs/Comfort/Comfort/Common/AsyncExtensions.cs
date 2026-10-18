namespace Comfort.Common;

[Extension]
public static class AsyncExtensions
{

	[Extension]
	public static void Fail(TaskCompletionSource taskSource, string error, int errorCode = 0) { }

	[Extension]
	public static void Succeed(TaskCompletionSource taskSource) { }

}

