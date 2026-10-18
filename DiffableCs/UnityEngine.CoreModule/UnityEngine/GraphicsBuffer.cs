namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class GraphicsBuffer : IDisposable
{
	internal struct IndirectDrawIndexedArgs
	{
		public const int size = 20; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private uint <indexCountPerInstance>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private uint <instanceCount>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private uint <startIndex>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private uint <baseVertexIndex>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private uint <startInstance>k__BackingField; //Field offset: 0x10

	}

	[Flags]
	internal enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 16,
		Raw = 32,
		Append = 64,
		Counter = 128,
		IndirectArguments = 256,
		Constant = 512,
	}

	[Flags]
	internal enum UsageFlags
	{
		None = 0,
		LockBufferForWrite = 1,
	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public int count
	{
		 get { } //Length: 78
	}

	public string name
	{
		 set { } //Length: 93
	}

	public int stride
	{
		 get { } //Length: 78
	}

	public UsageFlags usageFlags
	{
		 get { } //Length: 78
	}

	public GraphicsBuffer(Target target, int count, int stride) { }

	public GraphicsBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	private void* BeginBufferWrite(int offset = 0, int size = 0) { }

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	private void EndBufferWrite(int bytesWritten = 0) { }

	protected virtual void Finalize() { }

	public int get_count() { }

	public int get_stride() { }

	public UsageFlags get_usageFlags() { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::GetUsageFlags", HasExplicitThis = True)]
	private UsageFlags GetUsageFlags() { }

	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	public bool IsValid() { }

	[FreeFunction("GraphicsBuffer_Bindings::IsValidBuffer")]
	private static bool IsValidBuffer(GraphicsBuffer buf) { }

	private static bool IsVertexIndexOrCopyOnly(Target target) { }

	public NativeArray LockBufferForWrite(int bufferStartIndex, int count) { }

	public void Release() { }

	private static bool RequiresCompute(Target target) { }

	public void set_name(string value) { }

	public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	public void SetData(List data) { }

	public void SetData(Array data) { }

	public void SetData(NativeArray data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

	public void UnlockBufferAfterWrite(int countWritten) { }

}

