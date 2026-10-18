//Type is in global namespace

public class HoldPosition : ShootFromCover
{
	private float _nextCheckReload; //Field offset: 0x50
	private float _updateChangeMeleeTimer; //Field offset: 0x54
	private AIPeriodAction _periodRandomLook; //Field offset: 0x58

	public HoldPosition(BotOwner bot) { }

	private void CheckWantReload() { }

	protected override void Look() { }

	protected void PeriodChangeWeapon() { }

	private void SetRandomLook() { }

	public virtual void UpdateNodeByBrain(ShootHoldResultParams data) { }

}

