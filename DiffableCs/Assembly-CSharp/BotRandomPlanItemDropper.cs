//Type is in global namespace

public class BotRandomPlanItemDropper : BotData
{
	private const float NO_DROP_SEC_FROM_START = 60; //Field offset: 0x0
	private const float CHANCE_TO_DROP = 160; //Field offset: 0x0
	private float _activateTime; //Field offset: 0x18
	private float _nextTimePossible; //Field offset: 0x1C
	protected readonly List _cacheItemsList; //Field offset: 0x20

	protected BotRandomPlanItemDropper(BotOwner owner) { }

	public void Activate() { }

	public static BotRandomPlanItemDropper Create(BotOwner owner) { }

	public void Dispose() { }

	protected override Item FindItemToDropToBot() { }

	private void OnStartPeacefulMove(BotsPairData obj) { }

}

