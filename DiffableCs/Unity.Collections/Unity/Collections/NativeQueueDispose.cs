namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
internal struct NativeQueueDispose
{
	[NativeDisableUnsafePtrRestriction]
	public UnsafeQueue* m_QueueData; //Field offset: 0x0

	public void Dispose() { }

}

