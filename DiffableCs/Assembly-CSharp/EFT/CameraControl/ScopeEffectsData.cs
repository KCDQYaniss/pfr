namespace EFT.CameraControl;

public class ScopeEffectsData : MonoBehaviour
{
	public bool ChromaticAberration; //Field offset: 0x20
	public int ChromaticAberrationAniso; //Field offset: 0x24
	public float ChromaticAberrationShift; //Field offset: 0x28
	[Space]
	public bool BloomOptimized; //Field offset: 0x2C
	public float BloomOptimizedIntensity; //Field offset: 0x30
	public float BloomOptimizedThreshold; //Field offset: 0x34
	public float BloomOptimizedBlurSize; //Field offset: 0x38
	[Space]
	public bool FastVignette; //Field offset: 0x3C
	public bool UltimateBloom; //Field offset: 0x3D
	public bool Fisheye; //Field offset: 0x3E
	[Space]
	public bool Tonemapping; //Field offset: 0x3F
	public float White; //Field offset: 0x40
	public float AdaptionSpeed; //Field offset: 0x44
	public float ExposureAdjustment; //Field offset: 0x48
	public float MiddleGrey; //Field offset: 0x4C
	public AdaptiveTexSize AdaptiveTextureSize; //Field offset: 0x50
	public TonemapperType Type; //Field offset: 0x54

	public ScopeEffectsData() { }

}

