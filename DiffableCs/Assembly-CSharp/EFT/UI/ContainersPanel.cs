namespace EFT.UI;

[UsedImplicitly]
public sealed class ContainersPanel : UIElement
{
	private const int POCKETS_ADDITIONAL_HORIZONTAL_SPACE = 10; //Field offset: 0x0
	private static readonly EquipmentSlot[] _slotNames; //Field offset: 0x0
	[SerializeField]
	private Transform _slotViewsContainer; //Field offset: 0x70
	[SerializeField]
	private SlotView _dogtagTemplate; //Field offset: 0x78
	[FormerlySerializedAs("SlotTemplate")]
	[SerializeField]
	private SlotView _defaultSlotTemplate; //Field offset: 0x80
	private readonly Dictionary _slotViews; //Field offset: 0x88
	private SlotView _dogtagSlotView; //Field offset: 0x90

	private static ContainersPanel() { }

	public ContainersPanel() { }

	public virtual void Close() { }

	private SlotView InstantiateSlotView(EquipmentSlot slotName) { }

	public void Show(ItemContext parentContext, InventoryEquipment equipment, InventoryController inventoryController, SkillManager skills, InsuranceCompany insurance, bool inRaid) { }

}

