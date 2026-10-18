namespace EFT;

public static class GameEditionRaidExpBonus
{

	public static void Calculate(Player playerForCalculate, out float expModifier, out string gameVersionName) { }

	public static bool HaveUIBonus(ProfileStats profileStats, out int uiPercent, out string gameVersionName) { }

	public static bool HaveUIBonus(Profile profile, out int uiPercent, out string gameVersionName) { }

	public static bool HaveUIBonusForGroup(BindableList playersGroup, out string playerName, out int uiPercent, out string gameVersionName) { }

}

