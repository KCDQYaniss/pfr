namespace CommonAssets.Scripts.ArtilleryShelling.Client.Audio;

public class ArtilleryShellingSoundControllerClient : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public ArtilleryShellingSoundControllerClient <>4__this; //Field offset: 0x10
		public int projectileID; //Field offset: 0x18
		public BetterSource source; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <ShellExplosionHandler>b__0() { }

	}

	[CompilerGenerated]
	private struct <Init>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtilleryShellingSoundControllerClient <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSoundsSo>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtilleryShellingSoundControllerClient <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <PlayMortarSoundWithDelayCoroutine>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public ArtilleryShellingSoundControllerClient <>4__this; //Field offset: 0x28
		public Vector3 startPosition; //Field offset: 0x30

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
		public <PlayMortarSoundWithDelayCoroutine>d__16(int <>1__state) { }

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
	private sealed class <WhistleCoroutine>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ArtilleryShellingSoundControllerClient <>4__this; //Field offset: 0x20
		public Vector3 startPos; //Field offset: 0x28
		public Vector3 endPos; //Field offset: 0x34
		public float speed; //Field offset: 0x40
		public IAudioClipContainer clipContainer; //Field offset: 0x48
		public int projectileID; //Field offset: 0x50
		public BetterSource source; //Field offset: 0x58
		private float <volume>5__2; //Field offset: 0x60
		private float <rndPitch>5__3; //Field offset: 0x64
		private float <totalTime>5__4; //Field offset: 0x68
		private AudioClip <clip>5__5; //Field offset: 0x70
		private float <timeToPlay>5__6; //Field offset: 0x78
		private float <elapsedTime>5__7; //Field offset: 0x7C

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
		public <WhistleCoroutine>d__19(int <>1__state) { }

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

	private const float LOOP_SOURCE_FADE_DURATION_SEC = 0.3; //Field offset: 0x0
	private readonly StaticManager _staticManager; //Field offset: 0x10
	private readonly IEasyAssets _easyAssets; //Field offset: 0x18
	private readonly IReadOnlyDictionary _activeClientProjectiles; //Field offset: 0x20
	private readonly Dictionary _shellLoopSources; //Field offset: 0x28
	private readonly Dictionary _whistlesCoroutines; //Field offset: 0x30
	private Token _token; //Field offset: 0x38
	private ArtilleryShellingSoundsSO _artilleryShellingSounds; //Field offset: 0x40
	private bool _disposed; //Field offset: 0x48
	private Action _unsubscribeOnDispose; //Field offset: 0x50

	public ArtilleryShellingSoundControllerClient(IReadOnlyDictionary activeClientProjectiles) { }

	private void ClearLoopSource(int id, BetterSource source) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[AsyncStateMachine(typeof(<Init>d__11))]
	public Task Init() { }

	[AsyncStateMachine(typeof(<LoadSoundsSo>d__12))]
	private Task LoadSoundsSo() { }

	private void PlayMortarShotSound(Vector3 startPosition) { }

	private void PlayMortarSoundWithDelay(Vector3 startPosition, float distanceToListener) { }

	[IteratorStateMachine(typeof(<PlayMortarSoundWithDelayCoroutine>d__16))]
	private IEnumerator PlayMortarSoundWithDelayCoroutine(float delay, Vector3 startPosition) { }

	private void PlayWhistleSound(BetterSource source, AudioClip clip, float rolloff, float volume, float pitch, Transform parent) { }

	private void ReleaseSource(BetterSource source) { }

	private void ShellCreatedHandler(ShellProjectileCreateEvent createEvent) { }

	private void ShellExplosionHandler(ShellProjectileExplosionEvent explosionEvent) { }

	private void ShellingProjectileInitFlyHandler(InitShellingProjectileFlyEvent flyEvent) { }

	private void StopWhistleCoroutine(int projectileID) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	[IteratorStateMachine(typeof(<WhistleCoroutine>d__19))]
	private IEnumerator WhistleCoroutine(BetterSource source, int projectileID, IAudioClipContainer clipContainer, Vector3 startPos, Vector3 endPos, float speed) { }

}

