namespace EFT.Interactive;

public sealed class HasItemRequirement : InventoryRequirements
{

	public HasItemRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

