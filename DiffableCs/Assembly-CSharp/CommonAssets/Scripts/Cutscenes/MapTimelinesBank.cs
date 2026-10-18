namespace CommonAssets.Scripts.Cutscenes;

public class MapTimelinesBank : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SearchObjectsCoroutine>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MapTimelinesBank <>4__this; //Field offset: 0x20

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
		public <SearchObjectsCoroutine>d__4(int <>1__state) { }

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

	public List timelines; //Field offset: 0x20
	public string timelineDirectorName; //Field offset: 0x28

	public MapTimelinesBank() { }

	[IteratorStateMachine(typeof(<SearchObjectsCoroutine>d__4))]
	private IEnumerator SearchObjectsCoroutine() { }

	public void SearchTimelineObjects() { }

	private void Start() { }

}

