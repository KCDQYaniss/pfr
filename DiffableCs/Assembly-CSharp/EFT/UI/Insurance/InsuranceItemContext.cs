namespace EFT.UI.Insurance;

public sealed class InsuranceItemContext : ItemContext
{
	public readonly InsuredItem InsuredItem; //Field offset: 0x68

	public InsuranceItemContext(InsuredItem item, ItemContext sourceContext) { }

	public virtual ItemContext CreateChild(Item item) { }

}

