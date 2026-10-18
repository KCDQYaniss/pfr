namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
public sealed class Sprite : Object
{

	public Texture2D associatedAlphaSplitTexture
	{
		[NativeMethod("GetAlphaTexture")]
		 get { } //Length: 78
	}

	public Vector4 border
	{
		 get { } //Length: 102
	}

	public Bounds bounds
	{
		 get { } //Length: 108
	}

	public bool packed
	{
		 get { } //Length: 84
	}

	public SpritePackingRotation packingRotation
	{
		 get { } //Length: 78
	}

	public Vector2 pivot
	{
		[NativeMethod("GetPivotInPixels")]
		 get { } //Length: 95
	}

	public float pixelsPerUnit
	{
		[NativeMethod("GetPixelsToUnits")]
		 get { } //Length: 78
	}

	public Rect rect
	{
		 get { } //Length: 102
	}

	public Texture2D texture
	{
		 get { } //Length: 78
	}

	public Rect textureRect
	{
		 get { } //Length: 117
	}

	public ushort[] triangles
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public Vector2[] uv
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public Vector2[] vertices
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	[RequiredByNativeCode]
	private Sprite() { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[NativeMethod("GetAlphaTexture")]
	public Texture2D get_associatedAlphaSplitTexture() { }

	public Vector4 get_border() { }

	private void get_border_Injected(out Vector4 ret) { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_packed() { }

	public SpritePackingRotation get_packingRotation() { }

	[NativeMethod("GetPivotInPixels")]
	public Vector2 get_pivot() { }

	private void get_pivot_Injected(out Vector2 ret) { }

	[NativeMethod("GetPixelsToUnits")]
	public float get_pixelsPerUnit() { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public Texture2D get_texture() { }

	public Rect get_textureRect() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	public ushort[] get_triangles() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	public Vector2[] get_uv() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	public Vector2[] get_vertices() { }

	internal Vector4 GetInnerUVs() { }

	private void GetInnerUVs_Injected(out Vector4 ret) { }

	internal Vector4 GetOuterUVs() { }

	private void GetOuterUVs_Injected(out Vector4 ret) { }

	internal int GetPacked() { }

	internal int GetPackingRotation() { }

	internal Vector4 GetPadding() { }

	private void GetPadding_Injected(out Vector4 ret) { }

	internal Rect GetTextureRect() { }

	private void GetTextureRect_Injected(out Rect ret) { }

}

