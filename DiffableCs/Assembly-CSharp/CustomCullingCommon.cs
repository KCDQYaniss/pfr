//Type is in global namespace

public static class CustomCullingCommon
{
	[CompilerGenerated]
	private sealed class <SetComponentsEnabledWorker>d__1 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isEnabled; //Field offset: 0x20
		public int componentsSwitchPerFrameOnEnable; //Field offset: 0x24
		public int objectsSwitchPerFrameOnEnable; //Field offset: 0x28
		public int componentsSwitchPerFrameOnDisable; //Field offset: 0x2C
		public int objectsSwitchPerFrameOnDisable; //Field offset: 0x30
		public List componentsToTurnOff; //Field offset: 0x38
		public List gameObjectsToTurnOff; //Field offset: 0x40
		private int <componentsSwitchPerFrame>5__2; //Field offset: 0x48
		private int <objectsSwitchPerFrame>5__3; //Field offset: 0x4C
		private int <count>5__4; //Field offset: 0x50
		private int <index>5__5; //Field offset: 0x54

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
		public <SetComponentsEnabledWorker>d__1(int <>1__state) { }

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


	public static void SetComponentsEnabled(GameObject gameObject, MonoBehaviour component, ref IEnumerator setComponentsEnabledWorker, List componentsToTurnOff, List gameObjectsToTurnOff, int componentsSwitchPerFrameOnEnable, int objectsSwitchPerFrameOnEnable, int componentsSwitchPerFrameOnDisable, int objectsSwitchPerFrameOnDisable, bool isEnabled, Stopwatch stopwatch) { }

	[IteratorStateMachine(typeof(<SetComponentsEnabledWorker>d__1))]
	public static IEnumerator SetComponentsEnabledWorker(GameObject gameObject, List componentsToTurnOff, List gameObjectsToTurnOff, int componentsSwitchPerFrameOnEnable, int objectsSwitchPerFrameOnEnable, int componentsSwitchPerFrameOnDisable, int objectsSwitchPerFrameOnDisable, bool isEnabled, Stopwatch stopwatch) { }

}

