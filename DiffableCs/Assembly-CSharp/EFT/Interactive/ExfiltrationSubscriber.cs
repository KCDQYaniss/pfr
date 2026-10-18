namespace EFT.Interactive;

public class ExfiltrationSubscriber : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Wait>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ExfiltrationSubscriber <>4__this; //Field offset: 0x20

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
		public <Wait>d__4(int <>1__state) { }

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

	public ExfiltrationPoint Subscribee; //Field offset: 0x20
	public float Delay; //Field offset: 0x28

	public ExfiltrationSubscriber() { }

	public override void Dispose() { }

	protected override void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	public override void Play(bool force = false) { }

	public override void Start() { }

	[IteratorStateMachine(typeof(<Wait>d__4))]
	public IEnumerator Wait() { }

}

