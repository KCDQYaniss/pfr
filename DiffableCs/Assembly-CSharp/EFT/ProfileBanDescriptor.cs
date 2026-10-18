namespace EFT;

[GenerateBinarySerialization]
public sealed class ProfileBanDescriptor
{
	[JsonProperty("banType")]
	public EBanType Type; //Field offset: 0x10
	[JsonProperty("dateTime")]
	public long ExpirationTime; //Field offset: 0x18

	public ProfileBanDescriptor() { }

	public ProfileBanDescriptor(ProfileBan ban) { }

}

