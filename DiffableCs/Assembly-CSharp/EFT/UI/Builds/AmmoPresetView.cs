namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class AmmoPresetView : UIElement, IItemSelectionHandler, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler
{
	private readonly BindableEvent _onItemSelected; //Field offset: 0x70
	private readonly BindableEvent _onCountChanged; //Field offset: 0x78
	private readonly BindableEvent _onMoveUp; //Field offset: 0x80
	private readonly BindableEvent _onMoveDown; //Field offset: 0x88
	[SerializeField]
	private Sprite _topIcon; //Field offset: 0x90
	[SerializeField]
	private Sprite _loopIcon; //Field offset: 0x98
	[SerializeField]
	private Sprite _bottomIcon; //Field offset: 0xA0
	[SerializeField]
	private Image _compositionImage; //Field offset: 0xA8
	[SerializeField]
	private GameObject _hoverObject; //Field offset: 0xB0
	[SerializeField]
	private GameObject _ammoSelectedBack; //Field offset: 0xB8
	[SerializeField]
	private TMP_InputField _countInputField; //Field offset: 0xC0
	[SerializeField]
	private Button _decrementButton; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _decrementLocker; //Field offset: 0xD0
	[SerializeField]
	private Button _incrementButton; //Field offset: 0xD8
	[SerializeField]
	private CanvasGroup _incrementLocker; //Field offset: 0xE0
	[SerializeField]
	private ItemSelectionCell _ammoSelector; //Field offset: 0xE8
	[SerializeField]
	private TMP_Text _ammoName; //Field offset: 0xF0
	[SerializeField]
	private CanvasGroup _countContainer; //Field offset: 0xF8
	[SerializeField]
	private Button _moveUpButton; //Field offset: 0x100
	[SerializeField]
	private CanvasGroup _moveUpLocker; //Field offset: 0x108
	[SerializeField]
	private Button _moveDownButton; //Field offset: 0x110
	[SerializeField]
	private CanvasGroup _moveDownLocker; //Field offset: 0x118
	[CanBeNull]
	private MagPresetItem _presetItem; //Field offset: 0x120
	[CanBeNull]
	private Item _selectedItem; //Field offset: 0x128
	private IEnumerable _availableAmmo; //Field offset: 0x130
	private bool _hover; //Field offset: 0x138
	private CompositeDisposable _itemDisposable; //Field offset: 0x140

	public IBindableEvent OnCountChanged
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnItemSelected
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnMoveDown
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnMoveUp
	{
		 get { } //Length: 8
	}

	public AmmoPresetView() { }

	[CompilerGenerated]
	private void <SetPresetItem>b__36_0() { }

	private void AmmoCountChangeHandler(string newCountText) { }

	public virtual void Close() { }

	private void CountChangeHandler() { }

	private void DecrementClickHandler() { }

	private override bool EFT.UI.ItemSelectionCell.IItemSelectionHandler.CanSelect(Item item) { }

	private override IEnumerable EFT.UI.ItemSelectionCell.IItemSelectionHandler.GetAvailableItems() { }

	private override void EFT.UI.ItemSelectionCell.IItemSelectionHandler.ItemSelectionHandler(Item selectedItem) { }

	public IBindableEvent get_OnCountChanged() { }

	public IBindableEvent get_OnItemSelected() { }

	public IBindableEvent get_OnMoveDown() { }

	public IBindableEvent get_OnMoveUp() { }

	private void IncrementClickHandler() { }

	private void MoveDownHandler() { }

	private void MoveUpHandler() { }

	[UsedImplicitly]
	private void OnDisable() { }

	private void SetHoverState(bool hover) { }

	private void SetPresetItem(MagPresetItem item) { }

	public void Show(MagPreset preset, int ammoIndex, MagBuildsStorage storage, IEnumerable availableAmmo) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void UpdateCountGroup(int newCount) { }

}

