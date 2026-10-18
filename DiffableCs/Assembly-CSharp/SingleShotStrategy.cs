//Type is in global namespace

public sealed class SingleShotStrategy : IFirePlaybackStrategy
{
	[CompilerGenerated]
	private sealed class <PlaySequenceRoutine>d__2 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WeaponProfile profile; //Field offset: 0x20
		public double startOffsetSec; //Field offset: 0x28
		public int shotsCount; //Field offset: 0x30
		public SoundBank bank; //Field offset: 0x38
		public float dist; //Field offset: 0x40
		public Vector3 position; //Field offset: 0x44
		public AudioSourcePriorityCalculator priorityCalc; //Field offset: 0x50
		public float volume; //Field offset: 0x58
		public ISequenceEndSync sequenceEndSync; //Field offset: 0x60
		private int <remaining>5__2; //Field offset: 0x68

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
		public <PlaySequenceRoutine>d__2(int <>1__state) { }

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


	public SingleShotStrategy() { }

	public bool CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override bool IFirePlaybackStrategy.CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override void IFirePlaybackStrategy.PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	public void PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	[IteratorStateMachine(typeof(<PlaySequenceRoutine>d__2))]
	private IEnumerator PlaySequenceRoutine(Vector3 position, WeaponProfile profile, SoundBank bank, AudioSourcePriorityCalculator priorityCalc, ISequenceEndSync sequenceEndSync, int shotsCount, float dist, float volume, double startOffsetSec) { }

}

