namespace Koenigz.PerfectCulling;

public interface IActiveSamplingProvider
{

	public string Name
	{
		 get { } //Length: 0
	}

	public string get_Name() { }

	public void InitializeSamplingProvider() { }

	public bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

}

