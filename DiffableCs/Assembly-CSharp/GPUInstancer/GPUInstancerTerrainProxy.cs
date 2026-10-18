namespace GPUInstancer;

[ExecuteInEditMode]
public class GPUInstancerTerrainProxy : MonoBehaviour
{
	public GPUInstancerDetailManager detailManager; //Field offset: 0x20
	public GPUInstancerDetailManager detailManagerOptic; //Field offset: 0x28
	public GPUInstancerTreeManager treeManager; //Field offset: 0x30
	public bool beingDestroyed; //Field offset: 0x38
	public int terrainSelectedToolIndex; //Field offset: 0x3C

	public GPUInstancerTerrainProxy() { }

	private void OnDestroy() { }

}

