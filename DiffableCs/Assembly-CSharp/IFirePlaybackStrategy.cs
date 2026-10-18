//Type is in global namespace

public interface IFirePlaybackStrategy
{

	public bool CanPlay(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	public void PlaySequence(in ShooterPlaybackContext playbackContext, int shotsCount) { }

}

