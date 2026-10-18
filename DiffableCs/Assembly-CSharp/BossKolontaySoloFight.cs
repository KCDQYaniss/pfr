//Type is in global namespace

public class BossKolontaySoloFight : BossKolontayBaseFightLayer
{
	private const float REACT_TO_SHOT_TIME = 1; //Field offset: 0x0
	private float _endRushTime; //Field offset: 0xC0
	private bool _rushPeriod; //Field offset: 0xC4
	private float _lastShotFromLongDistTime; //Field offset: 0xC8

	public BossKolontaySoloFight(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private void OnGoalChange(BotOwner obj) { }

	public virtual bool ShallUseNow() { }

	private bool ShouldRush() { }

	public void UpdateLastFarShotTime() { }

}

