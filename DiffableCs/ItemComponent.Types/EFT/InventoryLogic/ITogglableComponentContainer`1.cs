namespace EFT.InventoryLogic;

public interface ITogglableComponentContainer`1 : ITogglableComponentContainer, IItemComponent
{

	public TITogglableComponent Togglable
	{
		 get { } //Length: 0
	}

	public TITogglableComponent get_Togglable() { }

}

