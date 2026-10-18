namespace EFT.InventoryLogic;

public interface IFireModeComponentTemplate
{

	public EFireMode[] AvailablEFireModes
	{
		 get { } //Length: 0
	}

	public int BurstShotsCount
	{
		 get { } //Length: 0
	}

	public EFireMode[] get_AvailablEFireModes() { }

	public int get_BurstShotsCount() { }

}

