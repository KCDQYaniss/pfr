//Type is in global namespace

public class BossZryachiyPeacefull : ABossLogic
{

	public BossZryachiyPeacefull(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	private void OnBeenKilledByAggressor(Player player, IPlayer lastaggressor, DamageInfo damageinfo, EBodyPart part) { }

	private void OnBeingHit(DamageInfo info, EBodyPart arg2, float arg3) { }

	public virtual void SetPatrolMode() { }

}

