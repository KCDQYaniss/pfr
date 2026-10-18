namespace Koenigz.PerfectCulling.EFT;

[Extension]
public static class LODGroupExtensions
{

	[Extension]
	public static HashSet GetAllRenderers(LODGroup group) { }

	[Extension]
	public static Bounds GetLODGroupBounds(LODGroup lodGroup, bool includeInactive = true) { }

}

