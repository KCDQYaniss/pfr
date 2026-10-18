namespace Koenigz.PerfectCulling;

public static class PerfectCullingBakingManager
{
	private static IEnumerator _activeBake; //Field offset: 0x0
	private static PerfectCullingBakingBehaviour _activeBakingBehaviour; //Field offset: 0x8
	private static readonly Queue _scheduledBakes; //Field offset: 0x10

	public static bool IsBaking
	{
		 get { } //Length: 87
	}

	private static PerfectCullingBakingManager() { }

	public static void BakeAllScheduled() { }

	private static void EditorUpdate() { }

	public static bool get_IsBaking() { }

	public static void ScheduleBake(BakeInformation bakeInformation) { }

}

