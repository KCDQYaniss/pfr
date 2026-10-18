namespace Audio.Weapons;

public class BeatQuantizedAudioScheduler : BaseAudioScheduler
{
	private const double MAX_BEATS_ADVANCE = 1000; //Field offset: 0x0

	public BeatQuantizedAudioScheduler(AudioScheduleOptions options = null) { }

	private static double CalculateResetScheduledTime(double adjustedAligned, double alignedDspNow, double beatDuration) { }

	private static double ClampToNextBeat(double value, double minValue, double beatDuration) { }

	public virtual double GetScheduledTime(double timeToHear, double previousIdeal, double beatDuration) { }

}

