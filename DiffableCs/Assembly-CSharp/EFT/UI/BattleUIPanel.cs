namespace EFT.UI;

public class BattleUIPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <Co_ShowInfoPanel>d__1 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BattleUIPanel <>4__this; //Field offset: 0x20
		public float delay; //Field offset: 0x28
		public float speed; //Field offset: 0x2C

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
		public <Co_ShowInfoPanel>d__1(int <>1__state) { }

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
	public CanvasGroup _infoPanel; //Field offset: 0x70

	public BattleUIPanel() { }

	[IteratorStateMachine(typeof(<Co_ShowInfoPanel>d__1))]
	protected IEnumerator Co_ShowInfoPanel(float delay, float speed) { }

}

