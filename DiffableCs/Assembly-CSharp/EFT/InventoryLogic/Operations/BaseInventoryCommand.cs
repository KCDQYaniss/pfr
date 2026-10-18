namespace EFT.InventoryLogic.Operations;

public abstract class BaseInventoryCommand
{

	[JsonIgnore]
	public override bool Queued
	{
		 get { } //Length: 3
	}

	protected BaseInventoryCommand() { }

	public override bool get_Queued() { }

}

