namespace EFT;

public class DoorInteractSubState
{
	protected DoorInteractState _baseState; //Field offset: 0x10
	public Func Transition; //Field offset: 0x18

	public DoorInteractSubState GetNextState
	{
		 get { } //Length: 29
	}

	public DoorInteractSubState(DoorInteractState baseState) { }

	public DoorInteractSubState get_GetNextState() { }

	public override void OnEnter() { }

	public override void OnExit() { }

	public override void Update(float dt) { }

}

