namespace EFT.InventoryLogic;

public sealed class BattlePassItemTemplate : StackableItemTemplate
{

	public virtual int DiscardLimit
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public BattlePassItemTemplate() { }

	public virtual int get_DiscardLimit() { }

	public virtual void set_DiscardLimit(int value) { }

}

