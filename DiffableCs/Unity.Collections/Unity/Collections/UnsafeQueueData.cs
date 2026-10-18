namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct UnsafeQueueData
{
	internal const int m_BlockSize = 16384; //Field offset: 0x0
	public IntPtr m_FirstBlock; //Field offset: 0x0
	public IntPtr m_LastBlock; //Field offset: 0x8
	public int m_MaxItems; //Field offset: 0x10
	public int m_CurrentRead; //Field offset: 0x14
	public byte* m_CurrentWriteBlockTLS; //Field offset: 0x18

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void AllocateQueue(AllocatorHandle allocator, out UnsafeQueueData* outBuf) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static UnsafeQueueBlockHeader* AllocateWriteBlockMT(UnsafeQueueData* data, AllocatorHandle allocator, int threadIndex) { }

	public static void DeallocateQueue(UnsafeQueueData* data, AllocatorHandle allocator) { }

	internal UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) { }

	internal void SetCurrentWriteBlockTLS(int threadIndex, UnsafeQueueBlockHeader* currentWriteBlock) { }

}

