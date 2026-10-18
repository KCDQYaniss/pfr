namespace Systems.Effects;

[DefaultMember("Item")]
public sealed class GraphicsList`1 : IDisposable
{
	public const int DEFAULT_CAPACITY = 128; //Field offset: 0x0
	private static readonly int _stride; //Field offset: 0x0
	private readonly Target _target; //Field offset: 0x0
	private T[] _data; //Field offset: 0x0
	private GraphicsBuffer _buffer; //Field offset: 0x0
	private int _gpuCapacity; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _changedStart; //Field offset: 0x0
	private int _changedEnd; //Field offset: 0x0
	private bool _disposed; //Field offset: 0x0

	public GraphicsBuffer Buffer
	{
		 get { } //Length: 5
	}

	public int Capacity
	{
		 get { } //Length: 26
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public int GpuCapacity
	{
		 get { } //Length: 4
	}

	public T Item
	{
		 get { } //Length: 84
		 set { } //Length: 113
	}

	public Target Target
	{
		 get { } //Length: 164
	}

	private static GraphicsList`1() { }

	public GraphicsList`1(int initialCapacity = 128, Target target = 16) { }

	public bool Add(in T item) { }

	public ReadOnlySpan AsReadOnlySpan() { }

	public ReadOnlySpan AsReadOnlySpan(int start, int count) { }

	public Span AsSpan(int start, int count) { }

	public Span AsSpan() { }

	public void Clear() { }

	[Conditional("DEBUG")]
	private static void DebugCheckIndex(int index, int count, string paramName) { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	private void EnsureCapacity(int required) { }

	protected virtual void Finalize() { }

	public GraphicsBuffer get_Buffer() { }

	public int get_Capacity() { }

	public int get_Count() { }

	public int get_GpuCapacity() { }

	public T get_Item(int index) { }

	public Target get_Target() { }

	public T GetRef(int index) { }

	public bool IsChanged(out int start, out int count) { }

	private void MarkChanged(int index) { }

	public bool RemoveAt(int index) { }

	private void ResetChangeTracking() { }

	public void set_Item(int index, T value) { }

	[Conditional("DEBUG")]
	private void ThrowIfDisposed() { }

	public bool UpdateIfNeeded() { }

	public bool UpdateIfNeeded(out bool gpuBufferHasChanged) { }

}

