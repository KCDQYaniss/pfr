namespace EFT.Hideout;

public class SupplyItem
{
	public string ItemId; //Field offset: 0x10
	public string TemplateId; //Field offset: 0x18
	public int ChangeTime; //Field offset: 0x20
	public float Resource; //Field offset: 0x24

	public SupplyItem() { }

}

