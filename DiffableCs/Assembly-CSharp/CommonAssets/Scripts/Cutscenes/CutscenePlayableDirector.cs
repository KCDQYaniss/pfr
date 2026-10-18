namespace CommonAssets.Scripts.Cutscenes;

public class CutscenePlayableDirector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RegisterCoroutine>d__2 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CutscenePlayableDirector <>4__this; //Field offset: 0x20
		private GameWorld <gameWorld>5__2; //Field offset: 0x28

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
		public <RegisterCoroutine>d__2(int <>1__state) { }

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

	public Action SignalActionReceived; //Field offset: 0x20

	public CutscenePlayableDirector() { }

	public void OnSignalEmit(string eventName) { }

	[IteratorStateMachine(typeof(<RegisterCoroutine>d__2))]
	private IEnumerator RegisterCoroutine() { }

	private void Start() { }

}

