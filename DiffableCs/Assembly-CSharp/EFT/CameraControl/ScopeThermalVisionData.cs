namespace EFT.CameraControl;

public class ScopeThermalVisionData : MonoBehaviour
{
	public bool ThermalVision; //Field offset: 0x20
	public bool ThermalVisionIsGlitch; //Field offset: 0x21
	public bool ThermalVisionIsPixelated; //Field offset: 0x22
	public bool ThermalVisionIsNoisy; //Field offset: 0x23
	public bool ThermalVisionIsMotionBlurred; //Field offset: 0x24
	public bool ThermalVisionIsFpsStuck; //Field offset: 0x25
	public ThermalVisionUtilities ThermalVisionUtilities; //Field offset: 0x28
	public StuckFPSUtilities StuckFPSUtilities; //Field offset: 0x30
	public MotionBlurUtilities MotionBlurUtilities; //Field offset: 0x38
	public GlitchUtilities GlitchUtilities; //Field offset: 0x40
	public PixelationUtilities PixelationUtilities; //Field offset: 0x48
	public float ChromaticAberrationThermalShift; //Field offset: 0x50
	public float UnsharpBias; //Field offset: 0x54
	public float UnsharpRadiusBlur; //Field offset: 0x58

	public ScopeThermalVisionData() { }

}

