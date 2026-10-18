namespace EFT;

public sealed class InvalidCustomRotator : ICustomRotator
{

	public override bool IsValid
	{
		 get { } //Length: 3
	}

	public InvalidCustomRotator() { }

	public override bool get_IsValid() { }

	public override Quaternion GetRotation() { }

}

