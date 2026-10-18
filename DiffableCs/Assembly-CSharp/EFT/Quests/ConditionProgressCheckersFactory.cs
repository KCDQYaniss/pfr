namespace EFT.Quests;

public static class ConditionProgressCheckersFactory
{

	public static ConditionProgressChecker Create(Condition condition) { }

	public static void CreateProgressChecker(Condition condition, Dictionary progressCheckers) { }

	public static void CreateProgressCheckers(ConditionsDict conditions, Dictionary progressCheckers) { }

	private static void SetHandler(Condition condition, Dictionary progressCheckers, ConditionProgressChecker progressChecker) { }

}

