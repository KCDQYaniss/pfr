//Type is in global namespace

public interface IBetterSourcePool`1
{

	public BetterSource Borrow(bool activate, bool needUpdate, bool useHotPool = true) { }

	public void ClearAllPendingAndWarm() { }

	public int DeactivatePending(int budget) { }

	public int ExpireWarmEntries(int budget, double now) { }

	public int GetInUseCount() { }

	public void Prewarm() { }

	public void Release(TSource source) { }

	public void StopAndReleaseAllActive() { }

	public int TickBudget(int perGroupBudget, double now) { }

}

