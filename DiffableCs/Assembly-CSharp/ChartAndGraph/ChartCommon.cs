namespace ChartAndGraph;

public class ChartCommon
{
	private class IntComparer : IEqualityComparer
	{

		public IntComparer() { }

		public override bool Equals(int x, int y) { }

		public override int GetHashCode(int obj) { }

	}

	private static Material mDefaultMaterial; //Field offset: 0x0
	[CompilerGenerated]
	private static IEqualityComparer <DefaultIntComparer>k__BackingField; //Field offset: 0x8

	public private static IEqualityComparer DefaultIntComparer
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		private set { } //Length: 183
	}

	internal static Material DefaultMaterial
	{
		internal get { } //Length: 582
	}

	internal static bool IsInEditMode
	{
		internal get { } //Length: 150
	}

	private static ChartCommon() { }

	public ChartCommon() { }

	internal static void CleanMesh(Mesh newMesh, ref Mesh cleanMesh) { }

	internal static BillboardText CreateBillboardText(BillboardText item, Text prefab, Transform parentTransform, string text, float x, float y, float z, float angle, Transform relativeFrom, bool hideHirarechy, int fontSize, float sharpness) { }

	internal static GameObject CreateCanvasChartItem() { }

	internal static GameObject CreateChartItem() { }

	internal static UIVertex CreateVertex(Vector3 pos, Vector2 uv, float z) { }

	internal static UIVertex CreateVertex(Vector3 pos, Vector2 uv) { }

	private static float CrossProduct(Vector2 a, Vector2 b, Vector2 c) { }

	private static float DotProduct(Vector2 a, Vector2 b, Vector2 c) { }

	internal static T EnsureComponent(GameObject obj) { }

	internal static void FixBillboardText(ItemLabelsBase labels, BillboardText text) { }

	internal static Rect FixRect(Rect r) { }

	internal static Vector2 FromPolar(float angleDeg, float radius) { }

	internal static Vector2 FromPolarRadians(float angleDeg, float radius) { }

	[CompilerGenerated]
	public static IEqualityComparer get_DefaultIntComparer() { }

	internal static Material get_DefaultMaterial() { }

	internal static bool get_IsInEditMode() { }

	internal static float GetAutoDepth(AnyChart parent, ChartOrientation orientation, ChartDivisionInfo info) { }

	internal static float GetAutoLength(AnyChart parent, ChartOrientation orientation) { }

	internal static float GetAutoLength(AnyChart parent, ChartOrientation orientation, ChartDivisionInfo info) { }

	internal static float GetTiling(MaterialTiling tiling) { }

	internal static void HideObject(GameObject obj, bool hideMode) { }

	internal static Vector2 Perpendicular(Vector2 v) { }

	internal static bool SafeAssignMaterial(Renderer renderer, Material material, Material defualt) { }

	public static void SafeDestroy(Object obj) { }

	internal static bool SegmentIntersection(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection) { }

	internal static float SegmentPointSqrDistance(Vector2 a, Vector2 b, Vector2 point) { }

	[CompilerGenerated]
	private static void set_DefaultIntComparer(IEqualityComparer value) { }

	internal static float SmoothLerp(float from, float to, float factor) { }

	internal static BillboardText UpdateBillboardText(BillboardText billboardText, Transform parentTransform, string text, float x, float y, float z, float angle, Transform relativeFrom, bool hideHirarechy) { }

}

