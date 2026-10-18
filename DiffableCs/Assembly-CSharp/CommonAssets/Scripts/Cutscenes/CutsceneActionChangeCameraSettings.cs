namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionChangeCameraSettings : CutsceneBaseAction
{
	[CompilerGenerated]
	private sealed class <InitCameraSettings>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CutsceneActionChangeCameraSettings <>4__this; //Field offset: 0x20

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
		public <InitCameraSettings>d__5(int <>1__state) { }

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

	public int fov; //Field offset: 0x40
	public bool useGameSettings; //Field offset: 0x44
	public bool forceOverrideParams; //Field offset: 0x45

	public CutsceneActionChangeCameraSettings() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

	[IteratorStateMachine(typeof(<InitCameraSettings>d__5))]
	private IEnumerator InitCameraSettings() { }

	private void OnChangeFovCoroutineStarted(Coroutine coroutine) { }

	private void SetCameraSettings() { }

}

