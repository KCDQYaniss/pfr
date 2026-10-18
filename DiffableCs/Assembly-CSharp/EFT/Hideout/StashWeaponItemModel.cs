namespace EFT.Hideout;

public sealed class StashWeaponItemModel : StashItemModel
{

	public StashWeaponItemModel() { }

	protected virtual Vector3 ConfigurePrefabPosition(Vector3 localBoundsMin, Vector3 size) { }

	protected virtual Quaternion ConfigurePrefabRotation(GameObject prefab) { }

	protected virtual Vector3 ConfigureRotationPivotPosition(Vector3 size) { }

	public virtual void SetRotation(ItemRotation rotation) { }

}

