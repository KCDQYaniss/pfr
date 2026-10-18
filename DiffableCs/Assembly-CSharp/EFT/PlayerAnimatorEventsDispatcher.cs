namespace EFT;

public class PlayerAnimatorEventsDispatcher
{
	private readonly AnimationEventsEmitter _animEventsEmitter; //Field offset: 0x10
	private readonly PlayerAnimatorControllerEventsTable _eventsTable; //Field offset: 0x18

	public IPlayerAnimatorEvents PlayerAnimatorEvents
	{
		 get { } //Length: 5
	}

	public PlayerAnimatorEventsDispatcher(IAnimator animator) { }

	private void DispatchAnimatorEvents(int functionNameHash, AnimationEventParameter parameter) { }

	public void Dispose() { }

	public void EmitEvents() { }

	public IPlayerAnimatorEvents get_PlayerAnimatorEvents() { }

}

