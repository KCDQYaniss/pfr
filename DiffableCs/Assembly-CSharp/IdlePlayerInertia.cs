//Type is in global namespace

public class IdlePlayerInertia
{
	private MovementContext MovementContext; //Field offset: 0x10
	private float _sideBackSpeed; //Field offset: 0x18
	private bool _isStepOut; //Field offset: 0x1C

	private float BaseSidebackSpeed
	{
		private get { } //Length: 66
	}

	private float MaxSidebackSpeed
	{
		private get { } //Length: 31
	}

	protected float SideBackSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 73
	}

	private float SideBackSpeedAcceleration
	{
		private get { } //Length: 66
	}

	public IdlePlayerInertia() { }

	public void Enter() { }

	private float get_BaseSidebackSpeed() { }

	private float get_MaxSidebackSpeed() { }

	protected float get_SideBackSpeed() { }

	private float get_SideBackSpeedAcceleration() { }

	public void Init(MovementContext context) { }

	public void ProcessAnimatorStep(float deltaTime, EStateType Type) { }

	protected void set_SideBackSpeed(float value) { }

}

