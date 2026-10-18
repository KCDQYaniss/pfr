namespace EFT;

public class StationaryPlayerState : IdlePlayerState
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public FirearmController firearm; //Field offset: 0x10
		public StationaryPlayerState <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <Spawned>b__0() { }

		internal void <Spawned>b__1() { }

	}

	internal enum EStationaryStage
	{
		In = 0,
		Main = 1,
		Out = 2,
	}

	private const float OUT_TRANSITION_LENGTH = 0.5; //Field offset: 0x0
	private const float DISTANCE_THRESHOLD = 0.1; //Field offset: 0x0
	public EStationaryStage Stage; //Field offset: 0xB0
	public StationaryWeapon StationaryWeapon; //Field offset: 0xB8
	private Vector2 _exitRotation; //Field offset: 0xC0
	private Vector2 _outVelocity; //Field offset: 0xC8
	private float _outVelocityX; //Field offset: 0xD0
	private float _outVelocityY; //Field offset: 0xD4
	private float _outTime; //Field offset: 0xD8
	private Transform _weaponTransform; //Field offset: 0xE0
	private bool _denied; //Field offset: 0xE8
	private Action _handsChangingEventUnsubscribe; //Field offset: 0xF0
	private Action _shotUnsubscribe; //Field offset: 0xF8

	public override bool OutOfOperationRange
	{
		 get { } //Length: 394
	}

	public StationaryPlayerState(MovementContext movementContext) { }

	public virtual void BlindFire(int b) { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void ChangeSpeed(float speedDelta) { }

	public virtual void DropStationary() { }

	public virtual void EnableBreath(bool enable) { }

	public virtual void EnableSprint(bool enable, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	public override bool get_OutOfOperationRange() { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	private void MovementContextOnHandsChangedEvent() { }

	private void OnHandsControllerChanged(AbstractHandsController arg1, AbstractHandsController arg2) { }

	public virtual void OnInteraction() { }

	public virtual void Prone() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	private void Spawned(AbstractHandsController arg1, AbstractHandsController newContoller) { }

}

