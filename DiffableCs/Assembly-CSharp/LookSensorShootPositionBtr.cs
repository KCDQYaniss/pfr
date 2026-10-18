//Type is in global namespace

public class LookSensorShootPositionBtr : LookSensorShootPosition
{

	public virtual Vector3 ShootStartPos
	{
		 get { } //Length: 241
	}

	public LookSensorShootPositionBtr(BotOwner owner) { }

	public virtual Vector3 get_ShootStartPos() { }

	public virtual void UpdateShootPosition(Vector3 weaponRootPoint) { }

}

