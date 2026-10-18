//Type is in global namespace

public class AimingManager : BotData
{
	private EAimingType _current; //Field offset: 0x18
	private readonly Dictionary _aimingTypes; //Field offset: 0x20

	public IBotAiming CurrentAiming
	{
		 get { } //Length: 77
	}

	public AimingManager(BotOwner owner) { }

	public IBotAiming get_CurrentAiming() { }

	public void ManualUpdate() { }

	public void NodeUpdate() { }

	public void SetAimingType(EAimingType newAimingType) { }

	public void SetWeapon(Weapon weapon) { }

}

