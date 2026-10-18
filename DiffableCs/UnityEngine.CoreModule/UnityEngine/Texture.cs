namespace UnityEngine;

[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public class Texture : Object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	internal ColorSpace activeTextureColorSpace
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
		internal get { } //Length: 87
	}

	public int anisoLevel
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public static ulong desiredTextureMemory
	{
		[FreeFunction("GetTextureStreamingManager().GetDesiredTextureMemory")]
		 get { } //Length: 69
	}

	public override TextureDimension dimension
	{
		 get { } //Length: 78
		 set { } //Length: 62
	}

	public FilterMode filterMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public override GraphicsFormat graphicsFormat
	{
		 get { } //Length: 132
	}

	public override int height
	{
		 get { } //Length: 78
		 set { } //Length: 62
	}

	public override bool isReadable
	{
		 get { } //Length: 78
	}

	public float mipMapBias
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public int mipmapCount
	{
		[NativeName("GetMipmapCount")]
		 get { } //Length: 78
	}

	public static ulong nonStreamingTextureMemory
	{
		[FreeFunction("GetTextureStreamingManager().GetNonStreamingTextureMemory")]
		 get { } //Length: 69
	}

	public static bool streamingTextureDiscardUnusedMips
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
		 get { } //Length: 69
		[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
		 set { } //Length: 78
	}

	public Vector2 texelSize
	{
		[NativeName("GetTexelSize")]
		 get { } //Length: 95
	}

	public static ulong totalTextureMemory
	{
		[FreeFunction("GetTextureStreamingManager().GetTotalTextureMemory")]
		 get { } //Length: 69
	}

	public override int width
	{
		 get { } //Length: 78
		 set { } //Length: 62
	}

	public TextureWrapMode wrapMode
	{
		[NativeName("GetWrapModeU")]
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public TextureWrapMode wrapModeU
	{
		 get { } //Length: 78
	}

	public TextureWrapMode wrapModeV
	{
		 get { } //Length: 78
	}

	public TextureWrapMode wrapModeW
	{
		 get { } //Length: 78
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNativeArrayLengthOverflowException() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
	internal ColorSpace get_activeTextureColorSpace() { }

	public int get_anisoLevel() { }

	[FreeFunction("GetTextureStreamingManager().GetDesiredTextureMemory")]
	public static ulong get_desiredTextureMemory() { }

	public override TextureDimension get_dimension() { }

	public FilterMode get_filterMode() { }

	public override GraphicsFormat get_graphicsFormat() { }

	public override int get_height() { }

	public override bool get_isReadable() { }

	public float get_mipMapBias() { }

	[NativeName("GetMipmapCount")]
	public int get_mipmapCount() { }

	[FreeFunction("GetTextureStreamingManager().GetNonStreamingTextureMemory")]
	public static ulong get_nonStreamingTextureMemory() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[NativeName("GetTexelSize")]
	public Vector2 get_texelSize() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

	[FreeFunction("GetTextureStreamingManager().GetTotalTextureMemory")]
	public static ulong get_totalTextureMemory() { }

	public override int get_width() { }

	[NativeName("GetWrapModeU")]
	public TextureWrapMode get_wrapMode() { }

	public TextureWrapMode get_wrapModeU() { }

	public TextureWrapMode get_wrapModeV() { }

	public TextureWrapMode get_wrapModeW() { }

	private int GetDataHeight() { }

	private int GetDataWidth() { }

	private TextureDimension GetDimension() { }

	public IntPtr GetNativeTexturePtr() { }

	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	public void IncrementUpdateCount() { }

	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace() { }

	public void set_anisoLevel(int value) { }

	public override void set_dimension(TextureDimension value) { }

	public void set_filterMode(FilterMode value) { }

	public override void set_height(int value) { }

	public void set_mipMapBias(float value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	public override void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

}

