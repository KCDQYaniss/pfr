//Type is in global namespace

public class GlitchController
{
	private static readonly int _verticalJump; //Field offset: 0x0
	private static readonly int _scanLineJitter; //Field offset: 0x4
	private static readonly int _horizontalShake; //Field offset: 0x8
	private static readonly int _colorDrift; //Field offset: 0xC
	private static readonly int _digitalMistakeIntensity; //Field offset: 0x10
	private static readonly int _colorSwitchIntensity; //Field offset: 0x14
	private static readonly int _dispTex; //Field offset: 0x18
	private static readonly int _filterRadius; //Field offset: 0x1C
	private static readonly int _direction; //Field offset: 0x20
	private static readonly int _flipUp; //Field offset: 0x24
	private static readonly int _flipDown; //Field offset: 0x28
	private static readonly int _displace; //Field offset: 0x2C
	private static readonly int _scale; //Field offset: 0x30
	private static readonly int _glitchTempRT; //Field offset: 0x34
	private ThermalVision _thermalVision; //Field offset: 0x10
	private Material _material; //Field offset: 0x18
	private float _currentColorSwitchIntensity; //Field offset: 0x20
	private float _glitchup; //Field offset: 0x24
	private float _glitchdown; //Field offset: 0x28
	private float _flicker; //Field offset: 0x2C
	private float _glitchupTime; //Field offset: 0x30
	private float _glitchdownTime; //Field offset: 0x34
	private float _flickerTime; //Field offset: 0x38

	private static GlitchController() { }

	public GlitchController(ThermalVision thermalVision) { }

	private float IsHappeningNow(float frequency) { }

	private void SetFirstPassMaterialproperties() { }

	private void SetZeroPassMaterialproperties() { }

	public void UpdateTexture(CommandBuffer commandBuffer) { }

}

