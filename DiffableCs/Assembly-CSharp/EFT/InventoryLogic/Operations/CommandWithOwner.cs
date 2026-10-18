namespace EFT.InventoryLogic.Operations;

public abstract class CommandWithOwner : BaseInventoryCommand
{
	[JsonProperty("fromOwner", NullValueHandling = NullValueHandling::Ignore (1))]
	public OwnerInfo FromOwner; //Field offset: 0x10

	protected CommandWithOwner() { }

}

