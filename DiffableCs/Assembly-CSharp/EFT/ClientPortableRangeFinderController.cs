namespace EFT;

internal sealed class ClientPortableRangeFinderController : PortableRangeFinderController
{
	public UsableItemPacket UsableItemPacket; //Field offset: 0xF0

	public ClientPortableRangeFinderController() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	public virtual bool ExamineWeapon() { }

	public virtual void Hide() { }

	public virtual void SetAim(bool value) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual void ShowGesture(EInteraction gesture) { }

}

