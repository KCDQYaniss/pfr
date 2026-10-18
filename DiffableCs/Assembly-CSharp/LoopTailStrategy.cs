//Type is in global namespace

public sealed class LoopTailStrategy : IFirePlaybackStrategy
{

	public LoopTailStrategy() { }

	public bool CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override bool IFirePlaybackStrategy.CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override void IFirePlaybackStrategy.PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private float PickClips(SoundBank bank, float distance, out AudioClip clip1, out AudioClip clip2, out float balance) { }

	private void PlayScheduled(BetterSource source, AudioClip clip1, AudioClip clip2, float balance, double scheduleTime, float clipLen) { }

	public void PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private void SetParameters(BetterSource source, SoundBank bank, Vector3 pos, bool loop, float distance, AudioSourcePriorityCalculator priorityCalculator) { }

}

