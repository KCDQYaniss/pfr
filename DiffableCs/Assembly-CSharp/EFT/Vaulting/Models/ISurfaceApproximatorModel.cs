namespace EFT.Vaulting.Models;

public interface ISurfaceApproximatorModel
{

	public float Tolerance
	{
		 get { } //Length: 0
	}

	public List Approximate(List points) { }

	public float get_Tolerance() { }

}

