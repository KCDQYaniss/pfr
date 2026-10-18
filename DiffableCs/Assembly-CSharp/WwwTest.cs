//Type is in global namespace

public class WwwTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <YoloTest>d__3 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WwwTest <>4__this; //Field offset: 0x20
		private int <counter>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x2C

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
		public <YoloTest>d__3(int <>1__state) { }

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
	private int[] yolos; //Field offset: 0x20
	[SerializeField]
	private int perframe; //Field offset: 0x28

	public WwwTest() { }

	private void Update() { }

	[IteratorStateMachine(typeof(<YoloTest>d__3))]
	private IEnumerator YoloTest() { }

}

