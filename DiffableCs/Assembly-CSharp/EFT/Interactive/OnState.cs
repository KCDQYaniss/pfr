namespace EFT.Interactive;

public sealed class OnState : LampState
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly LampStateMachine _stateMachine; //Field offset: 0x18
	private readonly CommandContainer _commandContainer; //Field offset: 0x20
	private Random _random; //Field offset: 0x28
	private float _initialFlickering; //Field offset: 0x2C
	private float _turnedOnFlickeringTarget; //Field offset: 0x30
	private float _flickeringRestorationTime; //Field offset: 0x34
	private float _normalFlickerTime; //Field offset: 0x38
	private float _turnedOnFlickering; //Field offset: 0x3C
	private bool _isDamaged; //Field offset: 0x40
	private float _damageSparksTimeStamp; //Field offset: 0x44

	public OnState(LampController lampController, LampStateMachine stateMachine, CommandContainer commandContainer) { }

	public void MakeDamage(float strength) { }

	public virtual void OnEnter(float time) { }

	public virtual LampState OnUpdate(float time, float deltaTime) { }

	private bool TodStateChanged() { }

}

