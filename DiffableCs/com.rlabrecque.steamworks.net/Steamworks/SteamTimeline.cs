namespace Steamworks;

public static class SteamTimeline
{

	public static void AddGamePhaseTag(string pchTagName, string pchTagIcon, string pchTagGroup, uint unPriority) { }

	public static TimelineEventHandle_t AddInstantaneousTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds = 0, ETimelineEventClipPriority ePossibleClip = 1) { }

	public static TimelineEventHandle_t AddRangeTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds = 0, float flDuration = 0, ETimelineEventClipPriority ePossibleClip = 1) { }

	public static void ClearTimelineTooltip(float flTimeDelta) { }

	public static SteamAPICall_t DoesEventRecordingExist(TimelineEventHandle_t ulEvent) { }

	public static SteamAPICall_t DoesGamePhaseRecordingExist(string pchPhaseID) { }

	public static void EndGamePhase() { }

	public static void EndRangeTimelineEvent(TimelineEventHandle_t ulEvent, float flEndOffsetSeconds) { }

	public static void OpenOverlayToGamePhase(string pchPhaseID) { }

	public static void OpenOverlayToTimelineEvent(TimelineEventHandle_t ulEvent) { }

	public static void RemoveTimelineEvent(TimelineEventHandle_t ulEvent) { }

	public static void SetGamePhaseAttribute(string pchAttributeGroup, string pchAttributeValue, uint unPriority) { }

	public static void SetGamePhaseID(string pchPhaseID) { }

	public static void SetTimelineGameMode(ETimelineGameMode eMode) { }

	public static void SetTimelineTooltip(string pchDescription, float flTimeDelta) { }

	public static void StartGamePhase() { }

	public static TimelineEventHandle_t StartRangeTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unPriority, float flStartOffsetSeconds, ETimelineEventClipPriority ePossibleClip) { }

	public static void UpdateRangeTimelineEvent(TimelineEventHandle_t ulEvent, string pchTitle, string pchDescription, string pchIcon, uint unPriority, ETimelineEventClipPriority ePossibleClip) { }

}

