namespace System.Threading.Channels;

internal static class ChannelUtilities
{
	internal static readonly Exception s_doneWritingSentinel; //Field offset: 0x0
	internal static readonly Task s_trueTask; //Field offset: 0x8
	internal static readonly Task s_falseTask; //Field offset: 0x10
	internal static readonly Task s_neverCompletingTask; //Field offset: 0x18

	private static ChannelUtilities() { }

	internal static void Complete(TaskCompletionSource tcs, Exception error = null) { }

	internal static Exception CreateInvalidCompletionException(Exception inner = null) { }

	internal static void FailOperations(Deque operations, Exception error) { }

	internal static void QueueWaiter(ref AsyncOperation tail, AsyncOperation waiter) { }

	internal static void WakeUpWaiters(ref AsyncOperation listTail, bool result, Exception error = null) { }

}

