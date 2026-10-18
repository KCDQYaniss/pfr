namespace EFT.InventoryLogic;

public sealed class RepairBuffAttribute : ItemAttribute
{
	private RepairableComponent _repairable; //Field offset: 0x80
	private BuffComponent _buffComponent; //Field offset: 0x88

	public RepairBuffAttribute(EItemAttributeId repairBuffType, RepairableComponent repairable, BuffComponent buffComponent) { }

	private string GetEnhancementTooltip() { }

}

