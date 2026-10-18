namespace EFT.Quests;

[Extension]
public static class GroupQuestSettingExtensions
{

	[Extension]
	public static bool IsCounterEventEnabledForParty(GroupQuestSetting settings, EGroupQuestCounterEvent counterEvent) { }

	[Extension]
	public static bool SupportsGroupProgress(Condition condition, GroupQuestSetting settings) { }

	public static bool TryResolveGroupCounterEvent(Condition condition, out EGroupQuestCounterEvent counterEvent) { }

}

