//Type is in global namespace

public class ShootFromStationary : BaseNode
{
	private readonly AimingFromStationary _aiming; //Field offset: 0x18

	public ShootFromStationary(BotOwner bot) { }

	private bool CheckCanShoot() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

