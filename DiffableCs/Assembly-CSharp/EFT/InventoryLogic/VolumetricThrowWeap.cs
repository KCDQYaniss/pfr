namespace EFT.InventoryLogic;

public class VolumetricThrowWeap : ThrowWeap
{

	public float CollisionEventInterval
	{
		 get { } //Length: 81
	}

	public float GrenadeShiftThreshold
	{
		 get { } //Length: 81
	}

	public bool HorizontalSpreadEnabled
	{
		 get { } //Length: 80
	}

	public float HorizontalSpreadWeightThreshold
	{
		 get { } //Length: 81
	}

	public float UnitSize
	{
		 get { } //Length: 81
	}

	public float VolumeGrowTime
	{
		 get { } //Length: 81
	}

	public float VolumeLifetime
	{
		 get { } //Length: 81
	}

	public float VolumeMaxRadius
	{
		 get { } //Length: 81
	}

	public int VolumePresetId
	{
		 get { } //Length: 79
	}

	public int VoxelRenderPercentage
	{
		 get { } //Length: 79
	}

	public VolumetricThrowWeap(string id, VolumetricThrowWeapTemplate template) { }

	public IVolumeSourceSettings BuildVolumeSourceSettings() { }

	public float get_CollisionEventInterval() { }

	public float get_GrenadeShiftThreshold() { }

	public bool get_HorizontalSpreadEnabled() { }

	public float get_HorizontalSpreadWeightThreshold() { }

	public float get_UnitSize() { }

	public float get_VolumeGrowTime() { }

	public float get_VolumeLifetime() { }

	public float get_VolumeMaxRadius() { }

	public int get_VolumePresetId() { }

	public int get_VoxelRenderPercentage() { }

}

