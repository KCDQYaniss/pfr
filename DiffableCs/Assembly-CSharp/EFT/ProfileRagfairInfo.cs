namespace EFT;

public sealed class ProfileRagfairInfo
{
	[JsonProperty("offers")]
	public Offer[] Offers; //Field offset: 0x10
	[JsonProperty("rating")]
	public float Rating; //Field offset: 0x18
	[JsonProperty("isRatingGrowing")]
	public bool IsRatingGrowing; //Field offset: 0x1C

	public ProfileRagfairInfo() { }

}

