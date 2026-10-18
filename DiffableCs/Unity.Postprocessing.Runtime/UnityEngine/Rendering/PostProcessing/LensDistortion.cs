namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", True)]
public sealed class LensDistortion : PostProcessEffectSettings
{
	[Range(-100, 100)]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity; //Field offset: 0x30
	[DisplayName("X Multiplier")]
	[Range(0, 1)]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityX; //Field offset: 0x38
	[DisplayName("Y Multiplier")]
	[Range(0, 1)]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityY; //Field offset: 0x40
	[Range(-1, 1)]
	[Space]
	[Tooltip("Distortion center point (x-axis).")]
	public FloatParameter centerX; //Field offset: 0x48
	[Range(-1, 1)]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY; //Field offset: 0x50
	[Range(0.01, 5)]
	[Space]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale; //Field offset: 0x58

	public LensDistortion() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

