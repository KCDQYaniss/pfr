namespace EFT.Vaulting.Models;

public interface IAutomaticVaultingModel
{

	public bool IsEnableAutoClimb
	{
		 get { } //Length: 0
	}

	public bool IsEnableAutoVault
	{
		 get { } //Length: 0
	}

	public float MaxClimbHeight
	{
		 get { } //Length: 0
	}

	public float MaxClimbLength
	{
		 get { } //Length: 0
	}

	public float MaxVaultHeight
	{
		 get { } //Length: 0
	}

	public float MaxVaultLength
	{
		 get { } //Length: 0
	}

	public float MinClimbHeight
	{
		 get { } //Length: 0
	}

	public float MinClimbLength
	{
		 get { } //Length: 0
	}

	public float MinVaultHeight
	{
		 get { } //Length: 0
	}

	public float MinVaultLength
	{
		 get { } //Length: 0
	}

	public bool get_IsEnableAutoClimb() { }

	public bool get_IsEnableAutoVault() { }

	public float get_MaxClimbHeight() { }

	public float get_MaxClimbLength() { }

	public float get_MaxVaultHeight() { }

	public float get_MaxVaultLength() { }

	public float get_MinClimbHeight() { }

	public float get_MinClimbLength() { }

	public float get_MinVaultHeight() { }

	public float get_MinVaultLength() { }

}

