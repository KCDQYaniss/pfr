namespace Audio.Weapons;

public class SimpleAudioScheduler : BaseAudioScheduler
{

	public SimpleAudioScheduler(AudioScheduleOptions options = null) { }

	public virtual double GetScheduledTime(double timeToHear, double previousIdeal, double beatDuration) { }

}

