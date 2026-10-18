namespace GPUInstancer;

public interface IPrefabVariationData
{

	public string GetBufferName() { }

	public GPUInstancerPrefabPrototype GetPrototype() { }

	public void InitializeBufferAndArray(int count, bool setDefaults = true) { }

	public void ReleaseBuffer() { }

	public void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	public void SetInstanceData(GPUInstancerPrefab prefabInstance) { }

	public void SetNewBufferSize(int newCount) { }

	public void SetVariation(MaterialPropertyBlock mpb) { }

}

