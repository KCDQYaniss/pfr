namespace EFT.WboitSmoke;

public class IndirectParticlesProfile : ScriptableObject
{
	[SerializeField]
	private ComputeShader _cullingShader; //Field offset: 0x18
	[SerializeField]
	private ComputeShader _depthMinMaxShader; //Field offset: 0x20
	[SerializeField]
	private Material _particleMaterial; //Field offset: 0x28
	[SerializeField]
	private Material _compositeMaterial; //Field offset: 0x30
	[SerializeField]
	private float _particleSize; //Field offset: 0x38
	[SerializeField]
	private float _fadeoutDuration; //Field offset: 0x3C
	[SerializeField]
	private AnimationCurve _lodLevels; //Field offset: 0x40
	[SerializeField]
	[Space]
	private EParticleRenderScale _renderScale; //Field offset: 0x48
	[SerializeField]
	private bool _overrideScaleFromGraphicsSettings; //Field offset: 0x4C
	[Header("Culling")]
	[Min(100)]
	[SerializeField]
	private int _capacity; //Field offset: 0x50
	[SerializeField]
	private float _cullingSpeed; //Field offset: 0x54
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _volumeDepthCullRatio; //Field offset: 0x58
	[Min(0)]
	[SerializeField]
	private float _volumeDepthCullOffset; //Field offset: 0x5C
	[Range(0, 0.1)]
	[SerializeField]
	private float _smokeAlphaClip; //Field offset: 0x60
	[Min(0)]
	[SerializeField]
	private float _smokeDepthRejectBias; //Field offset: 0x64
	[Header("Near Depth Fade")]
	[Min(0)]
	[SerializeField]
	private float _nearDepthFadeMin; //Field offset: 0x68
	[Min(0)]
	[SerializeField]
	private float _nearDepthFadeMax; //Field offset: 0x6C
	[Range(0, 1)]
	[SerializeField]
	private float _nearDepthFadeIntensity; //Field offset: 0x70
	[Header("Foreground Rejection")]
	[Min(0)]
	[SerializeField]
	private float _smokeForegroundDepthBias; //Field offset: 0x74
	[Min(0)]
	[SerializeField]
	private float _smokeForegroundDepthFade; //Field offset: 0x78
	[Range(0, 1)]
	[SerializeField]
	private float _smokeForegroundOcclusionStrength; //Field offset: 0x7C
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _depthMinMaxThreshold; //Field offset: 0x80
	[SerializeField]
	private float _depthEdgeStart; //Field offset: 0x84
	[SerializeField]
	private float _depthEdgeEnd; //Field offset: 0x88
	[SerializeField]
	private float _depthContourBias; //Field offset: 0x8C
	[Header("Particle")]
	[Min(0)]
	[SerializeField]
	private float _rotationSpeedMin; //Field offset: 0x90
	[Min(0)]
	[SerializeField]
	private float _rotationSpeedMax; //Field offset: 0x94
	[SerializeField]
	[Space]
	private EParticleMotionMode _motionMode; //Field offset: 0x98
	[Min(0)]
	[SerializeField]
	private float _sizePulseOffset; //Field offset: 0x9C
	[Min(0)]
	[SerializeField]
	private float _sizePulseFrequency; //Field offset: 0xA0
	[SerializeField]
	[Space]
	private float _smokeAbsorptionScale; //Field offset: 0xA4
	[SerializeField]
	private float _smokeAbsorptionStrength; //Field offset: 0xA8
	[SerializeField]
	[Space]
	private Color _smokeIndoorDayAmbient; //Field offset: 0xAC
	[SerializeField]
	private Color _smokeOutdoorDayAmbient; //Field offset: 0xBC
	[SerializeField]
	[Space]
	private Color _smokeIndoorNightAmbient; //Field offset: 0xCC
	[SerializeField]
	private Color _smokeOutdoorNightAmbient; //Field offset: 0xDC
	[Range(-1, 1)]
	[SerializeField]
	[Space]
	private float _brightness; //Field offset: 0xEC
	[Range(0, 3)]
	[SerializeField]
	private float _contrast; //Field offset: 0xF0
	[Range(0, 3)]
	[SerializeField]
	private float _saturation; //Field offset: 0xF4
	[SerializeField]
	private float _thermalPower; //Field offset: 0xF8

	public float Brightness
	{
		 get { } //Length: 9
	}

	public int Capacity
	{
		 get { } //Length: 4
	}

	public Material CompositeMaterial
	{
		 get { } //Length: 76
	}

	public float Contrast
	{
		 get { } //Length: 9
	}

	public ComputeShader CullingShader
	{
		 get { } //Length: 5
	}

	public float CullingSpeed
	{
		 get { } //Length: 6
	}

	public float DepthContourBias
	{
		 get { } //Length: 9
	}

