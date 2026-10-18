namespace Systems.Effects;

public sealed class AreaLightList : IDisposable
{
	private static readonly int _areaLightColor; //Field offset: 0x0
	private static readonly int _areaLightData; //Field offset: 0x4
	private static readonly int _areaLightObjectToWorld; //Field offset: 0x8
	private readonly GraphicsList _data; //Field offset: 0x10
	private readonly GraphicsList _positions; //Field offset: 0x18
	private readonly GraphicsList _colors; //Field offset: 0x20
	private readonly Storage _lights; //Field offset: 0x28
	private FastBoundingSearch _search; //Field offset: 0x30

	public int Count
	{
		 get { } //Length: 65
	}

	public ReadOnly GetAccess
	{
		 get { } //Length: 66
	}

	private static AreaLightList() { }

	public AreaLightList(int capacity, bool inverseSearch) { }

	private AreaLightList() { }

	public void Add(AreaLight areaLight) { }

	private void AddInternal(AreaLight areaLight) { }

	public bool Changed(AreaLight areaLight) { }

	private void ChangedInternal(int index, AreaLight areaLight) { }

	public override void Dispose() { }

	public bool FindAndGetResults(Vector3 point, List results, bool removeAfterFound = true) { }

	public int get_Count() { }

	public ReadOnly get_GetAccess() { }

	public bool Remove(AreaLight areaLight) { }

	private void RemoveInternal(int index, AreaLight areaLight) { }

	public void Set(MaterialPropertyBlock block) { }

	public void Set(CommandBuffer buffer) { }

	public bool UpdateIfNeeded() { }

	public bool UpdateIfNeeded(out bool gpuBufferHasChanged) { }

}

