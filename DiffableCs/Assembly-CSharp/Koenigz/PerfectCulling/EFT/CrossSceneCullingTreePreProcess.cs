namespace Koenigz.PerfectCulling.EFT;

public sealed class CrossSceneCullingTreePreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetBakeGroups>b__5_0(PerfectCullingCrossSceneContentTrees x, PerfectCullingCrossSceneContentTrees y) { }

	}

	[Header("Content setup")]
	[SerializeField]
	private int _bakeHash; //Field offset: 0x20
	[SerializeField]
	private int _numBakeGroups; //Field offset: 0x24
	[SerializeField]
	private GuidReference[] _cullingGroups; //Field offset: 0x28

	public CrossSceneCullingTreePreProcess() { }

	public PerfectCullingBakeGroup[] GetBakeGroups() { }

	public virtual int GetBakeHash() { }

	public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

}

