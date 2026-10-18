namespace EFT.UI;

public sealed class UiRecorderController : UIInputNode
{
	private bool _isVisible; //Field offset: 0x80
	private bool _isActive; //Field offset: 0x81
	private Action _stopAction; //Field offset: 0x88
	private AudioSource _recorderAudioSource; //Field offset: 0x90
	private NotificationTapeProgress _activePlaybackNotification; //Field offset: 0x98

	public UiRecorderController() { }

	[CompilerGenerated]
	private void <Init>b__5_0() { }

	public void Init() { }

	private bool IsEnableOnScreen(EEftScreenType screenType) { }

	public void PlayTape(TapeItem tape, Action stopAction) { }

	private void ScreenChangeHandler(EEftScreenType screen) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void StopTape() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

