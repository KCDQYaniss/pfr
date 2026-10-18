namespace EFT;

public sealed class ProfileStatusData
{
	[JsonProperty("maxPveCountExceeded")]
	public bool limitedServersAvailability; //Field offset: 0x10
	[JsonProperty("profiles")]
	public ProfileStatus[] profiles; //Field offset: 0x18
	[JsonProperty("estimate")]
	public int matchingEstimateTimeSeconds; //Field offset: 0x20

	public ProfileStatusData() { }

}

