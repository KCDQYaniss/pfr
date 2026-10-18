namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", True)]
public sealed class AutoExposure : PostProcessEffectSettings
{
	[DisplayName("Filtering (%)")]
	[MinMax(1, 99)]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	public Vector2Parameter filtering; //Field offset: 0x30
	[DisplayName("Minimum (EV)")]
	[Range(-9, 9)]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter minLuminance; //Field offset: 0x38
	[DisplayName("Maximum (EV)")]
	[Range(-9, 9)]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter maxLuminance; //Field offset: 0x40
	[DisplayName("Exposure Compensation")]
	[Min(0)]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	public FloatParameter keyValue; //Field offset: 0x48
	[DisplayName("Type")]
	[Tooltip("Use \"Progressive\" if you want auto exposure to be animated. Use \"Fixed\" otherwise.")]
	public EyeAdaptationParameter eyeAdaptation; //Field offset: 0x50
	[Min(0)]
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	public FloatParameter speedUp; //Field offset: 0x58
	[Min(0)]
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	public FloatParameter speedDown; //Field offset: 0x60

	public AutoExposure() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

