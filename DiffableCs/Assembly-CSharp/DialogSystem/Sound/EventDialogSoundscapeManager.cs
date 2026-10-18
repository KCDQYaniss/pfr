namespace DialogSystem.Sound;

public class EventDialogSoundscapeManager : IDialogSoundscapeManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public int remaining; //Field offset: 0x10
		public Action onCompleted; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <Release>g__Notify|0() { }

	}

	private const string TYPE_WRITER_SOUND_NAME = "targrad_quill"; //Field offset: 0x0
	private const string QUIT_GAME_SOUND_NAME = "targrad_quit_game"; //Field offset: 0x0
	private const string START_GAME_SOUND_NAME = "targrad_start_game"; //Field offset: 0x0
	private const float LOWPASS_HIDEOUT_TRANSITION_TIME = 2; //Field offset: 0x0
	private readonly MediaAnimationController _animationController; //Field offset: 0x10
	private readonly ClientDialogController _dialogController; //Field offset: 0x18
	private readonly AudioClipConfigDictionary _clipData; //Field offset: 0x20
	private readonly IConfiguredAudioPlayer _musicPlayer; //Field offset: 0x28
	private readonly IConfiguredAudioPlayer _soundPlayer; //Field offset: 0x30
	private readonly IConfiguredAudioPlayer _typeWriterPlayer; //Field offset: 0x38
	private readonly IConfiguredAudioPlayer _sfxPlayer; //Field offset: 0x40
	private readonly List _players; //Field offset: 0x48
	private CompositeDisposable _disposables; //Field offset: 0x50

	public EventDialogSoundscapeManager(MediaAnimationController animationController, ClientDialogController dialogController, AudioClipConfigDictionary clipData) { }

	[CompilerGenerated]
	private void <Initialize>b__14_0() { }

	[CompilerGenerated]
	private void <Initialize>b__14_1() { }

	[CompilerGenerated]
	private void <Initialize>b__14_2() { }

	[CompilerGenerated]
	private void <Initialize>b__14_3() { }

	[CompilerGenerated]
	private void <Initialize>b__14_4() { }

	[CompilerGenerated]
	private void <Initialize>b__14_5() { }

	private void ActionFinishedHandler(DialogAction action) { }

	public override void Initialize() { }

	private void MusicChangeHandler(string musicName) { }

	private void PlaySFX(string soundName) { }

	private void PlayTypeWriterSound(string text) { }

	public override void Release(bool allowFadeOut = false, Action onCompleted = null) { }

	private void SoundChangeHandler(string musicName) { }

	private void StopTypeWriterSound() { }

	private void TryPlay(IConfiguredAudioPlayer player, string soundName) { }

}

