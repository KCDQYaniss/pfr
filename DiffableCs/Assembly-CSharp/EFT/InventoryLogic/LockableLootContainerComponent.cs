namespace EFT.InventoryLogic;

public class LockableLootContainerComponent : ItemComponent
{
	private readonly LootableContainer LootableContainer; //Field offset: 0x18

	public bool IsLocked
	{
		 get { } //Length: 47
	}

	public virtual bool Serialized
	{
		 get { } //Length: 3
	}

	public LockableLootContainerComponent(Item item, LootableContainer lootableContainer) { }

	public bool get_IsLocked() { }

	public virtual bool get_Serialized() { }

}

