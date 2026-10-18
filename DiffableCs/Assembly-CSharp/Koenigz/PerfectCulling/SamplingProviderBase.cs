namespace Koenigz.PerfectCulling;

public abstract class SamplingProviderBase : MonoBehaviour, IActiveSamplingProvider
{
	private IBakingBehaviour m_behaviour; //Field offset: 0x20

	public abstract string Name
	{
		 get { } //Length: 0
	}

	protected SamplingProviderBase() { }

	public abstract string get_Name() { }

	public abstract void InitializeSamplingProvider() { }

	public abstract bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

}

