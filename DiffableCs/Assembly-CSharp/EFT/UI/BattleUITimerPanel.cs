namespace EFT.UI;

public abstract class BattleUITimerPanel : BattleUIPanel
{
	[CompilerGenerated]
	private sealed class <Co_Countdown>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BattleUITimerPanel <>4__this; //Field offset: 0x20
		public float time; //Field offset: 0x28
		public string localizationKey; //Field offset: 0x30
		private TMP_Text <timerLabel>5__2; //Field offset: 0x38
		private bool <layoutReady>5__3; //Field offset: 0x40

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
		public <Co_Countdown>d__9(int <>1__state) { }

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

	private Coroutine _showInfoPanelCoroutine; //Field offset: 0x78
	private Coroutine _countdownCoroutine; //Field offset: 0x80

	protected abstract LayoutElement LayoutElement
	{
		 get { } //Length: 0
	}

	protected abstract TMP_Text TimerLabel
	{
		 get { } //Length: 0
	}

	protected BattleUITimerPanel() { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<Co_Countdown>d__9))]
	private IEnumerator Co_Countdown(string localizationKey, float time) { }

	protected abstract LayoutElement get_LayoutElement() { }

	protected abstract TMP_Text get_TimerLabel() { }

	protected void ShowCountdownPanel(string localizationKey, float duration, float fadeDelay, float fadeSpeed) { }

	protected void ShowPanel(float fadeDelay, float fadeSpeed) { }

	private void StopActiveCoroutines() { }

	private void UpdateLayout(string localizationKey, float time, TMP_Text timerLabel) { }

}

