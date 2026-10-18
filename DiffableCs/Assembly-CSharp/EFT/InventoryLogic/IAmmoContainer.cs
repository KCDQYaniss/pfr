namespace EFT.InventoryLogic;

public interface IAmmoContainer
{

	public StackSlot Cartridges
	{
		 get { } //Length: 0
	}

	public IEnumerable Containers
	{
		 get { } //Length: 0
	}

	public int Count
	{
		 get { } //Length: 0
	}

	public StackSlot get_Cartridges() { }

	public IEnumerable get_Containers() { }

	public int get_Count() { }

	public Ammo GetBulletAtPosition(int index) { }

	[CanBeNull]
	public IContainer GetContainer(string containerId) { }

}

