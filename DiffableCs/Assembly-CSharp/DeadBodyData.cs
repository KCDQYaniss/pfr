//Type is in global namespace

public class DeadBodyData : BotData
{
	[CompilerGenerated]
	private sealed class <Wait>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DeadBodyData <>4__this; //Field offset: 0x20

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
		public <Wait>d__11(int <>1__state) { }

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

	public DeadBody TargetDeadBody; //Field offset: 0x18
	public bool IsNear; //Field offset: 0x20
	public bool WillDoControlShoot; //Field offset: 0x21
	private Vector3 cachePos; //Field offset: 0x24

	public DeadBodyData(BotOwner owner) { }

	public void Come() { }

	public void EndInspection() { }

	public Vector3 GetPointToShoot() { }

	public bool HaveBodyToCheck() { }

	private void OnTriggerPressed() { }

	public void SetBody(DeadBody body) { }

	[IteratorStateMachine(typeof(<Wait>d__11))]
	private IEnumerator Wait() { }

}

