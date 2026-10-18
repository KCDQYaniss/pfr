namespace AmplifyMotion;

internal class WorkerThreadPool
{
	private const int ThreadStateQueueCapacity = 1024; //Field offset: 0x0
	internal Queue[] m_threadStateQueues; //Field offset: 0x10
	internal object[] m_threadStateQueueLocks; //Field offset: 0x18
	private int m_threadPoolSize; //Field offset: 0x20
	private ManualResetEvent m_threadPoolTerminateSignal; //Field offset: 0x28
	private AutoResetEvent[] m_threadPoolContinueSignals; //Field offset: 0x30
	private Thread[] m_threadPool; //Field offset: 0x38
	private bool m_threadPoolFallback; //Field offset: 0x40
	internal object m_threadPoolLock; //Field offset: 0x48
	internal int m_threadPoolIndex; //Field offset: 0x50

	public WorkerThreadPool() { }

	private static void AsyncUpdateCallback(object obj) { }

	private static void AsyncUpdateThread(object obj) { }

	internal void EnqueueAsyncUpdate(MotionState state) { }

	internal void FinalizeAsyncUpdateThreads() { }

	internal void InitializeAsyncUpdateThreads(int threadCount, bool systemThreadPool) { }

}

