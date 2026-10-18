//Type is in global namespace

public class BotReloadMelee : BotReload
{

	public BotReloadMelee(BotOwner owner, Weapon weapon) { }

	public virtual bool CanReload(bool withCheckByPeriod, out Magazine foundMag, out List ammoForInternalReload) { }

	public virtual bool FightShallReload() { }

	public virtual void Reload() { }

}

