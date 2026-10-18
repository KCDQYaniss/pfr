//Type is in global namespace

public sealed class BetterSourceUpdateSystem : IBetterSourceUpdater
{
	private readonly List _updatableSourcesList; //Field offset: 0x10
	private readonly Dictionary _updatableSourcesMap; //Field offset: 0x18
	private readonly List _fadingSourcesList; //Field offset: 0x20
	private readonly Dictionary _fadingSourcesMap; //Field offset: 0x28
	private readonly HashSet _updatablesPendingRemove; //Field offset: 0x30
	private readonly HashSet _fadersPendingRemove; //Field offset: 0x38

	public BetterSourceUpdateSystem() { }

	public override void Clear() { }

	private void ProcessPendingRemovals(HashSet pendingIds, List sourceList, Dictionary sourceMap) { }

	public override void RegisterFader(BetterSource source) { }

	public override void RegisterUpdatable(BetterSource source) { }

	public override void Tick() { }

	public override void UnregisterFader(BetterSource source) { }

	public override void UnregisterUpdatable(BetterSource source) { }

}

