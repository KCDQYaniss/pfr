namespace EFT.Hideout;

public sealed class InventoryEquipmentStashItemModel : StashItemModel, ISlotModelPositionTuner
{

	public InventoryEquipmentStashItemModel() { }

	protected virtual Vector3 ConfigurePrefabPosition(Vector3 localBoundsMin, Vector3 size) { }

	protected virtual Quaternion ConfigurePrefabRotation(GameObject prefab) { }

	protected virtual Vector3 ConfigureRotationPivotPosition(Vector3 size) { }

	public virtual void Init(GameObject prefab) { }

	public virtual void SetRotation(ItemRotation rotation) { }

}

