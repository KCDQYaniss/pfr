//Type is in global namespace

public sealed class AudioStopQueue : IStopQueue
{
	private struct StopRequest
	{
		public PooledBetterSourceHandle poolHandle; //Field offset: 0x0
		public uint generation; //Field offset: 0x8

	}

	private readonly Queue _queue; //Field offset: 0x10

	public AudioStopQueue() { }

	public override void Clear() { }

	public override void Enqueue(PooledBetterSourceHandle poolHandle, uint generation) { }

	public override int Process(int maxStops) { }

}

