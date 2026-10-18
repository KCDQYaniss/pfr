namespace EFT;

public interface IFirearmAnimationDataRepresenter
{

	public BifacialTransform CurrentFireport
	{
		 get { } //Length: 0
	}

	public float ErgonomicWeight
	{
		 get { } //Length: 0
	}

	public bool MouseLookControl
	{
		 get { } //Length: 0
	}

	public float TotalErgonomics
	{
		 get { } //Length: 0
	}

	public Weapon Weapon
	{
		 get { } //Length: 0
	}

	public BifacialTransform get_CurrentFireport() { }

	public float get_ErgonomicWeight() { }

	public bool get_MouseLookControl() { }

	public float get_TotalErgonomics() { }

	public Weapon get_Weapon() { }

	public void RecalculateErgonomic() { }

}

