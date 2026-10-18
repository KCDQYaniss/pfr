namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
public struct ThreadInfo
{
	internal static readonly ThreadInfo Null; //Field offset: 0x0
	public readonly int ThreadId; //Field offset: 0x0
	public readonly string ThreadName; //Field offset: 0x8
	public readonly bool IsThreadPoolThread; //Field offset: 0x10

	private static ThreadInfo() { }

	public ThreadInfo(int threadId, string threadName, bool isThreadPoolThread) { }

	internal static ThreadInfo FromCurrentThread() { }

}

