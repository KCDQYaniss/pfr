namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public sealed class ComplexStashPanel : UIElement
{
	[SerializeField]
	private TMP_Text _complexGridName; //Field offset: 0x70
	[SerializeField]
	private Transform _lootPanel; //Field offset: 0x78
	[SerializeField]
	private ContainersPanel _containersPanel; //Field offset: 0x80
	[SerializeField]
	private EquipmentTab _equipmentPanelSource; //Field offset: 0x88
	[SerializeField]
	private GameObject _complexPanel; //Field offset: 0x90
	[SerializeField]
	private GameObject _containerNamePanel; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _containerName; //Field offset: 0xA0
	private EquipmentTab _equipmentPanel; //Field offset: 0xA8
	private InventoryController _inventoryController; //Field offset: 0xB0
	private InventoryEquipment _equipment; //Field offset: 0xB8
	private ItemUiContext _itemUiContext; //Field offset: 0xC0
	private SkillManager _skills; //Field offset: 0xC8
	private InsuranceCompany _insurance; //Field offset: 0xD0
	private ItemContext _equipmentContext; //Field offset: 0xD8

	public ComplexStashPanel() { }

	[CompilerGenerated]
	private void <Show>b__14_0() { }

	public virtual void Close() { }

	public void Show(InventoryController inventoryController, ItemContext equipmentContext, InventoryEquipment equipment, SkillManager skills, InsuranceCompany insurance, ItemUiContext itemUiContext) { }

	public void UnConfigure() { }

}

