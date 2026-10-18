//Type is in global namespace

public class FollowerGluharAssaultFightLayer : GluharFightAbstractLayer
{
	private CustomNavigationPoint _coverAtHome; //Field offset: 0xF0
	private float _nextCheckCover; //Field offset: 0xF8

	private bool EndPeaceCauseAtHome
	{
		private get { } //Length: 529
	}

	public FollowerGluharAssaultFightLayer(BotOwner owner, int priority) { }

	private void CheckPositionAtZone() { }

	private void CheckWantAttack() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSearch() { }

	private AICoreActionResult FightAtFree() { }

	private AICoreActionResult FightAtZone() { }

	private bool get_EndPeaceCauseAtHome() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsEnemyAtMyPlace() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnTriggerPressed() { }

	public bool ShallGoNearBoss() { }

	public virtual bool ShallUseNow() { }

}

