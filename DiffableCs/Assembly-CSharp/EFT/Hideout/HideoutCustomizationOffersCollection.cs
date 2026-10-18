namespace EFT.Hideout;

public class HideoutCustomizationOffersCollection
{
	[JsonProperty("globals")]
	public HideoutCustomizationGlobalOffer[] GlobalOffers; //Field offset: 0x10
	[JsonProperty("slots")]
	public HideoutCustomizationSlotOffer[] SlotsOffers; //Field offset: 0x18
	[CompilerGenerated]
	private List <AllOffers>k__BackingField; //Field offset: 0x20

	public private List AllOffers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutCustomizationOffersCollection() { }

	[CompilerGenerated]
	public List get_AllOffers() { }

	[OnDeserialized]
	private void OnDeserializing(StreamingContext context) { }

	[CompilerGenerated]
	private void set_AllOffers(List value) { }

}

