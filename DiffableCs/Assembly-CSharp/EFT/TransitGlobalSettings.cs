namespace EFT;

public sealed class TransitGlobalSettings
{
	public bool active; //Field offset: 0x10
	public int DeliveryMinPrice; //Field offset: 0x14
	public int DeliveryPrice; //Field offset: 0x18
	public float ModDeliveryCost; //Field offset: 0x1C
	public float BearPriceMod; //Field offset: 0x20
	public float UsecPriceMod; //Field offset: 0x24
	public float ScavPriceMod; //Field offset: 0x28
	public float CoefficientDiscountCharisma; //Field offset: 0x2C
	public bool ClearAllPlayerEffectsOnTransit; //Field offset: 0x30
	public bool RestoreHealthOnDestroyedParts; //Field offset: 0x31
	public int PercentageOfMissingHealthRestore; //Field offset: 0x34
	public int PercentageOfMissingWaterRestore; //Field offset: 0x38
	public int PercentageOfMissingEnergyRestore; //Field offset: 0x3C
	public Dictionary TransitRequirementsReferences; //Field offset: 0x40

	public TransitGlobalSettings() { }

}

