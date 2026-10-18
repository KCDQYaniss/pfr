namespace EFT.Vaulting;

public interface IVaultingComponentDebug
{

	public VaultingController VaultingController
	{
		 get { } //Length: 0
	}

	public IVaultingModelDebug VaultingModelDebug
	{
		 get { } //Length: 0
	}

	public VaultingController get_VaultingController() { }

	public IVaultingModelDebug get_VaultingModelDebug() { }

	public void SetCurrentMove(Nullable move) { }

}

