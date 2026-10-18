//Type is in global namespace

public class AmbientFirefightDirector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CO_Ticker>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AmbientFirefightDirector <>4__this; //Field offset: 0x20

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
		public <CO_Ticker>d__15(int <>1__state) { }

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
	private int _maxConcurrentSequencesTotal; //Field offset: 0x20
	[SerializeField]
	private FirefightArea[] _firefightAreas; //Field offset: 0x28
	[SerializeField]
	private bool _playOnEnable; //Field offset: 0x30
	[SerializeField]
	private float _updateIntervalSec; //Field offset: 0x34
	private bool _running; //Field offset: 0x38
	private AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x40
	private readonly List _firefightAreaControllers; //Field offset: 0x48
	private float[] _densities; //Field offset: 0x50
	private WaitForSecondsRealtime _tickWaitForSeconds; //Field offset: 0x58
	private Coroutine _tickerCoroutine; //Field offset: 0x60
	private int _roundRobinStartIndex; //Field offset: 0x68

	public AmbientFirefightDirector() { }

	[IteratorStateMachine(typeof(<CO_Ticker>d__15))]
	private IEnumerator CO_Ticker() { }

	private void DistributeConcurrencyByDensity() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void StartScenario() { }

	public void StopScenario() { }

	private void Tick(float dt) { }

}

