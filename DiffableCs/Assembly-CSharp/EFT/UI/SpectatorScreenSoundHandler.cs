namespace EFT.UI;

public sealed class SpectatorScreenSoundHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CO_GlitchLoop>d__33 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SpectatorScreenSoundHandler <>4__this; //Field offset: 0x20

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
		public <CO_GlitchLoop>d__33(int <>1__state) { }

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

	private struct GlitchPlaybackSettings
	{
		public float volume; //Field offset: 0x0
		public Vector2 offsetRange; //Field offset: 0x4

	}

	[SerializeField]
	private AudioSingleClipContainer _enterSound; //Field offset: 0x20
	[SerializeField]
	private AudioSingleClipContainer _exitSound; //Field offset: 0x28
	[SerializeField]
	private AudioClipConfig _cameraNoiseLoopConfig; //Field offset: 0x30
	[SerializeField]
	private AudioMultipleClipContainer _swapSounds; //Field offset: 0x38
	[SerializeField]
	[Space]
	private AudioMultipleClipContainer _glitchSounds; //Field offset: 0x40
	[SerializeField]
	private GlitchPlaybackSettings _glitchSettings; //Field offset: 0x48
	[SerializeField]
	private GlitchPlaybackSettings _infiniteGlitchSettings; //Field offset: 0x54
	private ISpectatorAudio _audio; //Field offset: 0x60
	private Coroutine _glitchLoopCoroutine; //Field offset: 0x68
	private bool _noSignalGlitchesActive; //Field offset: 0x70
	private bool _noSignalEnabled; //Field offset: 0x71
	private bool _noSignalInfinite; //Field offset: 0x72
	private ISpectatorController _spectatorController; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x80

	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SpectatorScreenSoundHandler() { }

	private void ApplyNoSignalAudio() { }

	public void Bind(ISpectatorAudio audio) { }

	[IteratorStateMachine(typeof(<CO_GlitchLoop>d__33))]
	private IEnumerator CO_GlitchLoop() { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void OnEnter(ISpectatorController spectatorController) { }

	public void OnExit() { }

	public void PlaySwap() { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	public void SetNoSignal(bool active, bool infinite = false) { }

	private void StartGlitchLoop() { }

	private void StopGlitchLoop() { }

	private void SubscribeWhiteNoise(ISpectatorController spectatorController) { }

	public void SyncNoSignalState() { }

	private void UnsubscribeWhiteNoise() { }

	private void WhiteNoiseEffectStatusChangedHandler(bool enable) { }

}

