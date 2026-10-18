//Type is in global namespace

public class ApproachState : MovementState
{
	private float _stateTime; //Field offset: 0xA0
	private float _enterTime; //Field offset: 0xA4
	private float _approachTime; //Field offset: 0xA8
	public Vector2 ApproachSpeed; //Field offset: 0xAC
	public float ApproachAngularSpeed; //Field offset: 0xB4
	public float TMinus; //Field offset: 0xB8
	public AnimationCurve ApproachCurve; //Field offset: 0xC0
	private Vector3 _interactPosition; //Field offset: 0xC8
	private Vector3 _viewTargetPosition; //Field offset: 0xD4
	private bool _snap; //Field offset: 0xE0
	private Vector2 _initialRotation; //Field offset: 0xE4
	private float _initialBodyRotation; //Field offset: 0xEC
	private float _initLevel; //Field offset: 0xF0
	private Vector3 _initialPlayerPosition; //Field offset: 0xF4
	private float _initialSpeed; //Field offset: 0x100
	private bool _raise; //Field offset: 0x104
	private bool _lower; //Field offset: 0x105
	private bool _approached; //Field offset: 0x106
	private Vector2 _viewDir; //Field offset: 0x108
	private Vector3 _localDirection; //Field offset: 0x110

	public bool ApproachDone
	{
		 get { } //Length: 19
	}

	public float ApproachProgress
	{
		 get { } //Length: 17
	}

	public ApproachState(MovementContext movementContext) { }

	private void Approach(float stateTime, float dt) { }

	public virtual void BlindFire(int b) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public bool get_ApproachDone() { }

	public float get_ApproachProgress() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Prone() { }

}

