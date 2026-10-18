//Type is in global namespace

public class ShootSuppressNode : BaseNode
{
	private float _nextGoTime; //Field offset: 0x18
	private float WAIT_FOR_TILT; //Field offset: 0x1C
	private bool _lastFreeCast; //Field offset: 0x20
	private float _nextLineCastCheck; //Field offset: 0x24
	private float startOffset; //Field offset: 0x28
	private readonly AimingToSuppressionPoint _aiming; //Field offset: 0x30
	private Vector3 _lastShootResult; //Field offset: 0x38

	private CustomNavigationPoint CovPoint
	{
		private get { } //Length: 45
	}

	public ShootSuppressNode(BotOwner bot) { }

	private CustomNavigationPoint get_CovPoint() { }

	public Nullable GetPoint(AimingResultParams data) { }

	private bool IsLineFree(Vector3 toShoot, out Vector3 shootResult) { }

	protected void LookOutOfCover() { }

	protected bool ShouldChangePose() { }

	public virtual void UpdateNodeByBrain(AimingResultParams data) { }

}

