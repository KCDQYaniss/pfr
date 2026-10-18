namespace EFT.Interactive;

public class LampStateMachine
{
	private LampState _current; //Field offset: 0x10
	private readonly ConstantFlickeringState _constantFlickeringState; //Field offset: 0x18
	private readonly DestroyedState _destroyedState; //Field offset: 0x20
	private readonly EmptyState _emptyState; //Field offset: 0x28
	private readonly OffState _offState; //Field offset: 0x30
	private readonly OnState _onState; //Field offset: 0x38
	private readonly InstantTurningOffState _instantTurningOffState; //Field offset: 0x40
	private readonly TurningOffState _smoothTurningOffState; //Field offset: 0x48
	private readonly TurningOnState _turningOnState; //Field offset: 0x50
	[CompilerGenerated]
	private readonly int <Seed>k__BackingField; //Field offset: 0x58

	public LampState ConstantFlickeringState
	{
		 get { } //Length: 5
	}

	public LampState DestroyedState
	{
		 get { } //Length: 5
	}

	public LampState EmptyState
	{
		 get { } //Length: 5
	}

	public LampState InstantTurningOffState
	{
		 get { } //Length: 5
	}

	public LampState OffState
	{
		 get { } //Length: 76
	}

	public LampState OnState
	{
		 get { } //Length: 5
	}

	public int Seed
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public LampState SmoothTurningOffState
	{
		 get { } //Length: 5
	}

	public LampState TurningOnState
	{
		 get { } //Length: 5
	}

	public LampStateMachine(LampController controller, int seed, CommandContainer commandContainer) { }

	public LampState get_ConstantFlickeringState() { }

	public LampState get_DestroyedState() { }

	public LampState get_EmptyState() { }

	public LampState get_InstantTurningOffState() { }

	public LampState get_OffState() { }

	public LampState get_OnState() { }

	[CompilerGenerated]
	public int get_Seed() { }

	public LampState get_SmoothTurningOffState() { }

	public LampState get_TurningOnState() { }

	public void GoToState(LampState state, float time) { }

	public void MakeSomeDamage(float strength) { }

	public void Update(float time, float deltaTime) { }

}

