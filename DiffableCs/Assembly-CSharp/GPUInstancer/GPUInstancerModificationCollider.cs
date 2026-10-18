namespace GPUInstancer;

public class GPUInstancerModificationCollider : MonoBehaviour
{
	public GPUInstancerPrefabManager prefabManager; //Field offset: 0x20
	private List _enteredInstances; //Field offset: 0x28
	private Collider _collider; //Field offset: 0x30

	public GPUInstancerModificationCollider() { }

	public void AddEnteredInstance(GPUInstancerPrefab prefabInstance) { }

	private void Awake() { }

	public int GetEnteredInstanceCount() { }

	public bool IsInsideCollider(GPUInstancerPrefab prefabInstance) { }

	private void OnTriggerEnter(Collider collider) { }

	private void Update() { }

}

