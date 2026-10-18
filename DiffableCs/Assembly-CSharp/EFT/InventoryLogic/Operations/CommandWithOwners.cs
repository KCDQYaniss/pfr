namespace EFT.InventoryLogic.Operations;

public abstract class CommandWithOwners : CommandWithOwner
{
	[JsonProperty("toOwner", NullValueHandling = NullValueHandling::Ignore (1))]
	public OwnerInfo ToOwner; //Field offset: 0x18

	protected CommandWithOwners() { }

}

