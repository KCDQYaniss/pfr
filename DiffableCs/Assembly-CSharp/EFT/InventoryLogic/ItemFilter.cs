namespace EFT.InventoryLogic;

public sealed class ItemFilter
{
	public bool bluntDamageReduceFromSoftArmor; //Field offset: 0x10
	public bool locked; //Field offset: 0x11
	public MongoID[] Filter; //Field offset: 0x18
	[JsonProperty("Plate")]
	public Nullable Plate; //Field offset: 0x20
	[CanBeNull]
	public EBodyPartColliderType[] armorColliders; //Field offset: 0x40
	[CanBeNull]
	public EArmorPlateCollider[] armorPlateColliders; //Field offset: 0x48
	[CanBeNull]
	public MongoID[] ExcludedFilter; //Field offset: 0x50

	public ItemFilter() { }

	public ItemFilter(IEnumerable itemFilters) { }

	public static bool CheckItem(Item item, MongoID[] acceptableNodes) { }

	public bool CheckItemExcludedFilter(Item item) { }

	public bool CheckItemFilter(Item item) { }

	private void CopyFrom(IEnumerable filters) { }

}

