namespace Audio.Weapons;

public interface IServerTimeProvider
{

	public double GetCurrentServerTime() { }

	public void Reset() { }

}

