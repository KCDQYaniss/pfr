namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingGridPreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[SerializeField]
	private PerfectCullingAdaptiveGrid _grid; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private Bounds[] _visibilityCells; //Field offset: 0x28
	[SerializeField]
	private GuidReference[] _cullingGridContent; //Field offset: 0x30

	public GuidReference[] CullingGridContent
	{
		 get { } //Length: 76
	}

	public Bounds[] VisibilityCells
	{
		 get { } //Length: 5
	}

	public CullingGridPreProcess() { }

	public GuidReference[] get_CullingGridContent() { }

	public Bounds[] get_VisibilityCells() { }

	public virtual int GetBakeHash() { }

}

