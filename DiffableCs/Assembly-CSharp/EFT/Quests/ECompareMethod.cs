namespace EFT.Quests;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Quests.ECompareMethod>))]
public enum ECompareMethod
{
	MoreOrEqual = 0,
	Equal = 1,
	NotEqual = 2,
	More = 3,
	Less = 4,
	LessOrEqual = 5,
}

