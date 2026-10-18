//Type is in global namespace

public class Basics : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Start>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Basics <>4__this; //Field offset: 0x20

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
		public <Start>d__4(int <>1__state) { }

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

	public Transform redCube; //Field offset: 0x20
	public Transform greenCube; //Field offset: 0x28
	public Transform blueCube; //Field offset: 0x30
	public Transform purpleCube; //Field offset: 0x38

	public Basics() { }

	[IteratorStateMachine(typeof(<Start>d__4))]
	private IEnumerator Start() { }

}

