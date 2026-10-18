namespace EFT;

internal sealed class ClientEmptyHandsController : EmptyHandsController
{
	public EmptyHandPacket EmptyHandPacket; //Field offset: 0xC0

	public ClientEmptyHandsController() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	internal static ClientEmptyHandsController Create(ClientPlayer player) { }

	internal static Task CreateAsync(ClientPlayer player) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

}

