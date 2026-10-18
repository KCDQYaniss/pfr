namespace GPUInstancer;

public class GPUInstancerLODColorDebugger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ColorLODs>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GPUInstancerLODColorDebugger <>4__this; //Field offset: 0x20

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
		public <ColorLODs>d__6(int <>1__state) { }

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

	public GPUInstancerManager gPUIManager; //Field offset: 0x20
	public List lODColors; //Field offset: 0x28
	private Dictionary _previousColors; //Field offset: 0x30

	public GPUInstancerLODColorDebugger() { }

	public void ChangeLODColors() { }

	[IteratorStateMachine(typeof(<ColorLODs>d__6))]
	private IEnumerator ColorLODs() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Reset() { }

	private void ResetColors() { }

}

