//Type is in global namespace

public class ShootFromPlace : BaseNode
{
	public bool CanLay; //Field offset: 0x18
	protected readonly Aiming _aiming; //Field offset: 0x20
	protected readonly ShallThrowGrenade _grenadeThrowNode; //Field offset: 0x28
	private float _nextGetUpCheck; //Field offset: 0x30
	private float _nextChangePos; //Field offset: 0x34
	private float _nextCheckDistPos; //Field offset: 0x38

	private float _dontUseStop
	{
		private get { } //Length: 40
	}

	public ShootFromPlace(BotOwner bot) { }

	private void CheckCanShoot(ShootHoldResultParams data) { }

	private float get__dontUseStop() { }

	protected bool ShouldChangePose() { }

	public virtual void UpdateNodeByBrain(ShootHoldResultParams data) { }

	protected void UpdateShootFromPlace(ShootHoldResultParams data) { }

}

