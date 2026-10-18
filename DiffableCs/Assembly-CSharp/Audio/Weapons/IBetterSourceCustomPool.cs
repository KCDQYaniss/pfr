namespace Audio.Weapons;

public interface IBetterSourceCustomPool : IDisposable
{

	public int PoolSize
	{
		 get { } //Length: 0
	}

	public BetterSource Borrow() { }

	public int get_PoolSize() { }

	public void ProcessOcclusion(BetterSource source) { }

	public void RegisterOcclusionPlayer(IObserverToPlayerBridge playerBridge) { }

	public void Release(bool softStop = true) { }

	public void Resize(int newSize) { }

	public void TrackPosition(Transform parent) { }

}

