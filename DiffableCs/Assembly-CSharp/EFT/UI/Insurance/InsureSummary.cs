namespace EFT.UI.Insurance;

public sealed class InsureSummary : Dictionary
{

	public InsureSummary() { }

	public InsurePrice AddToItemCache(InsuredItem item, string traderId) { }

	[CanBeNull]
	public InsurePrice GetInsurePrice(InsuredItem item, string traderId) { }

}

