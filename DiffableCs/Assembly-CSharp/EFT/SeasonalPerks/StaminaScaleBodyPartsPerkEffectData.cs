namespace EFT.SeasonalPerks;

public sealed class StaminaScaleBodyPartsPerkEffectData : SeasonalPerkBodyPartsEffectData
{
	[JsonProperty("intValue")]
	public readonly int IntValue; //Field offset: 0x18

	public StaminaScaleBodyPartsPerkEffectData() { }

	public virtual StaminaScaleBodyPartsPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

