namespace UnityEngine.ProBuilder;

internal static class UvUnwrapping
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetAutoUV>b__0_0(Face x) { }

	}

	public struct UVTransform
	{
		public Vector2 translation; //Field offset: 0x0
		public float rotation; //Field offset: 0x8
		public Vector2 scale; //Field offset: 0xC

		public virtual string ToString() { }

	}

	private static List s_UVTransformProjectionBuffer; //Field offset: 0x0
	private static Vector2 s_TempVector2; //Field offset: 0x8
	private static readonly List s_IndexBuffer; //Field offset: 0x10

	private static UvUnwrapping() { }

	private static void ApplyUVAnchor(Vector2[] uvs, IList indexes, Anchor anchor) { }

	private static void ApplyUVSettings(Vector2[] uvs, IList indexes, AutoUnwrapSettings uvSettings) { }

	internal static UVTransform CalculateDelta(IList src, IList srcIndices, IList dst, IList dstIndices) { }

	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	private static int GetIndex(IList collection, int index) { }

	private static Vector2 GetRotatedSize(IList points, IList indices, Vector2 center, float rotation) { }

	internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	private static void ScaleUVs(Vector2[] uvs, IList indexes, Vector2 scale, Bounds2D bounds) { }

	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, IEnumerable facesToConvert) { }

	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection = null) { }

	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

}

