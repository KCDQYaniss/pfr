namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
internal struct NativeRingQueueDispose
{
	[NativeDisableUnsafePtrRestriction]
	public UnsafeRingQueue* m_QueueData; //Field offset: 0x0

	public void Dispose() { }

}

