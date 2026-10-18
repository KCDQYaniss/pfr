namespace Audio.AmbientSubsystem;

public class AmbientSoundBlender : MonoBehaviour, IDisposable
{
	private const float MIN_MIXER_VOLUME_DB = -80; //Field offset: 0x0
	private const float MAX_MIXER_PARAM_VALUE = 1; //Field offset: 0x0
	private const float MAX_LOWPASS_FREQ = 22000; //Field offset: 0x0
	private const float MIN_MIXER_PARAM_VALUE = 0; //Field offset: 0x0
	[Header("Default Transitions")]
	[SerializeField]
	[Tooltip("Fade type for indoor context (entering indoor, being inside, muffling outdoor)")]
	private EAudioFadeType fadeInType; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Fade type for outdoor context (going outdoor, being outside, opening outdoor)")]
	private EAudioFadeType fadeOutType; //Field offset: 0x24
	[SerializeField]
	private float _fadeInDuration; //Field offset: 0x28
	[SerializeField]
	private float _fadeOutDuration; //Field offset: 0x2C
	[SerializeField]
	private float _fromOutToInTransitionTime; //Field offset: 0x30
	[SerializeField]
	private float _fromInToOutTransitionTime; //Field offset: 0x34
	[SerializeField]
	private AudioMixerParametersData _outdoorMixerParams; //Field offset: 0x38
	[SerializeField]
	private AudioMixerParametersData _indoorMixerParams; //Field offset: 0x40
	[SerializeField]
	private AnimationCurve _volumeCurve; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve _occlusionCurve; //Field offset: 0x50
	[SerializeField]
	private float _blendSpeed; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Outdoor blend speed when no portal is available")]
	private float _noPortalBlendSpeed; //Field offset: 0x5C
	[SerializeField]
	private float _blendDurationMult; //Field offset: 0x60
	[Header("Filters Settings")]
	[SerializeField]
	private float _maxHighPassFreq; //Field offset: 0x64
	[SerializeField]
	private float _minHighPassFreq; //Field offset: 0x68
	[SerializeField]
	private float _minLowpassFreq; //Field offset: 0x6C
	[SerializeField]
	private float _maxLowpassFreq; //Field offset: 0x70
	[Header("Effects Send")]
	[SerializeField]
	private float _maxOutdoorReverbSendDb; //Field offset: 0x74
	[SerializeField]
	private float _maxOutdoorDelaySendDb; //Field offset: 0x78
	private AudioMixer _masterMixer; //Field offset: 0x80
	private IAudioMixerFader _outdoorMixerFader; //Field offset: 0x88
	private IAudioMixerFader _indoorMixerFader; //Field offset: 0x90
	private AudioMixerParamsContainer[] _resolvedOutdoorParams; //Field offset: 0x98
	private AudioMixerParamsContainer[] _resolvedIndoorParams; //Field offset: 0xA0
	private float _currentOutdoorFilterValue; //Field offset: 0xA8

	public AmbientSoundBlender() { }

	private void ApplyMixerParams(EMixerParameterType parameterType, AudioMixerParamsContainer[] resolvedParams, IAudioMixerFader fader, float value, float duration = 0, EAudioFadeType fadeType = 0) { }

	private void ApplyOutdoorMixerParams(float volumeDb, float lowPassFreq, float highPassFreq, float reverbSendDb, float delaySendDb, float duration, EAudioFadeType fadeType) { }

	public void BlendToIndoor() { }

	public void BlendToOutdoor() { }

	public void BlendToTargetPerFrame(float targetValue, float maxOutdoorFreq, float dt) { }

	public void BlendToTargetValue(float value, float maxOutdoorVolume, float maxOutdoorFreq) { }

	public void CalculateAndApplyMixerParameters(in PortalCalculatedData portalData, Vector3 listenerPos, float maxOutdoorVolume, float maxOutdoorFreq, float depthCalculationMult, float listenerHeightWeight, float dt) { }

	private float CalculateOutdoorFilterValue(float portalDepth, float currentDistance, float depthMult) { }

	public override void Dispose() { }

	public void Init(AudioMixer masterMixer) { }

	private void OnDestroy() { }

	private static AudioMixerParamsContainer[] ResolveMixerParams(AudioMixerParametersData data) { }

	public void SetIndoorMixerParams(float value, float targetBlendDuration = 0.5, bool immediate = true, Nullable fadeType = null) { }

	public void SetOutdoorMixerParams(float value, float maxOutdoorVolume, float maxOutdoorFreq, float targetBlendDuration = 0.5, bool immediate = true, Nullable fadeType = null) { }

}

