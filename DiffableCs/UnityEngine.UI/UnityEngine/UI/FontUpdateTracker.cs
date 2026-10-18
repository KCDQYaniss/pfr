namespace UnityEngine.UI;

public static class FontUpdateTracker
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__RebuildForFont; //Field offset: 0x0

	}

	private static Dictionary m_Tracked; //Field offset: 0x0

	private static FontUpdateTracker() { }

	private static void RebuildForFont(Font f) { }

	public static void TrackText(Text t) { }

	public static void UntrackText(Text t) { }

}

