//Type is in global namespace

public class BotSteering : BotData
{
	public float FirstTurnSpeed; //Field offset: 0x18
	public float FirstTurnBigSpeed; //Field offset: 0x1C
	public float TurnSpeedSprint; //Field offset: 0x20
	protected Vector3 _lookDirection; //Field offset: 0x24
	protected readonly Player _player; //Field offset: 0x30
	private Vector3 _customPoint; //Field offset: 0x38
	private Vector3 _customDirection; //Field offset: 0x44
	private readonly BifacialTransform _ownerTransform; //Field offset: 0x50
	protected readonly bool _blockSteering; //Field offset: 0x58
	private bool _isErrorLogged; //Field offset: 0x59
	private bool _isErrorDirectionLog; //Field offset: 0x5A
	[CompilerGenerated]
	private float <Speed>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private EBotSteering <SteeringMode>k__BackingField; //Field offset: 0x60

	public Vector3 LookDirection
	{
		 get { } //Length: 19
	}

	public private float Speed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private EBotSteering SteeringMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected BotSteering(BotOwner owner) { }

	public void Activate() { }

	public float CalcYByDir(Vector3 dir) { }

	protected override bool CanSteerToMovingDirection() { }

	public static BotSteering Create(BotOwner bot) { }

	public Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public float get_Speed() { }

	[CompilerGenerated]
	public EBotSteering get_SteeringMode() { }

	public void LookToDirection(Vector3 dir, float rotateSpeed) { }

	public void LookToDirection(Vector3 dir) { }

	public void LookToMovingDirection() { }

	public void LookToMovingDirection(float rotateSpeed) { }

	public void LookToPathDestPoint(float rotateSpeed) { }

	public void LookToPathDestPoint() { }

	public void LookToPoint(Vector3 point) { }

	public void LookToPoint(Vector3 point, float rotateSpeed) { }

	public void ManualFixedUpdate() { }

	[CompilerGenerated]
	private void set_Speed(float value) { }

	[CompilerGenerated]
	private void set_SteeringMode(EBotSteering value) { }

	private void SetCurRotateSpeed(float rotateSpeed) { }

	protected override void SetXAngle(float degPerSec) { }

	public void SetYAngle(float angle) { }

	public void SetYByDir(Vector3 dir) { }

	protected override void Steering() { }

}

