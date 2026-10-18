namespace UnityEngine.Timeline;

internal static class NotificationUtilities
{

	public static ScriptPlayable CreateNotificationsPlayable(PlayableGraph graph, IEnumerable markers, PlayableDirector director) { }

	public static ScriptPlayable CreateNotificationsPlayable(PlayableGraph graph, IEnumerable markers, TimelineAsset timelineAsset) { }

	private static ScriptPlayable CreateNotificationsPlayable(PlayableGraph graph, IEnumerable markers, IPlayableAsset asset, PlayableDirector director) { }

	public static bool TrackTypeSupportsNotifications(Type type) { }

}

