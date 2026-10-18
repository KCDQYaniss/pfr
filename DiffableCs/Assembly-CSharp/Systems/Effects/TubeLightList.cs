namespace Systems.Effects;

public sealed class TubeLightList : IDisposable
{
	private static readonly int _tubeLightColor; //Field offset: 0x0
	private static readonly int _tubeLightData; //Field offset: 0x4
	private static readonly int _tubeLightObjectToWorld; //Field offset: 0x8
	private readonly GraphicsList _data; //Field offset: 0x10
	private readonly GraphicsList _positions; //Field offset: 0x18
	private readonly GraphicsList _colors; //Field offset: 0x20
	private readonly Storage _lights; //Field offset: 0x28
	private FastBoundingSearch _search; //Field offset: 0x30

	public int Count
	{
		 get { } //Length: 65
	}

	private static TubeLightList() { }

	private TubeLightList() { }

	public TubeLightList(int capacity, bool inverseSearch) { }

	public void Add(TubeLight tubeLight) { }

	private void AddInternal(TubeLight tubeLight) { }

	public bool Changed(TubeLight tubeLight) { }

	private void ChangedInternal(int index, TubeLight tubeLight) { }

	public override void Dispose() { }

	public bool FindAndGetResults(Vector3 point, List results, bool removeAfterFound = true) { }

	public int get_Count() { }

	public bool Remove(TubeLight tubeLight) { }

	private void RemoveInternal(int index, TubeLight tubeLight) { }

	public void Set(MaterialPropertyBlock block) { }

	public void Set(CommandBuffer buffer) { }

	public bool UpdateIfNeeded() { }

	public bool UpdateIfNeeded(out bool gpuBufferHasChanged) { }

}

