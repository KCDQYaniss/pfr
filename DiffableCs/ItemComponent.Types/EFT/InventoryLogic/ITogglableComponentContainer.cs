namespace EFT.InventoryLogic;

public interface ITogglableComponentContainer : IItemComponent
{

	public ITogglableComponent Togglable
	{
		 get { } //Length: 0
	}

	public ITogglableComponent get_Togglable() { }

}

