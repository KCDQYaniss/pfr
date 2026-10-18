namespace EFT;

public interface ICustomRotator
{

	public bool IsValid
	{
		 get { } //Length: 0
	}

	public bool get_IsValid() { }

	public Quaternion GetRotation() { }

}

