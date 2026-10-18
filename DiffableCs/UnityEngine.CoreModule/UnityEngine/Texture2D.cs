namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D blackTexture
	{
		 get { } //Length: 69
	}

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		 get { } //Length: 78
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D grayTexture
	{
		 get { } //Length: 69
	}

	public bool ignoreMipmapLimit
	{
		[NativeName("SetIgnoreMipmapLimitAndReload")]
		 set { } //Length: 93
	}

	public virtual bool isReadable
	{
		 get { } //Length: 78
	}

	public int minimumMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 91
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D redTexture
	{
		 get { } //Length: 69
	}

	public int requestedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 91
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D whiteTexture
	{
		 get { } //Length: 69
	}

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
	public void ClearMinimumMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	public void ClearRequestedMipmapLevel() { }

	public void Compress(bool highQuality) { }

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	public static Texture2D get_blackTexture() { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	public static Texture2D get_grayTexture() { }

	public virtual bool get_isReadable() { }

	public static Texture2D get_redTexture() { }

	public static Texture2D get_whiteTexture() { }

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v) { }

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	public NativeArray GetPixelData(int mipLevel) { }

	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	public Color[] GetPixels() { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	public Color32[] GetPixels32() { }

	private ulong GetRawImageDataSize() { }

	public NativeArray GetRawTextureData() { }

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	public byte[] GetRawTextureData() { }

	private IntPtr GetWritableImageData(int frame) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	public bool IsRequestedMipmapLevelLoaded() { }

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public bool Reinitialize(int width, int height) { }

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
	public bool Resize(int width, int height) { }

	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[NativeName("SetIgnoreMipmapLimitAndReload")]
	public void set_ignoreMipmapLimit(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

