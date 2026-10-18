namespace EFT.UI.Browser;

public sealed class BrowserSoundHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public BrowserSoundHandler <>4__this; //Field offset: 0x10
		public int generation; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal bool <PlaySoundPreviewAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <PlaySoundPreviewAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BrowserSoundHandler <>4__this; //Field offset: 0x20
		public int generation; //Field offset: 0x28
		public string voiceName; //Field offset: 0x30
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x38
		public Action onFinished; //Field offset: 0x40
		public string soundId; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Header("Sounds")]
	[SerializeField]
	private BrowserEventSoundsDictionary _eventSounds; //Field offset: 0x20
	[Header("Music")]
	[SerializeField]
	private AudioClipConfig[] _shopMusic; //Field offset: 0x28
	[SerializeField]
	private bool _routeShopMusicToUI; //Field offset: 0x30
	[Header("Ambient")]
	[SerializeField]
	private BrowserThemeAmbientsDictionary _eventAmbients; //Field offset: 0x38
	[SerializeField]
	private EShopSoundTheme _defaultTheme; //Field offset: 0x40
	[Header("Theme Overrides")]
	[SerializeField]
	private ShopSoundThemesDictionary _soundThemes; //Field offset: 0x48
	[Header("Shop Loader")]
	[SerializeField]
	private AudioClipConfig _shopLoaderLoop; //Field offset: 0x50
	[Header("Purchase")]
	[SerializeField]
	private AudioClipConfig _purchaseAnimationSound; //Field offset: 0x58
	[SerializeField]
	private AudioClipConfig _purchaseTimerLoop; //Field offset: 0x60
	private EShopSoundTheme _currentTheme; //Field offset: 0x68
	private AudioSource _purchaseAnimationSource; //Field offset: 0x70
	private readonly VoicePreviewSpeaker _voicePreviewSpeaker; //Field offset: 0x78
	private int _soundPreviewGeneration; //Field offset: 0x80

	public BrowserSoundHandler() { }

	private void ApplySoundTheme(EShopSoundTheme theme) { }

	private void CancelSoundPreview() { }

	private void ConfigurePurchaseAnimationSource(AudioSource source) { }

	private void HandleChangeSoundTheme(JObject obj) { }

	public void OnClose() { }

	public void OnShopShow() { }

	public void OnSoundEvent(EBrowserSoundEventType eventType, JObject obj) { }

	private void PlayPurchaseAnimationSound() { }

	private void PlayPurchaseTimerLoop() { }

	public void PlaySoundPreview(JObject obj, Action onFinished) { }

	[AsyncStateMachine(typeof(<PlaySoundPreviewAsync>d__28))]
	private Task PlaySoundPreviewAsync(string soundId, string voiceName, int generation, Action onFinished) { }

	public void ResetShopAudio() { }

	private void StopPurchaseAnimationSound(bool allowFadeout = true) { }

	private void StopPurchaseTimerLoop() { }

	private static void StopSoundPreview() { }

	private void TryPlayEventSound(EBrowserSoundEventType eventType) { }

	private void TryPlayPurchaseAnimationSounds(EBrowserSoundEventType eventType) { }

	private static bool TryResolveSoundPreview(JObject obj, out string soundId, out string voiceName) { }

	private void TryStartShopMusic() { }

}

