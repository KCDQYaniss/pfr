namespace EFT.Hideout;

[UsedImplicitly]
public sealed class RestSpaceGamePanel : UIElement
{
	[SerializeField]
	private GameObject _header; //Field offset: 0x70
	[SerializeField]
	private Transform _gameDiscSlotContainer; //Field offset: 0x78
	[SerializeField]
	private ItemSelectionCell _gameDiscSlotTemplate; //Field offset: 0x80
	[SerializeField]
	private DefaultUIButton _playButton; //Field offset: 0x88
	private RestSpaceBehaviour _restSpaceBehaviour; //Field offset: 0x90
	private ItemSelectionCell _gameDiscSlot; //Field offset: 0x98
	private Item _selectedGameDisc; //Field offset: 0xA0
	private AreaData _areaData; //Field offset: 0xA8

	private HideoutRepresentation HideoutRepresentation
	{
		private get { } //Length: 46
	}

	public RestSpaceGamePanel() { }

	[CompilerGenerated]
	private void <CreateGameDiscSlot>b__11_0() { }

	private bool CanSelectGameDisc(Item item) { }

	public virtual void Close() { }

	private void CreateGameDiscSlot() { }

	private HideoutRepresentation get_HideoutRepresentation() { }

	private void OnEnergyStatusChangedHandler(bool isEnergyOn) { }

	private void OnGameDiscInsertedHandler(Item gameDisc) { }

	private void OnGameDiscInSlotChangedHandler(Item gameDisc, int index) { }

	private void OnGameDiscRemovedHandler(Item gameDisc) { }

	private void OnGameDiscSelectionChanged(Item selectedGameDisc) { }

	private void OnPlayButtonClicked() { }

	public void Show(InventoryController inventoryController, AreaData areaData, IEftSession session) { }

	private void UpdateUI() { }

}

