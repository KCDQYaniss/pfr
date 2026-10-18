namespace EFT.Trading;

public interface ITradingSession : IImageLoader
{

	public IEnumerable DisplayableTraders
	{
		 get { } //Length: 0
	}

	public InsuranceCompany InsuranceCompany
	{
		 get { } //Length: 0
	}

	public IEnumerable Insurers
	{
		 get { } //Length: 0
	}

	public Trader Medic
	{
		 get { } //Length: 0
	}

	public IEnumerable Repairers
	{
		 get { } //Length: 0
	}

	public IEnumerable Traders
	{
		 get { } //Length: 0
	}

	public Task ArenaManagerItemsTransfer(ArenaEftTransferItem[] items, string traderId, int transferTax) { }

	public void BuyCustomizationWear(string offer, IEnumerable items, Callback onFinished) { }

	public Task ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items) { }

	public void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished) { }

	public IEnumerable get_DisplayableTraders() { }

	public InsuranceCompany get_InsuranceCompany() { }

	public IEnumerable get_Insurers() { }

	public Trader get_Medic() { }

	public IEnumerable get_Repairers() { }

	public IEnumerable get_Traders() { }

	public void GetInsurancePrice(string[] traderId, string[] itemIds, Callback callback) { }

	public void GetOffers(string traderId, string side, Callback onFinished) { }

	public Task GetSupplyData(string traderId) { }

	public Trader GetTrader(string traderId) { }

	public Task GetTraderAssortment(string traderId) { }

	public void InsureItems(string[] items, string traderId, Callback callback) { }

	public Task RepairItemsByTrader(string traderId, RepairItem repairItem) { }

	public Task RequestCaptcha() { }

	public Task SellAllFromSavage(string playerId, string petId) { }

}

