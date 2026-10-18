namespace EFT.UI;

public class EquipmentTab : UIElement
{
	[SerializeField]
	private SlotView _earpieceSlot; //Field offset: 0x70
	[SerializeField]
	private SlotView _headwearSlot; //Field offset: 0x78
	[SerializeField]
	private SlotView _faceCoverSlot; //Field offset: 0x80
	[SerializeField]
	private SlotView _armbandSlot; //Field offset: 0x88
	[SerializeField]
	private SlotView _armorSlot; //Field offset: 0x90
	[SerializeField]
	private SlotView _eyewearSlot; //Field offset: 0x98
	[SerializeField]
	private SlotView _primaryWeaponSlot; //Field offset: 0xA0
	[SerializeField]
	private SlotView _holsterSlot; //Field offset: 0xA8
	[SerializeField]
	private SlotView _seconaryWeaponSlot; //Field offset: 0xB0
	[SerializeField]
	private SlotView _scabbardSlot; //Field offset: 0xB8
	[SerializeField]
	private SlotView _dogTagSlot; //Field offset: 0xC0
	private InventoryController _inventoryController; //Field offset: 0xC8
	private InventoryEquipment _equipment; //Field offset: 0xD0
	protected Dictionary _slotViews; //Field offset: 0xD8

	public EquipmentTab() { }

	protected override void Awake() { }

	private void CreateSlotViews() { }

	public SlotView GetSlotView(EquipmentSlot slotType) { }

	public void Hide() { }

	public void Show(ItemContext equipmentContext, InventoryEquipment equipment, InventoryController inventoryController, SkillManager skills, InsuranceCompany insurance, bool inRaid) { }

}

