namespace EFT.InventoryLogic;

public interface ISightComponentTemplate : IAdjustableOpticData
{

	public float[][] AimSensitivity
	{
		 get { } //Length: 0
	}

	public int[][] CalibrationDistances
	{
		 get { } //Length: 0
	}

	public string CustomAimPlane
	{
		 get { } //Length: 0
	}

	public int[] ModesCount
	{
		 get { } //Length: 0
	}

	public int ScopesCount
	{
		 get { } //Length: 0
	}

	public float[][] Zooms
	{
		 get { } //Length: 0
	}

	public float[][] get_AimSensitivity() { }

	public int[][] get_CalibrationDistances() { }

	public string get_CustomAimPlane() { }

	public int[] get_ModesCount() { }

	public int get_ScopesCount() { }

	public float[][] get_Zooms() { }

}

