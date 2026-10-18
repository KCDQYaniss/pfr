namespace EFT.Interactive;

public sealed class EmptyOrSmallerRequirement : InventoryRequirements
{

	public EmptyOrSmallerRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

