//Type is in global namespace

public class BossKojaniyLayer : FightKojaniyAbstractLayer
{

	public BossKojaniyLayer(BotOwner owner, int priority) { }

	public virtual void Dispose() { }

	protected virtual Vector3 GetTargetToLook() { }

	protected bool IsBossDead() { }

	protected virtual bool IsEverybodyRun() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnBecomeBoss(BotOwner obj) { }

	protected virtual bool ShallAttack() { }

	public virtual bool ShallUseNow() { }

}

