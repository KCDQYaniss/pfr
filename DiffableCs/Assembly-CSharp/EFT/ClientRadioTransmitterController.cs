namespace EFT;

internal class ClientRadioTransmitterController : RadioTransmitterController
{
	public UsableItemPacket UsableItemPacket; //Field offset: 0xE8

	public ClientRadioTransmitterController() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	public virtual bool ExamineWeapon() { }

	public virtual void Hide() { }

	public virtual void SetAim(bool value) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

}

