//Type is in global namespace

public class BetterSourcePool`1 : IBetterSourcePool
{
	private readonly AudioGroupPoolSettings _poolSettings; //Field offset: 0x0
	private readonly AudioGroupPreset _preset; //Field offset: 0x0
	private readonly IPooledBetterSourceFactory _sourceFactory; //Field offset: 0x0
	private readonly bool _createSpatialization; //Field offset: 0x0
	private readonly Stack _cold; //Field offset: 0x0
	private readonly Stack _hot; //Field offset: 0x0
	private readonly ExpiringRingBuffer _warmBuffer; //Field offset: 0x0
	private readonly Queue _pendingDeactivate; //Field offset: 0x0
	private int _inUseCount; //Field offset: 0x0
	private readonly HashSet _activeSources; //Field offset: 0x0

	public BetterSourcePool`1(AudioGroupPreset preset, IPooledBetterSourceFactory sourceFactory, bool createSpatialization = false) { }

	public override BetterSource Borrow(bool activate, bool needUpdate, bool useHotPool = true) { }

	private void CleanupAndMoveToCold(TSource source) { }

	public override void ClearAllPendingAndWarm() { }

	public override int DeactivatePending(int budget) { }

	public override int ExpireWarmEntries(int budget, double now) { }

	public override int GetInUseCount() { }

	public override void Prewarm() { }

	private void PushCold(TSource source) { }

	private void PushHot(TSource source) { }

	private void PutToColdPool(TSource source) { }

	private void PutToWarmBuffer(TSource source) { }

	public override void Release(TSource source) { }

	private void ResetTransform(TSource source) { }

	public override void StopAndReleaseAllActive() { }

	public override int TickBudget(int perGroupBudget, double now) { }

	private bool TryPutToHotPool(TSource source) { }

}

