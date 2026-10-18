namespace EFT.InventoryLogic;

public interface IHealable
{

	public int Health
	{
		 get { } //Length: 0
	}

	public int get_Health() { }

	public void RemoveBleeding() { }

	public void RestoreHealth(int restoreHealthAmount) { }

}

