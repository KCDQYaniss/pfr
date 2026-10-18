namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeQueueDispose
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	public void Dispose() { }

}

