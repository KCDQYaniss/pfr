namespace EFT.Hideout;

public sealed class CircleOfCultistsStashWeaponItemModel : StashItemModel
{

	public CircleOfCultistsStashWeaponItemModel() { }

	protected virtual Quaternion ConfigurePrefabRotation(GameObject prefab) { }

	protected virtual Vector3 ConfigureRotationPivotPosition(Vector3 size) { }

	public virtual void SetRotation(ItemRotation rotation) { }

}

