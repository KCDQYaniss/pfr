namespace Koenigz.PerfectCulling.EFT;

public static class PerfectCullingSharedOccluderGenerator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Renderer rend; //Field offset: 0x10
		public Predicate <>9__0; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal bool <IsRendererInsideBakeGroup>b__0(Renderer x) { }

	}

	private const string SHARED_OCCLUDER_NAME = "SharedOccluder"; //Field offset: 0x0
	private const string SHARED_OCCLUDER_LAYER = "LowPolyCollider"; //Field offset: 0x0
	private static HashSet kTempUniqueOccluders; //Field offset: 0x0

	private static PerfectCullingSharedOccluderGenerator() { }

	internal static GameObject CloneWithoutTransparency(MeshRenderer rend, ETransparencyMode transparencyMode, ICollection optionalOutMeshCopies = null) { }

	public static void EditorGenerateSharedOccluderUsingGroupContent(PerfectCullingCrossSceneGroup group, GameObject occluderRoot) { }

	public static SharedOccluder GenerateSharedOccluder(PerfectCullingCrossSceneVolume volume, PerfectCullingCrossSceneGroup group, IReadOnlyCollection optionalBakeGroups = null) { }

	private static Renderer[] GetValidLODLevelRenderers(LOD[] lods, ESharedOccluderLODMode mode) { }

	private static bool IsRendererInsideBakeGroup(Renderer rend, IReadOnlyCollection bakeGroups) { }

	private static bool TryCreateSharedOccluder(string sourceGroupName, Renderer inputRenderer, GameObject occluderRoot, ETransparencyMode transparencyMode, IReadOnlyCollection optionalBakeGroups = null, LODGroup optionalLodGroup = null) { }

}

