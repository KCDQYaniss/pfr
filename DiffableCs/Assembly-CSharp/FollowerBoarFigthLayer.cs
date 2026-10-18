//Type is in global namespace

public class FollowerBoarFigthLayer : BoarFightAbstractLayer
{
	private BossBoar _bossBoar; //Field offset: 0xC0

	public FollowerBoarFigthLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnBossFinded(IBossToFollow obj) { }

	public virtual bool ShallUseNow() { }

}

