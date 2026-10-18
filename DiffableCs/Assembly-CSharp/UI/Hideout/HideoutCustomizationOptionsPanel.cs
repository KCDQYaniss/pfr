namespace UI.Hideout;

public abstract class HideoutCustomizationOptionsPanel : UIElement
{
	private sealed class TabController : SimpleTabController
	{
		private readonly HideoutCustomizationOptionsPanel _screen; //Field offset: 0x10
		private readonly HideoutCustomizationCell _selfCell; //Field offset: 0x18

		public TabController(HideoutCustomizationOptionsPanel screen, HideoutCustomizationCell selfCell) { }

		public virtual void Show() { }

	}

	private const int MAX_CELLS_IN_A_ROW = 5; //Field offset: 0x0
	[SerializeField]
	private HideoutCustomizationCell _cellTemplate; //Field offset: 0x70
	[SerializeField]
	private GameObject _cellsRowContainerTemplate; //Field offset: 0x78
	[SerializeField]
	protected GameObject _allCellsContainer; //Field offset: 0x80
	[SerializeField]
	protected TMP_Text _header; //Field offset: 0x88
	protected HideoutCustomizationIcons _icons; //Field offset: 0x90
	private TabGroup _tabs; //Field offset: 0x98
	protected List _cells; //Field offset: 0xA0
	protected Action _slotClickHandler; //Field offset: 0xA8
	private HideoutCustomizationController _customizationController; //Field offset: 0xB0

	protected HideoutCustomizationOptionsPanel() { }

	public virtual void Close() { }

	protected HideoutCustomizationCell CreateCell(Dictionary offerSlotAssociations, GameObject currentCellsRow, string spriteId, string areaName, bool isLocked, Nullable cellNumber = null) { }

	protected GameObject CreateNewCellsRowIfNeeded(GameObject currentCellsRow) { }

	protected void CreateTabGroup(Tab initialTab) { }

	protected override void OnCellSelected(HideoutCustomizationCell selectedCell) { }

}

