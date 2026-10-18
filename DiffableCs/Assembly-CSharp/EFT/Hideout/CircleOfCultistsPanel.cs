namespace EFT.Hideout;

public sealed class CircleOfCultistsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ItemSelectionCell selector; //Field offset: 0x10
		public CircleOfCultistsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal bool <Show>b__0(Item itemToTest) { }

		internal void <Show>b__1(Item selectedItem) { }

		internal void <Show>b__2() { }

	}

	[SerializeField]
	private Transform _root; //Field offset: 0x70
	[SerializeField]
	private ItemSelectionCell _itemSelectionsTemplate; //Field offset: 0x78
	private AreaData _areaData; //Field offset: 0x80
	private CircleOfCultistsBehaviour _cultistsBehaviour; //Field offset: 0x88
	private ItemSelectionCell[] _selectionCells; //Field offset: 0x90
	private readonly Dictionary _selectedItems; //Field offset: 0x98

	public CircleOfCultistsPanel() { }

	private bool CanSelect(ItemSelectionCell itemView, Item item) { }

	private void OnItemSelectionChanged(ItemSelectionCell sender, Item selectedItem) { }

	public void Show(InventoryController inventoryController, AreaData areaData, IEftSession session) { }

}

