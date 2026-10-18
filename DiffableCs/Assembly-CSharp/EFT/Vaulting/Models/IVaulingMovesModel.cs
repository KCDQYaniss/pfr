namespace EFT.Vaulting.Models;

public interface IVaulingMovesModel
{

	public IVaultingMove ClimbState
	{
		 get { } //Length: 0
	}

	public float MaxVaultingHeight
	{
		 get { } //Length: 0
	}

	public float MaxVaultingLength
	{
		 get { } //Length: 0
	}

	public float MinVaultingHeight
	{
		 get { } //Length: 0
	}

	public float MinVaultingLength
	{
		 get { } //Length: 0
	}

	public IVaultingMove VaultState
	{
		 get { } //Length: 0
	}

	public IVaultingMove get_ClimbState() { }

	public float get_MaxVaultingHeight() { }

	public float get_MaxVaultingLength() { }

	public float get_MinVaultingHeight() { }

	public float get_MinVaultingLength() { }

	public IVaultingMove get_VaultState() { }

}

