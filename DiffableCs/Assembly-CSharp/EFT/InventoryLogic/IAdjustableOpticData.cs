namespace EFT.InventoryLogic;

public interface IAdjustableOpticData
{

	public float AdjustableOpticSensitivity
	{
		 get { } //Length: 0
	}

	public float AdjustableOpticSensitivityMax
	{
		 get { } //Length: 0
	}

	public bool IsAdjustableOptic
	{
		 get { } //Length: 0
	}

	public Vector3 MinMaxFov
	{
		 get { } //Length: 0
	}

	public float ZoomSensitivity
	{
		 get { } //Length: 0
	}

	public float get_AdjustableOpticSensitivity() { }

	public float get_AdjustableOpticSensitivityMax() { }

	public bool get_IsAdjustableOptic() { }

	public Vector3 get_MinMaxFov() { }

	public float get_ZoomSensitivity() { }

}

