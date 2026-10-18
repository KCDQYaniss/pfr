//Type is in global namespace

public class LookSensorShootPosition
{
	protected readonly BotOwner _owner; //Field offset: 0x10
	private Vector3 _canShootStartPos; //Field offset: 0x18

	public override Vector3 ShootStartPos
	{
		 get { } //Length: 19
	}

	public LookSensorShootPosition(BotOwner owner) { }

	public override Vector3 get_ShootStartPos() { }

	public override void UpdateShootPosition(Vector3 weaponRootPoint) { }

}

