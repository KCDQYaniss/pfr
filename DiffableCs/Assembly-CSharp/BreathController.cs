//Type is in global namespace

public class BreathController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <BreathLoop>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BreathController <>4__this; //Field offset: 0x20
		private int <maxBreaths>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x2C

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
		public <BreathLoop>d__23(int <>1__state) { }

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
	private sealed class <InitializeBreath>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BreathController <>4__this; //Field offset: 0x20

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
		public <InitializeBreath>d__14(int <>1__state) { }

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

	[SerializeField]
	private Transform BreathPrefab; //Field offset: 0x20
	[SerializeField]
	private int EmitCount; //Field offset: 0x28
	[SerializeField]
	private float BreathInterval; //Field offset: 0x2C
	private Transform _breathTr; //Field offset: 0x30
	private ParticleSystem[] _breathSystems; //Field offset: 0x38
	private Transform _camera; //Field offset: 0x40
	private Coroutine _breathRoutine; //Field offset: 0x48
	private float _lastBreathTime; //Field offset: 0x50
	private WaitForSecondsRealtime _breathWaitForSeconds; //Field offset: 0x58

	private WaitForSecondsRealtime BreathDelay
	{
		private get { } //Length: 173
	}

	private static Player Player
	{
		private get { } //Length: 60
	}

	public BreathController() { }

	private void AttachToCamera() { }

	[IteratorStateMachine(typeof(<BreathLoop>d__23))]
	private IEnumerator BreathLoop() { }

	private bool CanShowBreath() { }

	private Transform FindCamera() { }

	private WaitForSecondsRealtime get_BreathDelay() { }

	private static Player get_Player() { }

	[IteratorStateMachine(typeof(<InitializeBreath>d__14))]
	private IEnumerator InitializeBreath() { }

	private bool IsWinterSeason() { }

	private void OnDestroy() { }

	private void OnExhale() { }

	private void OnSeasonControllerInitialized(ISeasonsController controller) { }

	private void SpeakerPhraseToldHandler(EPhraseTrigger trigger, TaggedClip clip, TagBank bank, BaseSpeaker speaker) { }

	private void Start() { }

	private void StopBreath() { }

}

