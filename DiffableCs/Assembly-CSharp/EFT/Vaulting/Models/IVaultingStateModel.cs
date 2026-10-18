namespace EFT.Vaulting.Models;

public interface IVaultingStateModel
{

	public Nullable AverageDistance
	{
		 get { } //Length: 0
	}

	public Nullable AverageHeight
	{
		 get { } //Length: 0
	}

	public Nullable AverageLength
	{
		 get { } //Length: 0
	}

	public Nullable CurrentMotion
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float VerticalOffset
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void CalculateParameters(VaultingStateDataTransferModel data) { }

	public Nullable get_AverageDistance() { }

	public Nullable get_AverageHeight() { }

	public Nullable get_AverageLength() { }

	public Nullable get_CurrentMotion() { }

	public float get_VerticalOffset() { }

	public void set_CurrentMotion(Nullable value) { }

	public void set_VerticalOffset(float value) { }

}

