namespace EFT.UI.Ragfair;

public struct FilterRule
{
	public EViewListType ViewListType; //Field offset: 0x0
	public int Page; //Field offset: 0x4
	public int CurrencyType; //Field offset: 0x8
	public ESortType SortType; //Field offset: 0xC
	public bool SortDirection; //Field offset: 0x10
	public int PriceFrom; //Field offset: 0x14
	public int PriceTo; //Field offset: 0x18
	public int QuantityFrom; //Field offset: 0x1C
	public int QuantityTo; //Field offset: 0x20
	public int ConditionFrom; //Field offset: 0x24
	public int ConditionTo; //Field offset: 0x28
	public bool OneHourExpiration; //Field offset: 0x2C
	public bool RemoveBartering; //Field offset: 0x2D
	public int OfferOwnerType; //Field offset: 0x30
	public bool OnlyFunctional; //Field offset: 0x34
	public long OfferId; //Field offset: 0x38
	public string FilterSearchId; //Field offset: 0x40
	public string LinkedSearchId; //Field offset: 0x48
	public string NeededSearchId; //Field offset: 0x50
	public string BuildName; //Field offset: 0x58
	public Dictionary BuildItems; //Field offset: 0x60
	public int BuildCount; //Field offset: 0x68
	private string _handbookId; //Field offset: 0x70

	public bool AnyIdSearch
	{
		 get { } //Length: 51
	}

	public BuildItemSearchValue BuildSearch
	{
		 get { } //Length: 254
	}

	public string HandbookId
	{
		 get { } //Length: 216
		 set { } //Length: 358
	}

	public void ClearBuildFilter() { }

	public bool get_AnyIdSearch() { }

	public BuildItemSearchValue get_BuildSearch() { }

	public string get_HandbookId() { }

	public void set_HandbookId(string value) { }

	public bool ShowFilterChange(FilterRule rule) { }

	public virtual string ToString() { }

}

