namespace EFT.UI.Ragfair;

public interface IGetOffersDataLoadManager
{

	public string HandbookId
	{
		 get { } //Length: 0
	}

	public string get_HandbookId() { }

	public Task GetOffers(RagFair ragfair, bool updateCategories) { }

}

