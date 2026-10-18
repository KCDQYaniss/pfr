//Type is in global namespace

public interface IPlayerStateContainerBehaviour : IStateBehaviour
{

	public bool DefaultState
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public BaseMovementState EncapsulatedState
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int FullNameHash
	{
		 get { } //Length: 0
	}

	public EPlayerState PlayerStateName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Deinit() { }

	public bool get_DefaultState() { }

	public BaseMovementState get_EncapsulatedState() { }

	public int get_FullNameHash() { }

	public EPlayerState get_PlayerStateName() { }

	public void Init(Func newStateFunc) { }

	public void set_DefaultState(bool value) { }

	public void set_EncapsulatedState(BaseMovementState value) { }

	public void set_PlayerStateName(EPlayerState value) { }

}

