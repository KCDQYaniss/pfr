namespace EFT.UI.Settings;

public sealed class SettingsTooltipData
{
	public const string TITLE_FORMAT = "Ui/Settings/Hint/Usage/{0}Title"; //Field offset: 0x0
	public const string TEXT_FORMAT = "Ui/Settings/Hint/{0}"; //Field offset: 0x0
	public const string HIGH_INCREASE = "Ui/Settings/Hint/Usage/HighIncrease"; //Field offset: 0x0
	public const string AVG_INCREASE = "Ui/Settings/Hint/Usage/AvgIncrease"; //Field offset: 0x0
	public const string LOW_INCREASE = "Ui/Settings/Hint/Usage/LowIncrease"; //Field offset: 0x0
	public const string HIGH_DECREASE = "Ui/Settings/Hint/Usage/HighDecrease"; //Field offset: 0x0
	public const string AVG_DECREASE = "Ui/Settings/Hint/Usage/AvgDecrease"; //Field offset: 0x0
	public const string LOW_DECREASE = "Ui/Settings/Hint/Usage/LowDecrease"; //Field offset: 0x0
	public ESettingsOption Key; //Field offset: 0x10
	public string Title; //Field offset: 0x18
	public string Text; //Field offset: 0x20
	public EUsageStyle UsageStyle; //Field offset: 0x28
	public EUsageProperty UsageProperty; //Field offset: 0x2C
	public string UsageText; //Field offset: 0x30

	public static SettingsTooltipData Empty
	{
		 get { } //Length: 58
	}

	public bool IsEmpty
	{
		 get { } //Length: 149
	}

	public SettingsTooltipData(ESettingsOption key, string title, EUsageStyle usageStyle, EUsageProperty usageProperty, string usageText) { }

	public SettingsTooltipData(ESettingsOption key, EUsageStyle usageStyle, EUsageProperty usageProperty, string usageText) { }

	public SettingsTooltipData(ESettingsOption key, string title) { }

	public SettingsTooltipData(ESettingsOption key) { }

	public SettingsTooltipData Copy() { }

	public static SettingsTooltipData CustomText(ESettingsOption key, string text) { }

	public static SettingsTooltipData get_Empty() { }

	public bool get_IsEmpty() { }

}

