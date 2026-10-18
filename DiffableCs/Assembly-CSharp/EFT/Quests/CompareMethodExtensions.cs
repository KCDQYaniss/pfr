namespace EFT.Quests;

[Extension]
public static class CompareMethodExtensions
{

	[Extension]
	public static bool Compare(ECompareMethod compareMethod, double comparer, double value) { }

	[Extension]
	public static double GetSuccessValue(ECompareMethod compareMethod, double value) { }

}

