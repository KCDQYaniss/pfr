namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
[RequireComponent(typeof(Camera))]
internal class TiltShift : PostEffectsBase
{
	internal enum TiltShiftMode
	{
		TiltShiftMode = 0,
		IrisMode = 1,
	}

	internal enum TiltShiftQuality
	{
		Preview = 0,
		Normal = 1,
		High = 2,
	}

	private static readonly int _blurSize; //Field offset: 0x0
	private static readonly int _blurArea; //Field offset: 0x4
	private static readonly int _blurred; //Field offset: 0x8
	public TiltShiftMode mode; //Field offset: 0x30
	public TiltShiftQuality quality; //Field offset: 0x34
	[Range(0, 15)]
	public float blurArea; //Field offset: 0x38
	[Range(0, 25)]
	public float maxBlurSize; //Field offset: 0x3C
	[Range(0, 1)]
	public int downsample; //Field offset: 0x40
	public Shader tiltShiftShader; //Field offset: 0x48
	private Material tiltShiftMaterial; //Field offset: 0x50

	private static TiltShift() { }

	public TiltShift() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

