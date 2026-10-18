namespace Audio.AmbientSubsystem;

public class EventFilterHandlerMixerFade : MonoBehaviour
{
	private const string MIXER_TWEEN_ID_PREFIX = "HandlerMixerFade_"; //Field offset: 0x0
	[SerializeField]
	private string _mixerParameter; //Field offset: 0x20
	[SerializeField]
	private AudioMixer _masterMixer; //Field offset: 0x28
	[SerializeField]
	private float _endValue; //Field offset: 0x30
	[SerializeField]
	private float _fadeDuration; //Field offset: 0x34
	[SerializeField]
	private BaseEventFilter _fadeFilter; //Field offset: 0x38
	private string _cachedTweenID; //Field offset: 0x40

	public EventFilterHandlerMixerFade() { }

	[CompilerGenerated]
	private float <FadeFilterHandler>b__8_0() { }

	[CompilerGenerated]
	private void <FadeFilterHandler>b__8_1(float x) { }

	private void Awake() { }

	private void FadeFilterHandler(BaseEventFilter eventFilter, BaseEvent eventToReact) { }

}

