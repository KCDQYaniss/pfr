namespace EFT.InventoryLogic;

public class Trasaction
{
	private ETrasactionState state; //Field offset: 0x10
	private Queue commandsQueue; //Field offset: 0x18
	private Stack executedCommandsStack; //Field offset: 0x20

	public ETrasactionState State
	{
		 get { } //Length: 164
	}

	public Trasaction() { }

	public void Add(ICommand command) { }

	private bool AllCommandsSuccessfullyExecuted() { }

	public void Execute() { }

	public ETrasactionState get_State() { }

	private void ProcessCommand(ICommand command) { }

	private void RollBack() { }

}

