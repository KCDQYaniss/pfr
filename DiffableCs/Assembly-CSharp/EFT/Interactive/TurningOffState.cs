namespace EFT.Interactive;

public class TurningOffState : LampState
{
	private readonly LampStateMachine _stateMachine; //Field offset: 0x10
	private readonly LampController _lampController; //Field offset: 0x18
	private float _turnedOffLength; //Field offset: 0x20
	private float _completeTime; //Field offset: 0x24
	private Random _random; //Field offset: 0x28
	[CompilerGenerated]
	private readonly CommandContainer <CommandContainer>k__BackingField; //Field offset: 0x30

	protected CommandContainer CommandContainer
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public TurningOffState(LampController lampController, CommandContainer commandContainer, LampStateMachine stateMachine) { }

	[CompilerGenerated]
	protected CommandContainer get_CommandContainer() { }

	public virtual void OnEnter(float time) { }

	public virtual LampState OnUpdate(float time, float deltaTime) { }

}

