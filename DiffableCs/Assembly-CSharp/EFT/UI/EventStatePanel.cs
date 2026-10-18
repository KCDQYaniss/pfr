namespace EFT.UI;

public sealed class EventStatePanel : BattleUIPanel
{
	[CompilerGenerated]
	private sealed class <Co_Action>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public EventStatePanel <>4__this; //Field offset: 0x28
		private float <step>5__2; //Field offset: 0x30
		private float <time>5__3; //Field offset: 0x34

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
		public <Co_Action>d__16(int <>1__state) { }

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
	private sealed class <Co_Countdown>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public EventStatePanel <>4__this; //Field offset: 0x28

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
		public <Co_Countdown>d__15(int <>1__state) { }

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
	private CustomTextMeshProUGUI _label; //Field offset: 0x78
	[SerializeField]
	private Color _inactiveColor; //Field offset: 0x80
	[SerializeField]
	private Color _activeColor; //Field offset: 0x90
	[SerializeField]
	private Image _baseImage; //Field offset: 0xA0
	[SerializeField]
	private Image _actionImage; //Field offset: 0xA8
	[SerializeField]
	private Image _glowImage; //Field offset: 0xB0
	private Coroutine _showInfoPanelCoroutine; //Field offset: 0xB8
	private Coroutine _countdownCoroutine; //Field offset: 0xC0
	private Coroutine _actionCoroutine; //Field offset: 0xC8
	public DateTime dateTime; //Field offset: 0xD0
	private string _text; //Field offset: 0xD8

	public EventStatePanel() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	private void CheckCurrentScreen(EEftScreenType screenType) { }

	[IteratorStateMachine(typeof(<Co_Action>d__16))]
	private IEnumerator Co_Action(float duration) { }

	[IteratorStateMachine(typeof(<Co_Countdown>d__15))]
	private IEnumerator Co_Countdown(float time) { }

	public void Show(string text, bool paused) { }

	public void StartAction(string text, float duration) { }

	public void StopAction() { }

}

