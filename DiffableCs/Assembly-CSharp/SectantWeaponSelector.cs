//Type is in global namespace

public class SectantWeaponSelector : BotWeaponSelector
{

	public virtual bool ShouldChnageFromMeleeOnHold
	{
		 get { } //Length: 3
	}

	public SectantWeaponSelector(BotOwner owner) { }

	public virtual bool get_ShouldChnageFromMeleeOnHold() { }

}

