namespace EFT.Vaulting;

public interface IVaultingSettings
{

	public IGridSettings GridSettings
	{
		 get { } //Length: 0
	}

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public IMovesSettings MovesSettings
	{
		 get { } //Length: 0
	}

	public float VaultingInputTime
	{
		 get { } //Length: 0
	}

	public IGridSettings get_GridSettings() { }

	public bool get_IsActive() { }

	public IMovesSettings get_MovesSettings() { }

	public float get_VaultingInputTime() { }

}

