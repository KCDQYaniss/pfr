namespace GPUInstancer;

public class PrefabVariationData`1 : IPrefabVariationData
{
	public GPUInstancerPrefabPrototype prototype; //Field offset: 0x0
	public string bufferName; //Field offset: 0x0
	public ComputeBuffer variationBuffer; //Field offset: 0x0
	public T[] dataArray; //Field offset: 0x0
	public T defaultValue; //Field offset: 0x0

	public PrefabVariationData`1(GPUInstancerPrefabPrototype prototype, string bufferName, T defaultValue = null) { }

	public override string GetBufferName() { }

	public override GPUInstancerPrefabPrototype GetPrototype() { }

	public override void InitializeBufferAndArray(int count, bool setDefaults = true) { }

	public override void ReleaseBuffer() { }

	public void SetArrayAndInitializeBuffer(T[] dataArray) { }

	public override void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	public override void SetInstanceData(GPUInstancerPrefab prefabInstance) { }

	public override void SetNewBufferSize(int newCount) { }

	public override void SetVariation(MaterialPropertyBlock mpb) { }

}

