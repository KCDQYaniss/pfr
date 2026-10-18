namespace EFT.UI;

public sealed class EquipmentBuildGear : EquipmentTab
{
	[SerializeField]
	private SlotView _tacticalVestSlot; //Field offset: 0xE0
	[SerializeField]
	private SlotView _backpackSlot; //Field offset: 0xE8
	[SerializeField]
	private SlotView _securedContainerSlot; //Field offset: 0xF0

	public EquipmentBuildGear() { }

	protected virtual void Awake() { }

}