	public float DepthEdgeEnd
	{
		 get { } //Length: 9
	}

	public float DepthEdgeStart
	{
		 get { } //Length: 9
	}

	public ComputeShader DepthMinMaxShader
	{
		 get { } //Length: 5
	}

	public float DepthMinMaxThreshold
	{
		 get { } //Length: 9
	}

	public float FadeoutDuration
	{
		 get { } //Length: 6
	}

	public AnimationCurve LodLevels
	{
		 get { } //Length: 5
	}

	public EParticleMotionMode MotionMode
	{
		 get { } //Length: 7
	}

	public float NearDepthFadeIntensity
	{
		 get { } //Length: 6
	}

	public float NearDepthFadeMax
	{
		 get { } //Length: 6
	}

	public float NearDepthFadeMin
	{
		 get { } //Length: 6
	}

	public bool OverrideScaleFromGraphicsSettings
	{
		 get { } //Length: 5
	}

	public Material ParticleMaterial
	{
		 get { } //Length: 5
	}

	public float ParticleSize
	{
		 get { } //Length: 6
	}

	public EParticleRenderScale RenderScale
	{
		 get { } //Length: 4
	}

	public float RotationSpeedMax
	{
		 get { } //Length: 9
	}

	public float RotationSpeedMin
	{
		 get { } //Length: 9
	}

	public float Saturation
	{
		 get { } //Length: 9
	}

	public float SizePulseFrequency
	{
		 get { } //Length: 9
	}

	public float SizePulseOffset
	{
		 get { } //Length: 9
	}

	public float SmokeAbsorptionScale
	{
		 get { } //Length: 9
	}

	public float SmokeAbsorptionStrength
	{
		 get { } //Length: 9
	}

	public float SmokeAlphaClip
	{
		 get { } //Length: 6
	}

	public float SmokeDepthRejectBias
	{
		 get { } //Length: 6
	}

	public float SmokeForegroundDepthBias
	{
		 get { } //Length: 6
	}

	public float SmokeForegroundDepthFade
	{
		 get { } //Length: 6
	}

	public float SmokeForegroundOcclusionStrength
	{
		 get { } //Length: 6
	}

	public Color SmokeIndoorDayAmbient
	{
		 get { } //Length: 14
	}

	public Color SmokeIndoorNightAmbient
	{
		 get { } //Length: 14
	}

	public Color SmokeOutdoorDayAmbient
	{
		 get { } //Length: 14
	}

	public Color SmokeOutdoorNightAmbient
	{
		 get { } //Length: 14
	}

	public float ThermalPower
	{
		 get { } //Length: 9
	}

	public float VolumeDepthCullOffset
	{
		 get { } //Length: 6
	}

	public float VolumeDepthCullRatio
	{
		 get { } //Length: 6
	}

	public IndirectParticlesProfile() { }

	public float get_Brightness() { }

	public int get_Capacity() { }

	public Material get_CompositeMaterial() { }

	public float get_Contrast() { }

	public ComputeShader get_CullingShader() { }

	public float get_CullingSpeed() { }

	public float get_DepthContourBias() { }

	public float get_DepthEdgeEnd() { }

	public float get_DepthEdgeStart() { }

	public ComputeShader get_DepthMinMaxShader() { }

	public float get_DepthMinMaxThreshold() { }

	public float get_FadeoutDuration() { }

	public AnimationCurve get_LodLevels() { }

	public EParticleMotionMode get_MotionMode() { }

	public float get_NearDepthFadeIntensity() { }

	public float get_NearDepthFadeMax() { }

	public float get_NearDepthFadeMin() { }

	public bool get_OverrideScaleFromGraphicsSettings() { }

	public Material get_ParticleMaterial() { }

	public float get_ParticleSize() { }

	public EParticleRenderScale get_RenderScale() { }

	public float get_RotationSpeedMax() { }

	public float get_RotationSpeedMin() { }

	public float get_Saturation() { }

	public float get_SizePulseFrequency() { }

	public float get_SizePulseOffset() { }

	public float get_SmokeAbsorptionScale() { }

	public float get_SmokeAbsorptionStrength() { }

	public float get_SmokeAlphaClip() { }

	public float get_SmokeDepthRejectBias() { }

	public float get_SmokeForegroundDepthBias() { }

	public float get_SmokeForegroundDepthFade() { }

	public float get_SmokeForegroundOcclusionStrength() { }

	public Color get_SmokeIndoorDayAmbient() { }

	public Color get_SmokeIndoorNightAmbient() { }

	public Color get_SmokeOutdoorDayAmbient() { }

	public Color get_SmokeOutdoorNightAmbient() { }

	public float get_ThermalPower() { }

	public float get_VolumeDepthCullOffset() { }

	public float get_VolumeDepthCullRatio() { }

}

