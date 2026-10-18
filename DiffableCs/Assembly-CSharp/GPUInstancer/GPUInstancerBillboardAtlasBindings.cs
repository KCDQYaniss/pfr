namespace GPUInstancer;

public class GPUInstancerBillboardAtlasBindings : ScriptableObject
{
	public List billboardAtlasBindings; //Field offset: 0x18

	public GPUInstancerBillboardAtlasBindings() { }

	public void AddBillboardAtlas(GameObject prefab, int atlasResolution, int frameCount, Texture2D albedoAtlasTexture, Texture2D normalAtlasTexture, float quadSize, float yPivotOffset) { }

	public void ClearEmptyBillboardAtlases() { }

	public bool DeleteBillboardTextures(GPUInstancerPrototype selectedPrototype) { }

	public BillboardAtlasBinding GetBillboardAtlasBinding(GameObject prefab, int atlasResolution, int frameCount) { }

	public bool IsBillboardAtlasExists(GameObject prefab) { }

	public void RemoveBillboardAtlas(BillboardAtlasBinding billboardAtlasBinding) { }

	public void ResetBillboardAtlases() { }

}

