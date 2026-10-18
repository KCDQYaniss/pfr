namespace EFT;

public sealed class ItemReference
{
	public string Id; //Field offset: 0x10
	public string TemplateId; //Field offset: 0x18
	public int ExistingCount; //Field offset: 0x20
	public int RequiredCount; //Field offset: 0x24
	public bool OnlyFunctional; //Field offset: 0x28

	public ItemReference() { }

}

