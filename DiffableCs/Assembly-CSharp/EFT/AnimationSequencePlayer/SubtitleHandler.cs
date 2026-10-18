namespace EFT.AnimationSequencePlayer;

public class SubtitleHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DisplayRoutine>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SubtitleHandler <>4__this; //Field offset: 0x20
		public string text; //Field offset: 0x28

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
		public <DisplayRoutine>d__6(int <>1__state) { }

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
	private RectTransform _layoutRoot; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _subtitle; //Field offset: 0x28
	private Coroutine _displayRoutine; //Field offset: 0x30

	public SubtitleHandler() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<DisplayRoutine>d__6))]
	private IEnumerator DisplayRoutine(string text) { }

	private void OnDestroy() { }

	private void SequencePlayerOnOnSubtitleChanged(string text) { }

}

