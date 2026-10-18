namespace EFT.NPC;

public class AnimationIntRandomizerByTimer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RandomizeCooldown>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AnimationIntRandomizerByTimer <>4__this; //Field offset: 0x20
		private float <duration>5__2; //Field offset: 0x28
		private float <resetOnDefaultTimer>5__3; //Field offset: 0x2C
		private float <normalizedTime>5__4; //Field offset: 0x30

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
		public <RandomizeCooldown>d__17(int <>1__state) { }

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
	private Animator _targetAnimator; //Field offset: 0x20
	[SerializeField]
	private Vector2 _randomizeMinMaxSeconds; //Field offset: 0x28
	[SerializeField]
	private string _paramForRandomize; //Field offset: 0x30
	[SerializeField]
	private int _defaultValue; //Field offset: 0x38
	[SerializeField]
	private Vector2 _randomValueFromTo; //Field offset: 0x3C
	[Header("If false - fills list and randomize from it repeatedly")]
	[SerializeField]
	private bool fullRandom; //Field offset: 0x44
	[SerializeField]
	private BaseEventFilter _startWorkFilter; //Field offset: 0x48
	[SerializeField]
	private BaseEventFilter _stopWorkFilter; //Field offset: 0x50
	private Coroutine _randomizeCooldownCoroutine; //Field offset: 0x58
	private List _valuesForRandomize; //Field offset: 0x60

	public AnimationIntRandomizerByTimer() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnEndFilterPassed(BaseEventFilter ef, BaseEvent ev) { }

	private void OnStartFilterPassed(BaseEventFilter ef, BaseEvent ev) { }

	private void Randomize() { }

	[IteratorStateMachine(typeof(<RandomizeCooldown>d__17))]
	private IEnumerator RandomizeCooldown() { }

	private void RefillValuesForRandomize() { }

	private void ToggleRandomizationCycles(bool toggle) { }

}

