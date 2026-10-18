//Type is in global namespace

public abstract class MoveToEnemy : MoveNode
{
	protected float _updatePointTimer; //Field offset: 0x28
	protected float _updateChangeMeleeTimer; //Field offset: 0x2C

	public MoveToEnemy(BotOwner bot) { }

	private bool CanShootAtCurWay(out Vector3 curTargetPos) { }

	protected override void NotMovingCheck() { }

	protected void PeriodChangeWeapon() { }

}

