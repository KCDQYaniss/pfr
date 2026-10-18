namespace System.Runtime.CompilerServices;

internal static class AsyncTaskCache
{
	internal static readonly Task TrueTask; //Field offset: 0x0
	internal static readonly Task FalseTask; //Field offset: 0x8
	internal static readonly Task[] Int32Tasks; //Field offset: 0x10

	private static AsyncTaskCache() { }

	internal static Task CreateCacheableTask(TResult result) { }

	private static Task[] CreateInt32Tasks() { }

}

