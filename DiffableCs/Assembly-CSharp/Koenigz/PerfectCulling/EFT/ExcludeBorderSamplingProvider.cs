namespace Koenigz.PerfectCulling.EFT;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
public sealed class ExcludeBorderSamplingProvider : SamplingProviderBase
{
	[SerializeField]
	private LevelBorder _border; //Field offset: 0x28
	private ConcaveBorder _tempConcaveBorder; //Field offset: 0x30

	public virtual string Name
	{
		 get { } //Length: 49
	}

	public ExcludeBorderSamplingProvider() { }

	public virtual string get_Name() { }

	public virtual void InitializeSamplingProvider() { }

	public virtual bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

}

