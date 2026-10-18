//Type is in global namespace

public class ByeFinalStage : FinalStatisticScreenStage
{
	[CompilerGenerated]
	private sealed class <TypeText>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string captionKey; //Field offset: 0x20
		public ByeFinalStage <>4__this; //Field offset: 0x28

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
		public <TypeText>d__4(int <>1__state) { }

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
	private TMP_Text _captionLabel; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _previousButton; //Field offset: 0xD0

	public ByeFinalStage() { }

	[CompilerGenerated]
	private void <TypeText>b__4_0(string val) { }

	public virtual Task ShowState() { }

	[IteratorStateMachine(typeof(<TypeText>d__4))]
	private IEnumerator TypeText(string captionKey) { }

}

