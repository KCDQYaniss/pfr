namespace EFT.InventoryLogic;

public interface IUnlootableComponentTemplate
{

	public EPlayerSideMask Side
	{
		 get { } //Length: 0
	}

	public string SlotName
	{
		 get { } //Length: 0
	}

	public EPlayerSideMask get_Side() { }

	public string get_SlotName() { }

}

