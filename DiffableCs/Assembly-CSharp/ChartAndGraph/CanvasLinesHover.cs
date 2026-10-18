namespace ChartAndGraph;

public class CanvasLinesHover : MaskableGraphic
{
	[CompilerGenerated]
	private sealed class <getVerices>d__3 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private UIVertex <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x80
		public CanvasLinesHover <>4__this; //Field offset: 0x88
		private UIVertex <v>5__2; //Field offset: 0x90

		private override UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 67
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 149
		}

		[DebuggerHidden]
		public <getVerices>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.UIVertex>.GetEnumerator() { }

		[DebuggerHidden]
		private override UIVertex System.Collections.Generic.IEnumerator<UnityEngine.UIVertex>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private float mHalfThickness; //Field offset: 0xE0
	private UIVertex[] mTmpVerts; //Field offset: 0xE8

	public CanvasLinesHover() { }

	[IteratorStateMachine(typeof(<getVerices>d__3))]
	private IEnumerable getVerices() { }

	public void Init(float thickness) { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	protected virtual void OnPopulateMesh(Mesh m) { }

}

