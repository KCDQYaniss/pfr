namespace EFT.SeasonalPerks;

public sealed class ScheduledMailPerkEffectData : SeasonalPerkEffectData
{
	[JsonProperty("periodUnixSeconds")]
	public readonly int PeriodUnixSeconds; //Field offset: 0x10
	[JsonProperty("mailTemplateId")]
	public readonly string MailTemplateId; //Field offset: 0x18

	public ScheduledMailPerkEffectData() { }

	public virtual ScheduledMailPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

