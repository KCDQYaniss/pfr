namespace GPUInstancer;

[ExecuteInEditMode]
public class GPUInstancerMapMagicIntegration : MonoBehaviour
{
	public List detailPrototypes; //Field offset: 0x20
	public List treePrototypes; //Field offset: 0x28
	public List prefabPrototypes; //Field offset: 0x30
	public GPUInstancerTerrainSettings terrainSettings; //Field offset: 0x38
	public bool importDetails; //Field offset: 0x40
	public bool importTrees; //Field offset: 0x41
	public bool importObjects; //Field offset: 0x42
	private bool _selectAllPrefabs; //Field offset: 0x43
	public bool isOpticCamera; //Field offset: 0x44
	public GPUInstancerCameraData cameraData; //Field offset: 0x48
	public bool isFrustumCulling; //Field offset: 0x50
	public bool isOcclusionCulling; //Field offset: 0x51
	public float minCullingDistance; //Field offset: 0x54
	public int detailLayer; //Field offset: 0x58
	public bool detailRunInThreads; //Field offset: 0x5C
	public bool useSinglePrefabManager; //Field offset: 0x5D
	public bool disableMeshRenderers; //Field offset: 0x5E
	public bool prefabRunInThreads; //Field offset: 0x5F
	public List terrainDetailPrototypes; //Field offset: 0x60
	public List terrainTreePrototypes; //Field offset: 0x68
	public List prefabs; //Field offset: 0x70
	public List selectedPrefabs; //Field offset: 0x78
	public GPUInstancerPrefabManager prefabManagerInstance; //Field offset: 0x80

	public GPUInstancerMapMagicIntegration() { }

	public void SetCamera(Camera camera) { }

}

