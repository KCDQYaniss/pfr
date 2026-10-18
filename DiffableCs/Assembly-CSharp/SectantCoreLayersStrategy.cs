//Type is in global namespace

public abstract class SectantCoreLayersStrategy : StrategyLayersWithCorePositions
{

	public abstract BotOwner Bot
	{
		 get { } //Length: 0
	}

	protected SectantCoreLayersStrategy(BotOwner owner) { }

	public abstract BotOwner get_Bot() { }

	public abstract bool IsCurShootAndRun() { }

	public abstract void SetAttackWithDelay(float minDelayToSupportSec) { }

	public abstract void SetBoss(BossSectantPriest sectantPriest) { }

	public abstract bool TryChangeToMelee() { }

}

