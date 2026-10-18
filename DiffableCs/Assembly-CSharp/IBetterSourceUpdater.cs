//Type is in global namespace

public interface IBetterSourceUpdater
{

	public void Clear() { }

	public void RegisterFader(BetterSource source) { }

	public void RegisterUpdatable(BetterSource source) { }

	public void Tick() { }

	public void UnregisterFader(BetterSource source) { }

	public void UnregisterUpdatable(BetterSource source) { }

}

