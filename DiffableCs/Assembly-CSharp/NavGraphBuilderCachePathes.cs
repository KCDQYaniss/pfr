//Type is in global namespace

public class NavGraphBuilderCachePathes
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <CheckOnCrossVoxel>b__2_0(NavGraphEditorPathValue x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass1_0
	{
		public bool withDebug; //Field offset: 0x0

	}

	public const int MAX_ITERATION = 10; //Field offset: 0x0

	public NavGraphBuilderCachePathes() { }

	[CompilerGenerated]
	internal static void <CachePathesToVoxel>g__PathesFromPoints|1_0(NavGraphVoxel voxel, HashSet usedPathes, HashSet navGraphEditorPaths, ref <>c__DisplayClass1_0 unnamed_param_3) { }

	public static void CachePathesToVoxel(NavGraphVoxel navGraphVoxel, bool withDebug = false) { }

	private static void CheckOnCrossVoxel(NavGraphVoxel navGraphVoxel, List list, bool withDebug = false) { }

	private static void CollectByDist(NavGraphEditorPoint point, HashSet usedPath, HashSet navGraphEditorPaths, float curDist, float maxDist, int iteration, bool withDebug = false) { }

	private static bool IsLineCrossBox(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 tmp1, Vector3 tmp2) { }

}

