namespace Audio.Weapons;

public interface IAudioScheduleService
{

	public double BufferLatency
	{
		 get { } //Length: 0
	}

	public double get_BufferLatency() { }

	public double GetScheduledTime(double timeToHear, double previousIdeal, double beatDuration) { }

	public void RegisterServerTimeProvider(IServerTimeProvider provider) { }

	public void Reset() { }

	public bool TryGetAlignedDspNow(out double alignedDspNow) { }

	public void UnregisterServerTimeProvider() { }

}

