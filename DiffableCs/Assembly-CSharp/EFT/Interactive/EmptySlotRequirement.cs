namespace EFT.Interactive;

public sealed class EmptySlotRequirement : InventoryRequirements
{

	public EmptySlotRequirement() { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

}

