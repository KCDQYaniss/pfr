namespace EFT.Hideout;

public class StashItemModel : MonoBehaviour
{
	protected GameObject _prefab; //Field offset: 0x20
	protected Transform _rotationPivot; //Field offset: 0x28
	private LODGroup _lodGroup; //Field offset: 0x30

	public StashItemModel() { }

	protected override Vector3 ConfigurePrefabPosition(Vector3 localBoundsMin, Vector3 size) { }

	protected override Quaternion ConfigurePrefabRotation(GameObject prefab) { }

	protected override Vector3 ConfigureRotationPivotPosition(Vector3 size) { }

	public void Dispose() { }

	public override void Init(GameObject prefab) { }

	private void SetLayerAllChildren(Transform root, int layer) { }

	public override void SetRotation(ItemRotation rotation) { }

	private void SetupTransform(GameObject prefab, Transform parent, Quaternion originalRotation) { }

}

