namespace EFT.InventoryLogic;

public class MarkOfUnknown : SpecItem
{
	private MarkOfUnknownTemplate _template; //Field offset: 0x78

	public float ScavKillExpPenalty
	{
		 get { } //Length: 31
	}

	public float ScavKillStandingPenalty
	{
		 get { } //Length: 31
	}

	public float TradersDiscount
	{
		 get { } //Length: 31
	}

	public MarkOfUnknown(string id, MarkOfUnknownTemplate template) { }

	public float get_ScavKillExpPenalty() { }

	public float get_ScavKillStandingPenalty() { }

	public float get_TradersDiscount() { }

}

