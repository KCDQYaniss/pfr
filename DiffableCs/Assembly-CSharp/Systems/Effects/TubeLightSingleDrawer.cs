namespace Systems.Effects;

public sealed class TubeLightSingleDrawer : IBaseLightDrawer
{
	private const int STENCIL_VALUE = 192; //Field offset: 0x0
	private static readonly int _currentInstanceID; //Field offset: 0x0
	private static readonly int _stencilValueId; //Field offset: 0x4
	private Mesh _mesh; //Field offset: 0x10
	private Material _material; //Field offset: 0x18
	private TubeLightList _list; //Field offset: 0x20
	private int _count; //Field offset: 0x28

	public override int Count
	{
		 get { } //Length: 71
	}

	private static TubeLightSingleDrawer() { }

	public TubeLightSingleDrawer() { }

	private void Add(TubeLight tubeLight) { }

	private void Changed(int index, TubeLight tubeLight) { }

	public override void Destroy() { }

	public override int get_Count() { }

	private void Remove(int index, TubeLight tubeLight) { }

	public override void Render(CommandBuffer buffer) { }

	public override void Start(Mesh mesh, Material material) { }

	public override bool Update() { }

}

