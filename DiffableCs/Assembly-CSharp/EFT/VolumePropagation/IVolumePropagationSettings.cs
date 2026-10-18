namespace EFT.VolumePropagation;

public interface IVolumePropagationSettings
{

	public float CollisionEventInterval
	{
		 get { } //Length: 0
	}

	public bool DownPriority
	{
		 get { } //Length: 0
	}

	public float GrowTime
	{
		 get { } //Length: 0
	}

	public bool HorizontalSpreadEnabled
	{
		 get { } //Length: 0
	}

	public float HorizontalSpreadWeightThreshold
	{
		 get { } //Length: 0
	}

	public float Lifetime
	{
		 get { } //Length: 0
	}

	public float MaxRadius
	{
		 get { } //Length: 0
	}

	public float UnitSize
	{
		 get { } //Length: 0
	}

	public int VoxelRenderPercentage
	{
		 get { } //Length: 0
	}

	public float get_CollisionEventInterval() { }

	public bool get_DownPriority() { }

	public float get_GrowTime() { }

	public bool get_HorizontalSpreadEnabled() { }

	public float get_HorizontalSpreadWeightThreshold() { }

	public float get_Lifetime() { }

	public float get_MaxRadius() { }

	public float get_UnitSize() { }

	public int get_VoxelRenderPercentage() { }

}

