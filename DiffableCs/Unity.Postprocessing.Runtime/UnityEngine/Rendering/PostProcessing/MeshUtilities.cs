namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary s_Primitives; //Field offset: 0x0
	private static Dictionary s_ColliderPrimitives; //Field offset: 0x8

	private static MeshUtilities() { }

	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

	internal static Mesh GetColliderMesh(Collider collider) { }

	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

}

