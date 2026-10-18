namespace Koenigz.PerfectCulling.EFT;

public sealed class BakedLodPreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetBakeGroups>b__6_0(BakedLodContent x, BakedLodContent y) { }

	}

	[SerializeField]
	private GuidReference[] _cullingGroups; //Field offset: 0x20
	[SerializeField]
	private int _bakeHash; //Field offset: 0x28

	public GuidReference[] CullingGroups
	{
		 get { } //Length: 5
	}

	public BakedLodPreProcess() { }

	public GuidReference[] get_CullingGroups() { }

	public PerfectCullingBakeGroup[] GetBakeGroups() { }

	public virtual int GetBakeHash() { }

	public virtual PerfectCullingBakeGroup[] PrepareRuntimeContent() { }

}

