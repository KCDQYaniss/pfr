namespace EFT.InventoryLogic;

public sealed class BattlePassItem : StackableItem
{

	public virtual Nullable DiscardLimit
	{
		 get { } //Length: 61
	}

	public virtual bool Undiscardable
	{
		 get { } //Length: 3
	}

	public BattlePassItem(string id, BattlePassItemTemplate template) { }

	public virtual Nullable get_DiscardLimit() { }

	public virtual bool get_Undiscardable() { }

}

