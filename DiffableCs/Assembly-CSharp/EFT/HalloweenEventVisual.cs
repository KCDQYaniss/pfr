namespace EFT;

public sealed class HalloweenEventVisual : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector3 <DebugSpawnAllPlaces>b__21_0(AIPlaceInfoHalloweenCircle place) { }

	}

	[CompilerGenerated]
	private sealed class <WaiterEvent>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HalloweenEventVisual <>4__this; //Field offset: 0x20
		public int secToChange; //Field offset: 0x28
		public float time; //Field offset: 0x2C
		public Action callback; //Field offset: 0x30

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
		public <WaiterEvent>d__19(int <>1__state) { }

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
	private sealed class <WaiterEvent>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action callbackBefore; //Field offset: 0x20
		public HalloweenEventVisual <>4__this; //Field offset: 0x28
		public int secToChange; //Field offset: 0x30
		public float time; //Field offset: 0x34
		public Action callbackAfter; //Field offset: 0x38

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
		public <WaiterEvent>d__20(int <>1__state) { }

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

	private const int FORCE_CHANGE_TIME = 1; //Field offset: 0x0
	private bool _isInitialized; //Field offset: 0x20
	private IEnumerator _waiterEvent; //Field offset: 0x28
	[SerializeField]
	private HalloweenVisualContainer _container; //Field offset: 0x30
	[SerializeField]
	private HalloweenVisualContainer[] _visuals; //Field offset: 0x38

	public HalloweenEventVisual() { }

	private void Abort() { }

	private void Activate() { }

	private void Deactivate() { }

	public void DebugSpawnAllPlaces() { }

	public void ForceDestroy() { }

	public void Initialize(Vector3[] positions) { }

	private void OnDestroy() { }

	private void OnEventAction(float timeFromStartEvent, int secToChange, Action callbackBefore, Action callbackAfter) { }

	private void OnEventAction(float timeFromStartEvent, int secToChange, Action callback) { }

	private void Register() { }

	public void Start() { }

	public void StartEventVisual(int secToChange, bool force = false) { }

	public void StopEventVisual(int secToChange, bool force = false) { }

	public void SwitchLight(bool value) { }

	public void SwitchSign(bool value) { }

	private float TimeFromEndEvent(int secToChange, float value) { }

	[IteratorStateMachine(typeof(<WaiterEvent>d__19))]
	private IEnumerator WaiterEvent(float time, int secToChange, Action callback) { }

	[IteratorStateMachine(typeof(<WaiterEvent>d__20))]
	private IEnumerator WaiterEvent(float time, int secToChange, Action callbackBefore, Action callbackAfter) { }

}

