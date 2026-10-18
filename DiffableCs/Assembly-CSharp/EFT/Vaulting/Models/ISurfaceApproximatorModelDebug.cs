namespace EFT.Vaulting.Models;

public interface ISurfaceApproximatorModelDebug
{

	public List ResultPoints
	{
		 get { } //Length: 0
	}

	public float Tolerance
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public List Approximate(List points) { }

	public List get_ResultPoints() { }

	public float get_Tolerance() { }

	public void set_Tolerance(float value) { }

}

