namespace EFT.Interactive;

public class DoorSwitch : Door
{
	[CompilerGenerated]
	private sealed class <SmoothDoorOpenCoroutine>d__1 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DoorSwitch <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public bool isLocalInteraction; //Field offset: 0x29
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
		public <SmoothDoorOpenCoroutine>d__1(int <>1__state) { }

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

	public Switch SwitchToTrigger; //Field offset: 0x238

	public bool HasAuthority
	{
		 get { } //Length: 62
	}

	public DoorSwitch() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(EDoorState state, bool isLocalInteraction, float speed) { }

	public bool get_HasAuthority() { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__1))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

}

