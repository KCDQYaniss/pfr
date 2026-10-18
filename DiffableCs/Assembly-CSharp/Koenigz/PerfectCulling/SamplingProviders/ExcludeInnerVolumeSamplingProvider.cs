namespace Koenigz.PerfectCulling.SamplingProviders;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
public sealed class ExcludeInnerVolumeSamplingProvider : SamplingProviderBase
{
	[SerializeField]
	private PerfectCullingCrossSceneVolume[] _innerCrossVolumes; //Field offset: 0x28

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public ExcludeInnerVolumeSamplingProvider() { }

	public virtual string get_Name() { }

	public virtual void InitializeSamplingProvider() { }

	public virtual bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

	public bool IsSamplingPositionActiveMT(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

	public void RefreshInnerVolumes() { }

}

