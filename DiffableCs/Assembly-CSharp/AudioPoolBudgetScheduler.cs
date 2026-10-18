//Type is in global namespace

public sealed class AudioPoolBudgetScheduler
{
	private int _roundRobinIndex; //Field offset: 0x10
	private readonly IStopQueue _stopQueue; //Field offset: 0x18

	public AudioPoolBudgetScheduler() { }

	public void Clear() { }

	public void EnqueueStop(PooledBetterSourceHandle poolHandle, uint generation) { }

	public void TickBudget(ISourceGroup[] groups, int maxStops, int maxDeactivate, int perGroupCap, double now) { }

}

