//Type is in global namespace

public interface IStopQueue
{

	public void Clear() { }

	public void Enqueue(PooledBetterSourceHandle poolHandle, uint generation) { }

	public int Process(int maxStops) { }

}

