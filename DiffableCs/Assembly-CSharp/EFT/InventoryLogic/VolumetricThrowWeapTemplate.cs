namespace EFT.InventoryLogic;

public class VolumetricThrowWeapTemplate : ThrowWeapTemplate
{
	public float VolumeMaxRadius; //Field offset: 0x1B0
	public float UnitSize; //Field offset: 0x1B4
	public float VolumeLifetime; //Field offset: 0x1B8
	public float VolumeGrowTime; //Field offset: 0x1BC
	public float CollisionEventInterval; //Field offset: 0x1C0
	public bool HorizontalSpreadEnabled; //Field offset: 0x1C4
	public float HorizontalSpreadWeightThreshold; //Field offset: 0x1C8
	public int VoxelRenderPercentage; //Field offset: 0x1CC
	public int VolumePresetId; //Field offset: 0x1D0
	public float GrenadeShiftThreshold; //Field offset: 0x1D4

	public VolumetricThrowWeapTemplate() { }

}

