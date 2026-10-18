namespace EFT.Vaulting;

public interface IMovesSettings
{

	public IClimbSettings ClimbSettings
	{
		 get { } //Length: 0
	}

	public IVaultSettings VaultSettings
	{
		 get { } //Length: 0
	}

	public IClimbSettings get_ClimbSettings() { }

	public IVaultSettings get_VaultSettings() { }

}

