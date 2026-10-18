namespace EFT.SeasonalPerks;

public sealed class KeyDurabilityMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{
	[JsonProperty("keyTypes", ItemConverterType = typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkKeyType>), NullValueHandling = NullValueHandling::Ignore (1))]
	private readonly EPerkKeyType[] _keyTypes; //Field offset: 0x18

	public IEnumerable KeyTypes
	{
		 get { } //Length: 5
	}

	public KeyDurabilityMultiplierPerkEffectData() { }

	public virtual KeyDurabilityMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

	public IEnumerable get_KeyTypes() { }

}

