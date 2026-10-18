//Type is in global namespace

public static class GraphicsHelper
{
	private static Material _blurMaterial; //Field offset: 0x0
	private static Material _lerpMaterial; //Field offset: 0x8
	private static Material _transformMaterial; //Field offset: 0x10
	private static Material _colorBlendMaterial; //Field offset: 0x18
	private static Material _outlineMaterial; //Field offset: 0x20
	private static Material _getChannelMaterial; //Field offset: 0x28
	private static int _colorFieldID; //Field offset: 0x30
	private static int _srcfactorFieldID; //Field offset: 0x34
	private static int _dstfactorFieldID; //Field offset: 0x38
	private static int _operationFieldID; //Field offset: 0x3C
	private static int _intensityFieldID; //Field offset: 0x40
	private static int _blurOffsets0FieldID; //Field offset: 0x44
	private static int _texAFieldID; //Field offset: 0x48
	private static int _texBFieldID; //Field offset: 0x4C
	private static int _tFieldID; //Field offset: 0x50
	private static int _maskColorFieldID; //Field offset: 0x54
	private static int _addColorFieldID; //Field offset: 0x58
	private static int _multColorFieldID; //Field offset: 0x5C
	private static int _maskFieldID; //Field offset: 0x60
	private static int _offsetsFieldID; //Field offset: 0x64
	private static bool _isFiledIdsInitialized; //Field offset: 0x68

	private static Material BlurMaterial
	{
		private get { } //Length: 472
	}

	private static Material ColorBlendMaterial
	{
		private get { } //Length: 473
	}

	private static Material GetChannelMaterial
	{
		private get { } //Length: 473
	}

	private static Material LerpMaterial
	{
		private get { } //Length: 473
	}

	private static Material OutlineMaterial
	{
		private get { } //Length: 473
	}

	private static Material TransformMaterial
	{
		private get { } //Length: 473
	}

	public static void ColorBlend(CommandBuffer commandBuffer, Color color, RenderTexture destination, BlendMode srcFactor = 5, BlendMode dstFactor = 10, BlendOp operation = 0) { }

	public static void ColorBlend(Color color, RenderTexture destination, BlendMode srcFactor = 5, BlendMode dstFactor = 10, BlendOp operation = 0) { }

	public static void DrawFullscreenTriangle(CommandBuffer commandBuffer, Material material, RenderTexture destination, int pass = 0) { }

	public static void DrawQuad(Material material, RenderTexture destination, int pass = 0) { }

	private static Material get_BlurMaterial() { }

	private static Material get_ColorBlendMaterial() { }

	private static Material get_GetChannelMaterial() { }

	private static Material get_LerpMaterial() { }

	private static Material get_OutlineMaterial() { }

	private static Material get_TransformMaterial() { }

	public static void GetChannel(Texture texture, Color mask, RenderTexture destination) { }

	public static void GetChannel(Texture texture, int channel, RenderTexture destination) { }

	private static void InitFieldIds() { }

	public static void LerpTextures(Texture textureA, Texture textureB, float t, RenderTexture destination) { }

	public static void MakeBlur(RenderTexture source, RenderTexture temp, Vector2 blur, float intensity = 1) { }

	public static void MakeBlur(RenderTexture source, RenderTexture temp, float blurInPixels, float intensity = 1) { }

	public static void Outline(Texture texture, Color mask, Color color, float outlineWidthInPixels, RenderTexture destination) { }

	public static void SafeDestroy(Object obj) { }

	public static void TextureBlend(Texture texture, Color multiply, RenderTexture destination, BlendMode srcFactor = 5, BlendMode dstFactor = 10, BlendOp operation = 0) { }

	public static void TransformTexture(Texture texture, Color add, Color multiply, RenderTexture destination) { }

	public static void Treshold(Texture texture, float min, float max, RenderTexture destination) { }

}

