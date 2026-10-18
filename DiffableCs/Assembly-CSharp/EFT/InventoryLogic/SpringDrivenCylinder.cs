namespace EFT.InventoryLogic;

public class SpringDrivenCylinder : CylinderMagazine
{

	public SpringDrivenCylinder(string id, SpringDrivenCylinderTemplate template) { }

	protected virtual int CamoraIndexForDoubleActionFire() { }

	public virtual bool CanRollCylinderInsteadOfReload() { }

	public virtual void DryFireIncrementCamoraIndex() { }

	public virtual List GetFreeCamorasIndexesFromCurrentActiveIndex(bool quickReload, bool singleAction) { }

	public virtual void IncrementCamoraIndex(bool rollToZeroCamora = false) { }

	public virtual void ResetCamoraIndex() { }

	public virtual void SetNotEmptyCamoraAsActive() { }

}

