namespace EFT.UI;

public sealed class GUISounds : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public GUISounds <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass59_0() { }

		internal void <PlayMenuBackgroundMusicDelayed>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public GUISounds <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass63_0() { }

		internal void <StopMenuBackgroundMusicWithDelay>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public Action callback; //Field offset: 0x10

		public <>c__DisplayClass65_0() { }

		internal void <FadeBackgroundMusic>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public string fileName; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <GetLootingClip>b__0(AudioClip x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public GUISounds <>4__this; //Field offset: 0x10
		public AudioSource source; //Field offset: 0x18
		public Action onStopped; //Field offset: 0x20

		public <>c__DisplayClass82_0() { }

		internal void <StopUiLoop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <CO_ForcePlaySound>d__53 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GUISounds <>4__this; //Field offset: 0x20
		public AudioClip clip; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CO_ForcePlaySound>d__53(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <CO_PlayMusicPool>d__92 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IReadOnlyList pool; //Field offset: 0x20
		public GUISounds <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CO_PlayMusicPool>d__92(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <CO_PlayOneShotWhenDataLoaded>d__78 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioClip clip; //Field offset: 0x20
		public AudioSource src; //Field offset: 0x28
		public float volume; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CO_PlayOneShotWhenDataLoaded>d__78(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <FadeBackgroundMusicAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GUISounds <>4__this; //Field offset: 0x20
		public bool isActive; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GUISounds <>4__this; //Field offset: 0x20
		public AudioSource audioSource; //Field offset: 0x28
		private ResourceRequest <mixerLoading>5__2; //Field offset: 0x30
		private ResourceRequest <uiSoundsLoading>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float BACKGROUND_MUSIC_FADE_TIME = 2; //Field offset: 0x0
	private const float IN_RAID_SOUNDS_VOLUME = 0.15; //Field offset: 0x0
	private const string MenuBackgroundMusicDirectory = "Audio/Music/"; //Field offset: 0x0
	private AudioSource _uiAudioSource; //Field offset: 0x20
	private AudioSource _commonAudioSource; //Field offset: 0x28
	private AudioSource _chatAudioSource; //Field offset: 0x30
	private AudioSource _backgroundMusicAudioSource; //Field offset: 0x38
	private AudioSource _shopMusicAudioSource; //Field offset: 0x40
	private AudioSource _singleAudioSource; //Field offset: 0x48
	private AudioMixer _masterMixer; //Field offset: 0x50
	private Coroutine _delayedAudioCallbackCoroutine; //Field offset: 0x58
	private IEnumerator _playMusicDelayCoroutine; //Field offset: 0x60
	private AudioClip[] _mainMenuMusic; //Field offset: 0x68
	private int _currentMusicIndex; //Field offset: 0x70
	private ItemSounds _itemSounds; //Field offset: 0x78
	private UISoundsWrapper _UISounds; //Field offset: 0x80
	private Coroutine _forcePlaySoundCoroutine; //Field offset: 0x88
	private Nullable _originalBackgroundMusicVolume; //Field offset: 0x90
	private Nullable _originalSingleSourceVolume; //Field offset: 0x98
	private AudioMixerGroup _uiMixerGroup; //Field offset: 0xA0
	private AudioMixerGroup _effectsMixerGroup; //Field offset: 0xA8
	private AudioMixerGroup _masterMixerGroup; //Field offset: 0xB0
	private AudioMixerGroup _musicMixerGroup; //Field offset: 0xB8
	private CrossfadeUnityAudioPlayer _ambientPlayer; //Field offset: 0xC0
	private CrossfadeUnityAudioPlayer _musicPlayer; //Field offset: 0xC8
	private UiAudioSourcePool _uiAudioSourcePool; //Field offset: 0xD0
	private AudioSource _uiLoopSource; //Field offset: 0xD8
	private AudioClipConfig _uiLoopConfig; //Field offset: 0xE0
	private bool _uiLoopStopping; //Field offset: 0xE8
	private Coroutine _musicPoolCoroutine; //Field offset: 0xF0
	private int _lastShopMusicPoolIndex; //Field offset: 0xF8
	private float _shopFadeOutTime; //Field offset: 0xFC
	[CompilerGenerated]
	private AudioMixer <MasterMixer>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private bool <BackgroundMusicActive>k__BackingField; //Field offset: 0x108

	public private bool BackgroundMusicActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private AudioMixer MasterMixer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AudioMixerGroup MasterMixerGroup
	{
		 get { } //Length: 8
	}

	public AudioMixerGroup MusicMixerGroup
	{
		 get { } //Length: 8
	}

	public AudioMixerGroup UIMixerGroup
	{
		 get { } //Length: 8
	}

	public GUISounds() { }

	[CompilerGenerated]
	private void <LoadItemSounds>b__47_0() { }

	private static AudioClipConfig CloneWithVolume(AudioClipConfig src, float volumeMul) { }

	[IteratorStateMachine(typeof(<CO_ForcePlaySound>d__53))]
	private IEnumerator CO_ForcePlaySound(AudioClip clip) { }

	[IteratorStateMachine(typeof(<CO_PlayMusicPool>d__92))]
	private IEnumerator CO_PlayMusicPool(IReadOnlyList pool) { }

	[IteratorStateMachine(typeof(<CO_PlayOneShotWhenDataLoaded>d__78))]
	private IEnumerator CO_PlayOneShotWhenDataLoaded(AudioSource src, AudioClip clip, float volume = 1) { }

	public static bool Exist(out GUISounds guiSounds) { }

	internal void FadeBackgroundMusic(bool isActive, Action callback = null) { }

	[AsyncStateMachine(typeof(<FadeBackgroundMusicAsync>d__66))]
	internal Task FadeBackgroundMusicAsync(bool isActive, CancellationToken token) { }

	public void ForcePlaySound(AudioClip clip) { }

	[CompilerGenerated]
	public bool get_BackgroundMusicActive() { }

	[CompilerGenerated]
	public AudioMixer get_MasterMixer() { }

	public AudioMixerGroup get_MasterMixerGroup() { }

	public AudioMixerGroup get_MusicMixerGroup() { }

	public AudioMixerGroup get_UIMixerGroup() { }

	private AudioMixerGroup GetCommonSoundsMixerGroup() { }

	private float GetCommonSoundsVolume() { }

	[CanBeNull]
	public AudioClip GetItemClip(string soundGroup, EInventorySoundType soundType) { }

	[CanBeNull]
	public AudioClip GetLootingClip(string fileName) { }

	[AsyncStateMachine(typeof(<Init>d__46))]
	internal Task Init(AudioSource audioSource) { }

	internal void LoadItemSounds() { }

	private void OnDestroy() { }

	internal void PauseMenuBackgroundMusic() { }

	private static int PickNextPoolIndex(int count, ref int lastIndex) { }

	public void PlayAmbient(AudioClipConfig config, AudioMixerGroup mixerGroup = null, bool force = false) { }

	public void PlayChatSound(ESocialNetworkSoundType soundType) { }

	private void PlayCrossfadeSound(ref CrossfadeUnityAudioPlayer audioPlayer, AudioClipConfig config, AudioMixerGroup mixerGroup = null, bool force = false) { }

	public void PlayEndGameSound(EEndGameSoundType soundType) { }

	public bool PlayItemSound(EModClass itemClass) { }

	public void PlayItemSound(string soundGroup, EInventorySoundType soundType, bool single = false) { }

	public void PlayKarmaSound(bool isPositive) { }

	internal void PlayMenuBackgroundMusic() { }

	internal void PlayMenuBackgroundMusicDelayed(float delay = 1, Action callback = null) { }

	public void PlayMusic(AudioClipConfig config, AudioMixerGroup mixerGroup = null, bool force = false) { }

	public void PlayMusicPool(IReadOnlyList pool, AudioMixerGroup mixerGroup = null) { }

	public void PlayNotificationSound() { }

	public void PlayResultExitSound(ExitStatus exitStatus) { }

	internal void PlaySessionEnd(ExitStatus exitStatus) { }

	public void PlaySound(AudioClip clip, bool single = false, bool commonUiSound = false, float volumeScale = 1) { }

	public void PlayUILoadSound() { }

	public void PlayUiLoop(AudioClipConfig config, bool commonUISound = false) { }

	public void PlayUISound(EUISoundType soundType) { }

	public void PlayUIUnloadSound() { }

	public AudioSource RentUiAudioSource(bool commonUISound = false) { }

	internal void ResumeMenuBackgroundMusic() { }

	public void ReturnUiAudioSource(AudioSource source) { }

	[CompilerGenerated]
	private void set_BackgroundMusicActive(bool value) { }

	[CompilerGenerated]
	private void set_MasterMixer(AudioMixer value) { }

	public void StopAmbient(bool allowFadeout = true, Action onStopped = null) { }

	public void StopAndReturnUiAudioSource(AudioSource source, float fadeOutTime = 0, Action onReturned = null) { }

	private void StopAudioCallbackCoroutine() { }

	public void StopForcePlaySound() { }

	internal void StopMenuBackgroundMusic() { }

	public void StopMenuBackgroundMusicWithDelay(float transitionTime = 1, Action callback = null) { }

	public void StopMusic(bool allowFadeout = true, Action onStopped = null) { }

	public void StopMusicPool(bool allowFadeout = true, Action onStopped = null) { }

	public void StopUiLoop(bool allowFadeout = true, Action onStopped = null) { }

	public void StopUiLoop(AudioClipConfig config, bool allowFadeout = true) { }

	public bool TryPlaySound(AudioClip clip, out AudioSource source, bool single = false, bool commonUiSound = false, float volumeScale = 1, bool routeToMaster = false) { }

	private bool UseStandardUIRouting() { }

}

