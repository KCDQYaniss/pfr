namespace CommonAssets.Scripts.RunddansEvent;

public class EventObjectSoundController : MonoBehaviour
{
	private const float DELAY_OFFSET = 0.1; //Field offset: 0x0
	[SerializeField]
	private EventObject _eventObject; //Field offset: 0x20
	[SerializeField]
	private AudioSingleClipContainer _readySound; //Field offset: 0x28
	[SerializeField]
	private AudioSingleClipContainer _runningStartSound; //Field offset: 0x30
	[SerializeField]
	private AudioSingleClipContainer _runningLoopSound; //Field offset: 0x38
	[SerializeField]
	private AudioSingleClipContainer _stopSound; //Field offset: 0x40
	[SerializeField]
	private bool _spatialize; //Field offset: 0x48
	[SerializeField]
	private float _loopFadeTime; //Field offset: 0x4C
	private BetterSource _sourceOneShot; //Field offset: 0x50
	private BetterSource _sourceLoop; //Field offset: 0x58
	private EState _prevState; //Field offset: 0x60
	private Action _unsubOnDestroy; //Field offset: 0x68

	public EventObjectSoundController() { }

	[CompilerGenerated]
	private void <PlayRunningSound>b__19_0() { }

	[CompilerGenerated]
	private void <PlayStopSound>b__20_0() { }

	[CompilerGenerated]
	private void <PlayStopSound>b__20_1() { }

	public void Awake() { }

	private BetterSource CreateSource() { }

	private void EventObjectStateChangeHandler(EState state) { }

	private float GetDelay(IAudioClipContainer container) { }

	private void InitSource(BetterSource source) { }

	private void OnDestroy() { }

	private void PlayReadySound() { }

	private void PlayRunningSound() { }

	private void PlaySound(BetterSource source, IAudioClipContainer container, bool oneShot = false, bool loop = false) { }

	private void PlayStopSound() { }

	private void ReleaseSource(ref BetterSource source) { }

	private void SpatialAudioSystemInitHandler(SpatialAudioSystemInitializedEvent initializedEvent) { }

	public void Start() { }

}

