//Type is in global namespace

public interface IPlaybackStrategySelector
{

	public IFirePlaybackStrategy Resolve(in ShooterPlaybackContext playbackContext, int shotsCount) { }

}

