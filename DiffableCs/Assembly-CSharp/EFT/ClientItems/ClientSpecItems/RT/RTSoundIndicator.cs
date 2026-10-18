namespace EFT.ClientItems.ClientSpecItems.RT;

public class RTSoundIndicator
{
	[CompilerGenerated]
	private sealed class <ProcessSoundSignal>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RTSoundIndicator <>4__this; //Field offset: 0x20

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
		public <ProcessSoundSignal>d__15(int <>1__state) { }

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

	private AudioClip _currentSoundSignal; //Field offset: 0x10
	private AudioClip _greenSoundSignal; //Field offset: 0x18
	private AudioClip _yellowSoundSignal; //Field offset: 0x20
	private AudioClip _redSoundSignal; //Field offset: 0x28
	private Transform _itemTransform; //Field offset: 0x30
	private RadioTransmitterView _radioTransmitterView; //Field offset: 0x38
	private BetterSource _betterSource; //Field offset: 0x40
	private readonly WaitForSecondsRealtime _waitGreenSignal; //Field offset: 0x48
	private readonly WaitForSecondsRealtime _waitYellowSignal; //Field offset: 0x50
	private readonly WaitForSecondsRealtime _waitRedSignal; //Field offset: 0x58

	public RTSoundIndicator(RadioTransmitterView radioTransmitterView, Transform itemTransform, AudioClip greenSoundSignal, AudioClip yellowSoundSignal, AudioClip redSoundSignal) { }

	public void OnDestroy() { }

	[IteratorStateMachine(typeof(<ProcessSoundSignal>d__15))]
	private IEnumerator ProcessSoundSignal() { }

	private void ReleaseSource() { }

	public void SetSoundSignal(RadioTransmitterStatus status) { }

	public void StopProcessingSoundSignal() { }

}

