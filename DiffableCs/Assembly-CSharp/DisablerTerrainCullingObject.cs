//Type is in global namespace

[ExecuteInEditMode]
public class DisablerTerrainCullingObject : DisablerCullingObjectBase
{
	public Terrain Terrain; //Field offset: 0x58
	public TerrainLod TerrainLod; //Field offset: 0x60
	public bool IsDisableTerrainDraw; //Field offset: 0x68
	public bool IsDisableTerrainTreesDraw; //Field offset: 0x69

	public DisablerTerrainCullingObject() { }

	protected virtual void Awake() { }

	protected virtual void SetComponentsEnabled(bool hasEntered) { }

}

