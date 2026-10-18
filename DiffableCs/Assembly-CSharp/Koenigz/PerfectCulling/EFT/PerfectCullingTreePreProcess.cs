namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingTreePreProcess : PerfectCullingCrossSceneGroupPreProcess
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__7_0; //Field offset: 0x8
		public static Comparison <>9__7_1; //Field offset: 0x10
		public static Func <>9__8_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CollectBakeGroups>b__7_0(Renderer x) { }

		internal int <CollectBakeGroups>b__7_1(Renderer x, Renderer y) { }

		internal string <GetLODGroupRenderers>b__8_0(Transform t) { }

	}

	internal sealed class TreeGroup
	{
		public List TreeBakeGroups; //Field offset: 0x10

		public TreeGroup() { }

		public void AddTree(PerfectCullingBakeGroup tree) { }

	}

	[SerializeField]
	private float m_BranchLength; //Field offset: 0x20
	[SerializeField]
	private float m_BranchSize; //Field offset: 0x24
	[SerializeField]
	private float m_CenterSize; //Field offset: 0x28
	[SerializeField]
	private float m_MergeRadius; //Field offset: 0x2C
	[SerializeField]
	private int m_MaxCount; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private List _treeGroups; //Field offset: 0x38

	public PerfectCullingTreePreProcess() { }

	public virtual PerfectCullingBakeGroup[] CollectBakeGroups() { }

	[ContextMenu("Generate tree proxies")]
	private void GenerateTreeProxies() { }

	private static List GetLODGroupRenderers(LODGroup lodGroup) { }

	public virtual PerfectCullingBakeGroup[] PrebakeTransform(BakeBatch batch, ICollection tempObjects, out Mode writeMode) { }

}

