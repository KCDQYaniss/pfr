namespace EFT;

public sealed class PlayerVisualRepresentation
{
	public readonly PlayerInfo Info; //Field offset: 0x10
	[CanBeNull]
	public readonly BodyCustomization Customization; //Field offset: 0x18
	[CanBeNull]
	public readonly InventoryEquipment Equipment; //Field offset: 0x20

	public PlayerVisualRepresentation(PlayerInfo info, BodyCustomization customization, InventoryEquipment equipment) { }

	public PlayerVisualRepresentation(PlayerVisualRepresentationDescriptor descriptor) { }

	public bool IsEmpty() { }

}

