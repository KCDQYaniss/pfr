namespace EFT.Settings.Graphics;

public sealed class GraphicsPreset
{
	private static readonly GraphicsPreset _veryLow; //Field offset: 0x0
	private static readonly GraphicsPreset _low; //Field offset: 0x8
	private static readonly GraphicsPreset _medium; //Field offset: 0x10
	private static readonly GraphicsPreset _high; //Field offset: 0x18
	public static readonly GraphicsPreset Ultra; //Field offset: 0x20
	private static readonly GraphicsPreset[] _presets; //Field offset: 0x28
	private static readonly int _mediumIndex; //Field offset: 0x30
	private int _textureQuality; //Field offset: 0x10
	private int _shadowsQuality; //Field offset: 0x14
	private ESamplingMode _sampling; //Field offset: 0x18
	private float _objectLodBias; //Field offset: 0x1C
	private float _overallVisibility; //Field offset: 0x20
	private int _mipStreamingBufferSize; //Field offset: 0x24
	private int _mipStreamingIOCount; //Field offset: 0x28
	private ESSAOMode _ssao; //Field offset: 0x2C
	private ESSRMode _ssr; //Field offset: 0x30
	private AnisotropicFiltering _anisotropicFiltering; //Field offset: 0x34
	private EAntialiasingMode _antiAliasing; //Field offset: 0x38
	private bool _bloom; //Field offset: 0x3C
	private bool _zBlur; //Field offset: 0x3D
	private bool _instancingLights; //Field offset: 0x3E
	private bool _chromaticAberrations; //Field offset: 0x3F
	private bool _noise; //Field offset: 0x40
	private float _sharpen; //Field offset: 0x44
	private bool _highQualityFog; //Field offset: 0x48
	private bool _grassShadow; //Field offset: 0x49
	private bool _highQualityColor; //Field offset: 0x4A
	private bool _sdTarkovStreets; //Field offset: 0x4B
	private EFSR2Mode _fsr2Mode; //Field offset: 0x4C
	private EFSR3Mode _fsr3Mode; //Field offset: 0x50
	private EDLSSMode _dlssMode; //Field offset: 0x54
	private EDLSSPreset _dlssPreset; //Field offset: 0x58
	private CloudsMode _cloudsQuality; //Field offset: 0x5C
	private ESSRMode _volumetricLight; //Field offset: 0x60

	private static GraphicsPreset() { }

	private GraphicsPreset() { }

	private GraphicsPreset(GraphicsSettingsGroup settings) { }

	public void Apply(GraphicsSettingsGroup settings) { }

	public static int GetIndexFromQuality(Nullable quality) { }

	public static GraphicsPreset GetPreset(Nullable quality) { }

	public static int GetPresetIndexIgnoreMipStreaming(in GraphicsPreset preset) { }

	public static int GetQualityFromIndex(int index) { }

	public static int GetRecommendedVRAM(GraphicsSettingsGroup settings) { }

	public static bool op_Equality(GraphicsPreset a, GraphicsPreset b) { }

	public static bool op_Inequality(GraphicsPreset a, GraphicsPreset b) { }

}

