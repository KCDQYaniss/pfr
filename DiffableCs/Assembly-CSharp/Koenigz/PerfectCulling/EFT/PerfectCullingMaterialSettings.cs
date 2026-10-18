namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingMaterialSettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Material mat; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <IsMaterialForcedOpaque>b__0(Material x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Material mat; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <IsMaterialForcedTransparent>b__0(Material x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Material mat; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <IsMaterialForcedDoubleSide>b__0(Material x) { }

	}

	private static PerfectCullingMaterialSettings _instance; //Field offset: 0x0
	[SerializeField]
	private bool _ignoreBatchedWindowsFilter; //Field offset: 0x20
	[SerializeField]
	private Material[] _forceOpaqueMaterials; //Field offset: 0x28
	[SerializeField]
	private Material[] _forceTransparentMaterials; //Field offset: 0x30
	[SerializeField]
	private Material[] _forceDoubleSideMaterials; //Field offset: 0x38

	public Material[] ForceDoubleSideMaterials
	{
		 get { } //Length: 5
	}

	public Material[] ForceOpaqueMaterials
	{
		 get { } //Length: 5
	}

	public Material[] ForceTransparentMaterials
	{
		 get { } //Length: 76
	}

	public bool IgnoreBatchedWindowsFilter
	{
		 get { } //Length: 5
	}

	public static PerfectCullingMaterialSettings Instance
	{
		 get { } //Length: 392
	}

	public PerfectCullingMaterialSettings() { }

	public Material[] get_ForceDoubleSideMaterials() { }

	public Material[] get_ForceOpaqueMaterials() { }

	public Material[] get_ForceTransparentMaterials() { }

	public bool get_IgnoreBatchedWindowsFilter() { }

	public static PerfectCullingMaterialSettings get_Instance() { }

	public static bool IsMaterialForcedDoubleSide(Material mat) { }

	public static bool IsMaterialForcedOpaque(Material mat) { }

	public static bool IsMaterialForcedTransparent(Material mat) { }

}

