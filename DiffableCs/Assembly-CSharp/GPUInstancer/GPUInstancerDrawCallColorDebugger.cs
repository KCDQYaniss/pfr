namespace GPUInstancer;

public class GPUInstancerDrawCallColorDebugger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ColorLODs>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GPUInstancerDrawCallColorDebugger <>4__this; //Field offset: 0x20

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
		public <ColorLODs>d__8(int <>1__state) { }

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
	public List drawCallColors; //Field offset: 0x28
	public bool removeMainTextureWhenColored; //Field offset: 0x30
	private Dictionary _previousColors; //Field offset: 0x38
	private Dictionary _previousTextures; //Field offset: 0x40

	public GPUInstancerDrawCallColorDebugger() { }

	public void ChangeDrawCallColors() { }

	[IteratorStateMachine(typeof(<ColorLODs>d__8))]
	private IEnumerator ColorLODs() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Reset() { }

	private void ResetColors() { }

}

