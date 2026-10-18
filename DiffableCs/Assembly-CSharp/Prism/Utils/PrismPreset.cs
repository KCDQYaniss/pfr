namespace Prism.Utils;

public class PrismPreset : ScriptableObject
{
	public string PresetDescription; //Field offset: 0x18
	public PrismPresetType presetType; //Field offset: 0x20
	[SerializeField]
	public bool useBloom; //Field offset: 0x24
	[SerializeField]
	public BloomType bloomType; //Field offset: 0x28
	[SerializeField]
	public bool bloomUseScreenBlend; //Field offset: 0x2C
	[SerializeField]
	public int bloomDownsample; //Field offset: 0x30
	[SerializeField]
	public int bloomBlurPasses; //Field offset: 0x34
	[SerializeField]
	public float bloomIntensity; //Field offset: 0x38
	[SerializeField]
	public float bloomThreshold; //Field offset: 0x3C
	[SerializeField]
	public bool useBloomStability; //Field offset: 0x40
	[SerializeField]
	public bool useBloomLensdirt; //Field offset: 0x41
	[SerializeField]
	public float bloomLensdirtIntensity; //Field offset: 0x44
	[SerializeField]
	public Texture2D bloomLensdirtTexture; //Field offset: 0x48
	[SerializeField]
	public bool useFullScreenBlur; //Field offset: 0x50
	[SerializeField]
	public bool useUIBlur; //Field offset: 0x51
	[SerializeField]
	public int uiBlurGrabTextureFromPassNumber; //Field offset: 0x54
	[SerializeField]
	public bool useFog; //Field offset: 0x58
	[SerializeField]
	public bool fogAffectSkybox; //Field offset: 0x59
	[SerializeField]
	public float fogIntensity; //Field offset: 0x5C
	[SerializeField]
	public float fogHeight; //Field offset: 0x60
	[SerializeField]
	public float fogStartPoint; //Field offset: 0x64
	[SerializeField]
	public float fogDistance; //Field offset: 0x68
	[SerializeField]
	public Color fogColor; //Field offset: 0x6C
	[SerializeField]
	public Color fogEndColor; //Field offset: 0x7C
	[SerializeField]
	public bool useDoF; //Field offset: 0x8C
	[SerializeField]
	public float dofRadius; //Field offset: 0x90
	[SerializeField]
	public DoFSamples dofSampleCount; //Field offset: 0x94
	[SerializeField]
	public float dofBokehFactor; //Field offset: 0x98
	[SerializeField]
	public float dofFocusPoint; //Field offset: 0x9C
	[SerializeField]
	public float dofFocusDistance; //Field offset: 0xA0
	[SerializeField]
	public bool useNearBlur; //Field offset: 0xA4
	[SerializeField]
	public bool dofBlurSkybox; //Field offset: 0xA5
	[SerializeField]
	public float dofNearFocusDistance; //Field offset: 0xA8
	[SerializeField]
	public bool dofForceEnableMedian; //Field offset: 0xAC
	[SerializeField]
	public bool useAmbientObscurance; //Field offset: 0xAD
	[SerializeField]
	public float aoIntensity; //Field offset: 0xB0
	[SerializeField]
	public float aoRadius; //Field offset: 0xB4
	[SerializeField]
	public float aoBias; //Field offset: 0xB8
	[SerializeField]
	public bool aoDownsample; //Field offset: 0xBC
	[SerializeField]
	public int aoBlurIterations; //Field offset: 0xC0
	[SerializeField]
	public float aoBlurFilterDistance; //Field offset: 0xC4
	[SerializeField]
	public bool useAODistanceCutoff; //Field offset: 0xC8
	[SerializeField]
	public float aoDistanceCutoffLength; //Field offset: 0xCC
	[SerializeField]
	public float aoDistanceCutoffStart; //Field offset: 0xD0
	[SerializeField]
	public SampleCount aoSampleCount; //Field offset: 0xD4
	[SerializeField]
	public AOBlurType aoBlurType; //Field offset: 0xD8
	[SerializeField]
	public float aoLightingContribution; //Field offset: 0xDC
	[SerializeField]
	public bool useChromaticAb; //Field offset: 0xE0
	[SerializeField]
	public AberrationType aberrationType; //Field offset: 0xE4
	[SerializeField]
	public float chromIntensity; //Field offset: 0xE8
	[SerializeField]
	public float chromStart; //Field offset: 0xEC
	[SerializeField]
	public float chromEnd; //Field offset: 0xF0
	[SerializeField]
	public bool useChromaticBlur; //Field offset: 0xF4
	[SerializeField]
	public float chromaticBlurWidth; //Field offset: 0xF8
	[SerializeField]
	public bool useVignette; //Field offset: 0xFC
	[SerializeField]
	public float vignetteStart; //Field offset: 0x100
	[SerializeField]
	public float vignetteEnd; //Field offset: 0x104
	[SerializeField]
	public float vignetteIntensity; //Field offset: 0x108
	[SerializeField]
	public Color vignetteColor; //Field offset: 0x10C
	[SerializeField]
	public bool useNoise; //Field offset: 0x11C
	[SerializeField]
	public float noiseIntensity; //Field offset: 0x120
	[SerializeField]
	public bool useTonemap; //Field offset: 0x124
	[SerializeField]
	public TonemapType toneType; //Field offset: 0x128
	[SerializeField]
	public Vector3 toneValues; //Field offset: 0x12C
	[SerializeField]
	public Vector3 secondaryToneValues; //Field offset: 0x138
	[SerializeField]
	public bool useGammaCorrection; //Field offset: 0x144
	[SerializeField]
	public float gammaValue; //Field offset: 0x148
	[SerializeField]
	public bool useExposure; //Field offset: 0x14C
	[SerializeField]
	public float exposureSpeed; //Field offset: 0x150
	[SerializeField]
	public float exposureMiddleGrey; //Field offset: 0x154
	[SerializeField]
	public float exposureLowerLimit; //Field offset: 0x158
	[SerializeField]
	public float exposureUpperLimit; //Field offset: 0x15C
	[SerializeField]
	public bool useLUT; //Field offset: 0x160
	[SerializeField]
	public string lutPath; //Field offset: 0x168
	[SerializeField]
	public float lutIntensity; //Field offset: 0x170
	[SerializeField]
	public Texture2D twoDLookupTex; //Field offset: 0x178
	[SerializeField]
	public bool useSecondLut; //Field offset: 0x180
	[SerializeField]
	public string secondaryLutPath; //Field offset: 0x188
	[SerializeField]
	public Texture2D secondaryTwoDLookupTex; //Field offset: 0x190
	[SerializeField]
	public float secondaryLutLerpAmount; //Field offset: 0x198
	[SerializeField]
	public bool useNV; //Field offset: 0x19C
	[SerializeField]
	public Color nvColor; //Field offset: 0x1A0
	[SerializeField]
	public Color nvBleachColor; //Field offset: 0x1B0
	[SerializeField]
	public float nvLightingContrib; //Field offset: 0x1C0
	[SerializeField]
	public float nvLightSensitivity; //Field offset: 0x1C4
	[SerializeField]
	public bool useRays; //Field offset: 0x1C8
	[SerializeField]
	public float rayWeight; //Field offset: 0x1CC
	[SerializeField]
	public Color rayColor; //Field offset: 0x1D0
	[SerializeField]
	public Color rayThreshold; //Field offset: 0x1E0

	public PrismPreset() { }

}

