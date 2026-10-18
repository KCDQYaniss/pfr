namespace GPUInstancer;

public class GPUInstancerPrefab : MonoBehaviour
{
	[HideInInspector]
	public GPUInstancerPrefabPrototype prefabPrototype; //Field offset: 0x20
	[HideInInspector]
	public int gpuInstancerID; //Field offset: 0x28
	[HideInInspector]
	public PrefabInstancingState state; //Field offset: 0x2C
	public Dictionary variationDataList; //Field offset: 0x30
	private bool _isTransformSet; //Field offset: 0x38
	private Transform _instanceTransform; //Field offset: 0x40
	private bool _isMatrixSet; //Field offset: 0x48
	private Matrix4x4 _localToWorldMatrix; //Field offset: 0x4C

	public GPUInstancerPrefab() { }

	public void AddVariation(string bufferName, T value) { }

	public Transform GetInstanceTransform(bool forceNew = false) { }

	public Matrix4x4 GetLocalToWorldMatrix(bool forceNew = false) { }

	public override void SetupPrefabInstance(GPUInstancerRuntimeData runtimeData, bool forceNew = false) { }

}

