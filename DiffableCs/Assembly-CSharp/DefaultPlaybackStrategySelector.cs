//Type is in global namespace

public sealed class DefaultPlaybackStrategySelector : IPlaybackStrategySelector
{
	private readonly IFirePlaybackStrategy _single; //Field offset: 0x10
	private readonly IFirePlaybackStrategy _loopTail; //Field offset: 0x18
	private readonly IFirePlaybackStrategy _noop; //Field offset: 0x20

	public DefaultPlaybackStrategySelector() { }

	private override IFirePlaybackStrategy IPlaybackStrategySelector.Resolve(in ShooterPlaybackContext playbackContext, int shotsCount) { }

	public IFirePlaybackStrategy Resolve(in ShooterPlaybackContext playbackContext, int shotsCount) { }

}

