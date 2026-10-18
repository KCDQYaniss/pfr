namespace UI.Utilities;

public sealed class EnvironmentPortableRadioController : MonoBehaviour
{
	[SerializeField]
	private AnimationEventLocalSoundPlayer _soundPlayer; //Field offset: 0x20
	[SerializeField]
	private Animator[] _animators; //Field offset: 0x28
	private EEftScreenType _screenType; //Field offset: 0x30
	private bool _browserVisible; //Field offset: 0x34
	private bool _animationStarted; //Field offset: 0x35
	private Action _unsubscribeBrowserVisibility; //Field offset: 0x38

	public EnvironmentPortableRadioController() { }

	private void ApplyPlayback() { }

	private void Awake() { }

	private void OnBrowserVisibilityChanged(BrowserVisibilityChangedEvent visibilityEvent) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnScreenChanged(EEftScreenType screenType) { }

	private void SetAnimatorsEnabled(bool enabled) { }

}

