//Type is in global namespace

public sealed class GrenadeStrategy : IFirePlaybackStrategy
{

	public GrenadeStrategy() { }

	public bool CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override bool IFirePlaybackStrategy.CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	private override void IFirePlaybackStrategy.PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	public void PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

}

