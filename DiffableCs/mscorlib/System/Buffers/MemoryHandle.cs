namespace System.Buffers;

public struct MemoryHandle : IDisposable
{
	private void* _pointer; //Field offset: 0x0
	private GCHandle _handle; //Field offset: 0x8
	private IPinnable _pinnable; //Field offset: 0x10

	[CLSCompliant(False)]
	public void* Pointer
	{
		 get { } //Length: 4
	}

	[CLSCompliant(False)]
	public MemoryHandle(void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	public override void Dispose() { }

	public void* get_Pointer() { }

}

