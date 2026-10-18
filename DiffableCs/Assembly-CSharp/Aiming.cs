//Type is in global namespace

public abstract class Aiming : BaseNode
{
	protected BotAimTarget _targetAim; //Field offset: 0x18
	private float _nextTimeTalk; //Field offset: 0x2C
	protected readonly Shoot _shootNode; //Field offset: 0x30

	protected override bool _checkIsReady
	{
		 get { } //Length: 3
	}

	public bool IsReady
	{
		 get { } //Length: 228
	}

	protected Aiming(BotOwner bot) { }

	private Vector3 ConvertWithMove(Vector3 part, Player player) { }

	protected Nullable FindPointToShoot(Nullable trg) { }

	protected override bool get__checkIsReady() { }

	public bool get_IsReady() { }

	protected override Nullable GetTarget() { }

	protected override void ReadyToShoot() { }

	public virtual void UpdateNodeByBrain(AimingResultParams data) { }

}

