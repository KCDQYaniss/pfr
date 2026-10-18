//Type is in global namespace

public class BigPipeBotWeaponSelector : BotWeaponSelector
{
	private const float MAX_DIST_GRENADE = 130; //Field offset: 0x0
	private const float MIN_DIST_GRENADE = 27; //Field offset: 0x0
	private bool _isSecondGrenade; //Field offset: 0x70
	private bool _isFirstGrenade; //Field offset: 0x71
	private float _periodCanChange; //Field offset: 0x74

	public bool IsGrenadeLauncher
	{
		 get { } //Length: 8
	}

	public BigPipeBotWeaponSelector(BotOwner owner) { }

	public virtual void Activate() { }

	private bool AlliesNearEnemy() { }

	private bool CheckGrenadeLauncher(Item secondPrimaryWeapon) { }

	public bool get_IsGrenadeLauncher() { }

	public virtual void ManualUpdate() { }

}

