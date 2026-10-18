namespace UnityEngine;

[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
public sealed class CanvasRenderer : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isMask>k__BackingField; //Field offset: 0x18

	public int absoluteDepth
	{
		 get { } //Length: 78
	}

	public Vector2 clippingSoftness
	{
		 set { } //Length: 88
	}

	[NativeProperty("ShouldCull", False, TargetType::Function (0))]
	public bool cull
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool cullTransparentMesh
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool hasMoved
	{
		 get { } //Length: 78
	}

	public bool hasPopInstruction
	{
		 set { } //Length: 93
	}

	public int materialCount
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int popMaterialCount
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public static void AddUIVertexStream(List verts, List positions, List colors, List uv0S, List uv1S, List uv2S, List uv3S, List normals, List tangents) { }

	public void Clear() { }

	public static void CreateUIVertexStream(List verts, List positions, List colors, List uv0S, List uv1S, List uv2S, List uv3S, List normals, List tangents, List indices) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	public void DisableRectClipping() { }

	public void EnableRectClipping(Rect rect) { }

	private void EnableRectClipping_Injected(ref Rect rect) { }

	public int get_absoluteDepth() { }

	public bool get_cull() { }

	public bool get_cullTransparentMesh() { }

	public bool get_hasMoved() { }

	public int get_materialCount() { }

	public int get_popMaterialCount() { }

	public float GetAlpha() { }

	public Color GetColor() { }

	private void GetColor_Injected(out Color ret) { }

	public float GetInheritedAlpha() { }

	public Material GetMaterial(int index) { }

	public Material GetMaterial() { }

	public Material GetPopMaterial(int index) { }

	public void set_clippingSoftness(Vector2 value) { }

	private void set_clippingSoftness_Injected(ref Vector2 value) { }

	public void set_cull(bool value) { }

	public void set_cullTransparentMesh(bool value) { }

	public void set_hasPopInstruction(bool value) { }

	public void set_materialCount(int value) { }

	public void set_popMaterialCount(int value) { }

	public void SetAlphaTexture(Texture texture) { }

	public void SetColor(Color color) { }

	private void SetColor_Injected(ref Color color) { }

	public void SetMaterial(Material material, Texture texture) { }

	public void SetMaterial(Material material, int index) { }

	public void SetMesh(Mesh mesh) { }

	public void SetPopMaterial(Material material, int index) { }

	public void SetTexture(Texture texture) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	public static void SplitUIVertexStreams(List verts, List positions, List colors, List uv0S, List uv1S, List uv2S, List uv3S, List normals, List tangents, List indices) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

}

