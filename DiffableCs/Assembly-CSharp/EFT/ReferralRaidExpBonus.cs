namespace EFT;

public static class ReferralRaidExpBonus
{

	public static void Calculate(Player playerForCalculate, out float expModifier) { }

	public static float GetMultiplier() { }

	public static int GetRaidUiPercent(Profile profile) { }

	public static bool HaveUIBonusForGroup(Profile localProfile, BindableList playersGroup, out int referralPercent) { }

	public static int ToUiPercent(float expModifier) { }

}

