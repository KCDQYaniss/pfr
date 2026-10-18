namespace EFT;

[GenerateBinarySerialization]
public sealed class ProfileStatsSeparatorDescriptor
{
	[JsonProperty("Eft", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public ProfileStatsDescriptor Eft; //Field offset: 0x10
	[JsonProperty("Arena", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public ProfileStatsDescriptor Arena; //Field offset: 0x18

	public ProfileStatsSeparatorDescriptor() { }

	public ProfileStatsSeparatorDescriptor(ProfileStatsSeparator statsSeparator) { }

}

