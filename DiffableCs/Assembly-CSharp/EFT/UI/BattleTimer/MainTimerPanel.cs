namespace EFT.UI.BattleTimer;

public sealed class MainTimerPanel : TimerPanel
{
	[CompilerGenerated]
	private sealed class <Co_HideTimer>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MainTimerPanel <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

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
		public <Co_HideTimer>d__15(int <>1__state) { }

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

	private const int FORCE_SHOW_TIMER_THRESHOLD = 600; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _currentState; //Field offset: 0xB0
	[SerializeField]
	private Color _warningColor; //Field offset: 0xB8
	private EMainTimerState _state; //Field offset: 0xC8
	public bool ForcePull; //Field offset: 0xCC

	protected virtual bool DisplayTime
	{
		 get { } //Length: 308
	}

	public MainTimerPanel() { }

	[IteratorStateMachine(typeof(<Co_HideTimer>d__15))]
	public IEnumerator Co_HideTimer(Action callback) { }

	public void DisplayTimer() { }

	protected virtual bool get_DisplayTime() { }

	public void HideRaidTime() { }

	public void HideTimer() { }

	protected virtual void OnLocaleUpdated() { }

	public void SetState(EMainTimerState state) { }

	public void Show(DateTime dateTime, StringBuilder stringBuilder, EMainTimerState state) { }

	protected virtual void UpdateTimer() { }

}

