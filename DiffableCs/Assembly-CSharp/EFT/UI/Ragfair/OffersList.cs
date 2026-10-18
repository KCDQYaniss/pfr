namespace EFT.UI.Ragfair;

public class OffersList
{
	public Offer[] offers; //Field offset: 0x10
	public int offersCount; //Field offset: 0x18
	public Dictionary categories; //Field offset: 0x20
	public string selectedCategory; //Field offset: 0x28

	public OffersList() { }

}

