namespace Audio;

[Obfuscation(Exclude = True)]
public class MetaXRPluginErrorChecker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CheckVolumeCoroutine>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MetaXRPluginErrorChecker <>4__this; //Field offset: 0x20

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
		public <CheckVolumeCoroutine>d__15(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <ProcessFallback>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MetaXRPluginErrorChecker <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

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
		public <ProcessFallback>d__16(int <>1__state) { }

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

	public float checkCooldown; //Field offset: 0x20
	public int maxResetAttempts; //Field offset: 0x24
	public bool hardResetEnabled; //Field offset: 0x28
	public float resetWaitTime; //Field offset: 0x2C
	private int _currentResetAttempts; //Field offset: 0x30
	private float _nextResetAttemptTime; //Field offset: 0x34
	private bool _isReverbDisabledFallback; //Field offset: 0x38
	private bool _isEnabled; //Field offset: 0x39
	private Coroutine _checkCoroutine; //Field offset: 0x40
	private float _nextCheckTime; //Field offset: 0x48
	private double _currentOutputVolume; //Field offset: 0x50
	private double _currentTimeDelta; //Field offset: 0x58
	private readonly float[] _samples; //Field offset: 0x60

	public MetaXRPluginErrorChecker() { }

	[IteratorStateMachine(typeof(<CheckVolumeCoroutine>d__15))]
	private IEnumerator CheckVolumeCoroutine() { }

	private bool IsOutputInvalid() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<ProcessFallback>d__16))]
	private IEnumerator ProcessFallback(Action callback = null) { }

	public void ResetFallback() { }

	public void SetActive(bool checkEnabled) { }

	private void UpdateAudioData() { }

	private void UpdateTimeDelta() { }

}

