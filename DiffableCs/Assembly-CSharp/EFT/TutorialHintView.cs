namespace EFT;

public sealed class TutorialHintView : UIElement
{
	[CompilerGenerated]
	private sealed class <<ValidateLayout>g__CrtValidateLayout|46_0>d : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TutorialHintView <>4__this; //Field offset: 0x20

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
		public <<ValidateLayout>g__CrtValidateLayout|46_0>d(int <>1__state) { }

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
	private sealed class <>c__DisplayClass29_0
	{
		public TutorialHintView <>4__this; //Field offset: 0x10
		public TutorialHintData data; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <TryDequeueHint>b__0(TutorialHintData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Action swapAction; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal void <DoSwap>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <CrtDelayedCloseTutorialHint>d__33 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public TutorialHintView <>4__this; //Field offset: 0x28

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
		public <CrtDelayedCloseTutorialHint>d__33(int <>1__state) { }

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
	private sealed class <CrtShowNextHintQueued>d__38 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TutorialHintView <>4__this; //Field offset: 0x20

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
		public <CrtShowNextHintQueued>d__38(int <>1__state) { }

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

	private const float TWEEN_TIME = 0.6; //Field offset: 0x0
	private const float QUEUE_TIME = 4; //Field offset: 0x0
	[SerializeField]
	private TutorialHintLineView _template; //Field offset: 0x70
	[SerializeField]
	private GameObject _timerRoot; //Field offset: 0x78
	[SerializeField]
	private Image _timerFill; //Field offset: 0x80
	private readonly List _instances; //Field offset: 0x88
	private Tween _activeTween; //Field offset: 0x90
	private Tween _timerTween; //Field offset: 0x98
	private bool _isHiding; //Field offset: 0xA0
	[CompilerGenerated]
	private TutorialHintData <ActiveData>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <IsHintActive>k__BackingField; //Field offset: 0xB0
	private Coroutine _closeTutorialHintCoroutine; //Field offset: 0xB8
	private List _hintsQueue; //Field offset: 0xC0
	private Coroutine _queueCoroutine; //Field offset: 0xC8
	private bool _isQueueTimerActive; //Field offset: 0xD0
	private Nullable _lastHintShowTime; //Field offset: 0xD8

	public private TutorialHintData ActiveData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string ActiveDataKey
	{
		 get { } //Length: 18
	}

	private bool ActiveHintIsTriggerHint
	{
		private get { } //Length: 25
	}

	public private bool IsHintActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private float Width
	{
		private get { } //Length: 114
	}

	public TutorialHintView() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<ValidateLayout>g__CrtValidateLayout|46_0>d))]
	private IEnumerator <ValidateLayout>g__CrtValidateLayout|46_0() { }

	private void AddToQueue(TutorialHintData data) { }

	private void ClearLabels() { }

	private void ClearQueue() { }

	public virtual void Close() { }

	private void CompleteActiveTween() { }

	[IteratorStateMachine(typeof(<CrtDelayedCloseTutorialHint>d__33))]
	private IEnumerator CrtDelayedCloseTutorialHint(float time) { }

	[IteratorStateMachine(typeof(<CrtShowNextHintQueued>d__38))]
	private IEnumerator CrtShowNextHintQueued() { }

	private void DelayedCloseTutorialHint(TutorialHintData data) { }

	private void DoHide() { }

	private void DoShow() { }

	private void DoSwap(Action swapAction) { }

	[CompilerGenerated]
	public TutorialHintData get_ActiveData() { }

	public string get_ActiveDataKey() { }

	private bool get_ActiveHintIsTriggerHint() { }

	[CompilerGenerated]
	public bool get_IsHintActive() { }

	private float get_Width() { }

	private TutorialHintLineView GetLabel() { }

	public void Hide() { }

	private void HideTimer() { }

	private bool IsMinTimeTillPrevHintPassed() { }

	[CompilerGenerated]
	private void set_ActiveData(TutorialHintData value) { }

	[CompilerGenerated]
	private void set_IsHintActive(bool value) { }

	private void SetValues(TutorialHintData data) { }

	private void Show(TutorialHintData data, bool ignoreQueue) { }

	public void Show(TutorialHintData data) { }

	private void ShowFirstHintFromQueue() { }

	private void ShowNextHintQueued() { }

	private void ShowTimer(float time) { }

	public void TryDequeueHint(string key) { }

	private bool TryQueueHint(TutorialHintData data) { }

	private void ValidateLayout() { }

}

