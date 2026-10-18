//Type is in global namespace

public sealed class SpectatorBlindnessCameraEffectsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ApplyRestoreBurnsNextFrame>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SpectatorBlindnessCameraEffectsController <>4__this; //Field offset: 0x20
		public float receivedTime; //Field offset: 0x28
		public BurnEyesEntry[] burns; //Field offset: 0x30

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
		public <ApplyRestoreBurnsNextFrame>d__17(int <>1__state) { }

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

	private sealed class Stun
	{
		public float Strength; //Field offset: 0x10
		public float BuildUpTime; //Field offset: 0x14
		public float WorkTime; //Field offset: 0x18
		public float WholeTime; //Field offset: 0x1C
		public bool IsIndoor; //Field offset: 0x20

		public Stun() { }

	}

	private readonly List _stuns; //Field offset: 0x20
	private readonly List _appliedBurnPositions; //Field offset: 0x28
	private EyeBurn _eyeBurn; //Field offset: 0x30
	private GrenadeFlashScreenEffect _grenadeFlash; //Field offset: 0x38
	private CC_DoubleVision _doubleVision; //Field offset: 0x40
	private float _maxDoubleScreen; //Field offset: 0x48
	private bool _active; //Field offset: 0x4C
	private Coroutine _deferredBurnsCoroutine; //Field offset: 0x50

	public SpectatorBlindnessCameraEffectsController() { }

	public void Apply(ObservedPlayerView observedPlayer, SpectatorBlindnessState state, bool isLive) { }

	private void ApplyLive(ObservedPlayerView observedPlayer, SpectatorBlindnessState state) { }

	private void ApplyRestore(ObservedPlayerView observedPlayer, SpectatorBlindnessState state) { }

	[IteratorStateMachine(typeof(<ApplyRestoreBurnsNextFrame>d__17))]
	private IEnumerator ApplyRestoreBurnsNextFrame(BurnEyesEntry[] burns, float receivedTime) { }

	private static float CalculateStunStrength(Stun stun) { }

	public void Clear() { }

	private void ClearEffects() { }

	private void Initialize() { }

	private bool IsBurnAlreadyApplied(Vector3 position) { }

	private void ReplaceStuns(ObservedPlayerView observedPlayer, SpectatorBlindnessState state) { }

	private void Update() { }

}

