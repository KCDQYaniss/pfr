namespace EFT.Interactive;

public sealed class DestroyedState : LampState
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly CommandContainer _commandContainer; //Field offset: 0x18

	public DestroyedState(LampController lampController, CommandContainer commandContainer) { }

	public virtual void OnEnter(float time) { }

}

