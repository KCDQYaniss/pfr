namespace Systems.Effects;

public sealed class AreaLightInstancingDrawer : IBaseLightDrawer
{
	private const int DEFAULT_INNER_LIST_CAPACITY = 32; //Field offset: 0x0
	private readonly List _toOut; //Field offset: 0x10
	private readonly List _toIn; //Field offset: 0x18
	private Mesh _mesh; //Field offset: 0x20
	private Material _material; //Field offset: 0x28
	private MaterialPropertyBlock _block; //Field offset: 0x30
	private AreaLightList _outer; //Field offset: 0x38
	private AreaLightList _inner; //Field offset: 0x40
	private Vector3 _position; //Field offset: 0x48
	private int _outerCount; //Field offset: 0x54
	private int _innerCount; //Field offset: 0x58

	public override int Count
	{
		 get { } //Length: 147
	}

	public AreaLightInstancingDrawer() { }

	private void Add(AreaLight areaLight) { }

	private void Changed(int index, AreaLight areaLight) { }

	public override void Destroy() { }

	public override int get_Count() { }

	private static bool IsInside(AreaLight areaLight, Vector3 position) { }

	private void Remove(int index, AreaLight areaLight) { }

	public override void Render(CommandBuffer buffer) { }

	public override void Start(Mesh mesh, Material material) { }

	public override bool Update() { }

}

