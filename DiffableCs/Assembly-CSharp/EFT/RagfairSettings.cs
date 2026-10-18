namespace EFT;

public sealed class RagfairSettings
{
	internal sealed class OfferCount
	{
		public float from; //Field offset: 0x10
		public float to; //Field offset: 0x14
		public int count; //Field offset: 0x18
		public int countForSpecialEditions; //Field offset: 0x1C

		public OfferCount(float from, float to, int count, int countForSpecialEditions) { }

	}

	public bool enabled; //Field offset: 0x10
	public int minUserLevel; //Field offset: 0x14
	public float communityItemTax; //Field offset: 0x18
	public float communityRequirementTax; //Field offset: 0x1C
	public float offerDurationTimeInHour; //Field offset: 0x20
	public float offerDurationTimeInHourAfterRemove; //Field offset: 0x24
	public int delaySinceOfferAdd; //Field offset: 0x28
	public double RagfairTurnOnTimestamp; //Field offset: 0x30
	public float renewCommunityTax; //Field offset: 0x38
	public float renewPricePerHour; //Field offset: 0x3C
	public bool isOnlyFoundInRaidAllowed; //Field offset: 0x40
	public OfferCount[] maxActiveOfferCount; //Field offset: 0x48
	[JsonProperty("sellInOnePiece")]
	public int SellInOnePiece; //Field offset: 0x50
	[JsonProperty("ItemRestrictions")]
	public RagfairItemRestrictions[] ItemRestrictions; //Field offset: 0x58
	public bool RagfairMinUserLevelByCategory; //Field offset: 0x60

	public TimeSpan DefaultDuration
	{
		 get { } //Length: 156
	}

	public RagfairSettings() { }

	public TimeSpan get_DefaultDuration() { }

}

