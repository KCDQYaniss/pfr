namespace Koenigz.PerfectCulling;

public class DefaultActiveSamplingProvider : IActiveSamplingProvider
{
	private PerfectCullingExcludeVolume[] excludeVolumes; //Field offset: 0x10

	public static string DefaultActiveSamplingProviderName
	{
		 get { } //Length: 49
	}

	public override string Name
	{
		 get { } //Length: 49
	}

	public DefaultActiveSamplingProvider() { }

	public static string get_DefaultActiveSamplingProviderName() { }

	public override string get_Name() { }

	public override void InitializeSamplingProvider() { }

	public override bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

}

