namespace Unity.Collections;

public struct DoubleRewindableAllocators : IDisposable
{
	private RewindableAllocator* Pointer; //Field offset: 0x0
	private AllocatorHelper UpdateAllocatorHelper0; //Field offset: 0x8
	private AllocatorHelper UpdateAllocatorHelper1; //Field offset: 0x18

	public RewindableAllocator Allocator
	{
		 get { } //Length: 60
	}

	internal bool EnableBlockFree
	{
		internal get { } //Length: 84
		internal set { } //Length: 134
	}

	public bool IsCreated
	{
		 get { } //Length: 8
	}

	public DoubleRewindableAllocators(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIsCreated() { }

	public override void Dispose() { }

	public RewindableAllocator get_Allocator() { }

	internal bool get_EnableBlockFree() { }

	public bool get_IsCreated() { }

	public void Initialize(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	internal void set_EnableBlockFree(bool value) { }

	public void Update() { }

}

