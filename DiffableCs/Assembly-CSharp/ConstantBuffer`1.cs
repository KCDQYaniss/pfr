//Type is in global namespace

public sealed class ConstantBuffer`1 : IBindGraphicsBuffer, IDataGraphicsBuffer, IDisposable
{
	private readonly HashSet _materials; //Field offset: 0x0
	private readonly HashSet _computeShaders; //Field offset: 0x0
	private readonly int _nameID; //Field offset: 0x0
	private readonly string _name; //Field offset: 0x0
	private readonly UsageFlags _flags; //Field offset: 0x0
	private readonly int _stride; //Field offset: 0x0
	private readonly T[] _data; //Field offset: 0x0
	private GraphicsBuffer _gpuBuffer; //Field offset: 0x0
	private bool _usedGlobal; //Field offset: 0x0

	public override T Data
	{
		 get { } //Length: 53
		 set { } //Length: 77
	}

	public bool IsValid
	{
		 get { } //Length: 9
	}

	private ConstantBuffer`1() { }

	public ConstantBuffer`1(T data, string name = null, UsageFlags flags = 0) { }

	public override void BindTo(CommandBuffer buffer, ComputeShader shader) { }

	public void BindTo(MaterialPropertyBlock block) { }

	public override void BindTo(CommandBuffer buffer) { }

	public override void BindTo(Material material) { }

	public void BindTo(ComputeShader shader) { }

	public void Clear() { }

	public override void Close() { }

	public override void Dispose() { }

	public override T get_Data() { }

	public bool get_IsValid() { }

	public override NativeArray Open() { }

	public override void set_Data(T value) { }

	private void ThrowIfDisposed() { }

	public override bool UnbindFrom(Material material) { }

	public override bool UnbindFrom(CommandBuffer buffer) { }

	public override bool UnbindFrom(ComputeShader shader) { }

	public override bool UnbindFrom(MaterialPropertyBlock block) { }

}

