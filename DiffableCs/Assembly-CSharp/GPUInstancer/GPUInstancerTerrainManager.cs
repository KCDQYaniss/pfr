namespace GPUInstancer;

public abstract class GPUInstancerTerrainManager : GPUInstancerManager
{
	[SerializeField]
	private Terrain _terrain; //Field offset: 0xD0
	protected bool replacingInstances; //Field offset: 0xD8
	protected bool initalizingInstances; //Field offset: 0xD9

	protected virtual bool isCulled
	{
		 get { } //Length: 98
	}

	public Terrain terrain
	{
		 get { } //Length: 8
	}

	protected GPUInstancerTerrainManager() { }

	public GPUInstancerTerrainProxy AddProxyToTerrain() { }

	public virtual void Awake() { }

	protected virtual bool get_isCulled() { }

	public Terrain get_terrain() { }

	public virtual void OnDestroy() { }

	private static void RemoveTerrainSettings(GPUInstancerTerrainSettings terrainSettings) { }

	public virtual void Reset() { }

	public override void SetupManagerWithTerrain(Terrain terrain, bool isOptic = false) { }

}

