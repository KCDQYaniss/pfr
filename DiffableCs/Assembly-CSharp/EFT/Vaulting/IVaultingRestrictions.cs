namespace EFT.Vaulting;

public interface IVaultingRestrictions
{

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public float MaxHeight
	{
		 get { } //Length: 0
	}

	public float MaxLength
	{
		 get { } //Length: 0
	}

	public float MinDistantToInteract
	{
		 get { } //Length: 0
	}

	public float MinHeight
	{
		 get { } //Length: 0
	}

	public float MinLength
	{
		 get { } //Length: 0
	}

	public bool get_IsActive() { }

	public float get_MaxHeight() { }

	public float get_MaxLength() { }

	public float get_MinDistantToInteract() { }

	public float get_MinHeight() { }

	public float get_MinLength() { }

}

