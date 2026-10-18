//Type is in global namespace

public class FollowerKojaniyLayer : FightKojaniyAbstractLayer
{

	public FollowerKojaniyLayer(BotOwner owner, int priority) { }

	public virtual void Dispose() { }

	protected virtual Vector3 GetTargetToLook() { }

	protected virtual bool IsEverybodyRun() { }

	public virtual string Name() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	public void SetBossKojaniy(IBossKojaniy bossKojaniy) { }

	protected virtual bool ShallAttack() { }

	public virtual bool ShallUseNow() { }

}

