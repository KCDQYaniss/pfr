namespace EFT.SeasonalPerks;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkItemFilterField>))]
public enum EPerkItemFilterField
{
	TemplateId = 0,
	ParentId = 1,
}

