namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionOpenDoors : CutsceneBaseAction
{
	[CompilerGenerated]
	private sealed class <NotifyPlayers>d__4 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CutsceneActionOpenDoors <>4__this; //Field offset: 0x20

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
		public <NotifyPlayers>d__4(int <>1__state) { }

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

	private const string WAIT_ROOM_OPEN_MESSAGE_KEY = "WaitRoomOpenMessage"; //Field offset: 0x0
	public List doorsId; //Field offset: 0x40
	public float waitNotifyTime; //Field offset: 0x48

	public CutsceneActionOpenDoors() { }

	public virtual void Init() { }

	[IteratorStateMachine(typeof(<NotifyPlayers>d__4))]
	private IEnumerator NotifyPlayers() { }

}

