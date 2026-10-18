namespace EFT.InventoryLogic;

public interface ICommand
{

	public ECommandResult Result
	{
		 get { } //Length: 0
	}

	public void Execute() { }

	public ECommandResult get_Result() { }

	public void Revert() { }

}

