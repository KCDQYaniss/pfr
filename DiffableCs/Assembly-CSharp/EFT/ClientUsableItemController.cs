namespace EFT;

internal sealed class ClientUsableItemController : UsableItemController
{
	public UsableItemPacket UsableItemPacket; //Field offset: 0xE0

	public ClientUsableItemController() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	internal static ClientUsableItemController Create(ClientPlayer player, Item item) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId) { }

	public virtual bool ExamineWeapon() { }

	public virtual void SetAim(bool value) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

}

