namespace EFT.InventoryLogic;

public class DialogItemTemplate : InfoTemplate
{
	[JsonProperty("DialogId")]
	public MongoID DialogId; //Field offset: 0x148

	public DialogItemTemplate() { }

}

