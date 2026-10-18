namespace Koenigz.PerfectCulling;

public class PerfectCullingSceneColor : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public HashSet allRenderers; //Field offset: 0x10
		public PerfectCullingSceneColor <>4__this; //Field offset: 0x18
		public MaterialPropertyBlock propBlock; //Field offset: 0x20
		public int groupIndex; //Field offset: 0x28
		public Action <>9__0; //Field offset: 0x30

		public <>c__DisplayClass14_0() { }

		internal void <SetupRenderers>b__0(Renderer renderer) { }

	}

	private PerfectCullingBakeGroup[] _allGroups; //Field offset: 0x10
	private List _additionalOccluders; //Field offset: 0x18
	private Color32[] _rendererColors; //Field offset: 0x20
	private int[] _hash; //Field offset: 0x28
	private readonly int _propIdColor; //Field offset: 0x30
	private readonly Material _rendererMaterial; //Field offset: 0x38
	private List _disposeList; //Field offset: 0x40

	public Color32[] Colors
	{
		 get { } //Length: 5
	}

	public int[] Hash
	{
		 get { } //Length: 5
	}

	public PerfectCullingSceneColor(PerfectCullingBakeGroup[] groups, List additionalOccluders, bool setupRenderers = true) { }

	public override void Dispose() { }

	private void GenerateColors() { }

	public Color32[] get_Colors() { }

	public int[] get_Hash() { }

	private void PrepareRenderer(Renderer renderer, Color col, MaterialPropertyBlock propBlock) { }

	private void SetupRenderers() { }

}

