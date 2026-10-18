namespace EFT.UI.Seasons;

public abstract class BattlePassBaseItemView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _activeIcon; //Field offset: 0x70
	[SerializeField]
	private Image _inactiveIcon; //Field offset: 0x78
	[SerializeField]
	private Color32 _completeColor; //Field offset: 0x80
	[SerializeField]
	private Color32 _incompleteColor; //Field offset: 0x84
	[SerializeField]
	private TMP_Text _countField; //Field offset: 0x88
	[SerializeField]
	private List _completeObjects; //Field offset: 0x90
	[SerializeField]
	private List _incompleteObjects; //Field offset: 0x98
	private BattlePassDocumentScheme _document; //Field offset: 0xA0
	private IImageLoader _imageLoader; //Field offset: 0xA8
	private SimpleTooltip _tooltip; //Field offset: 0xB0
	private CancellationToken _tooltipCloseToken; //Field offset: 0xB8
	[CompilerGenerated]
	private BattlePassController <Controller>k__BackingField; //Field offset: 0xC0

	protected private BattlePassController Controller
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BattlePassBaseItemView() { }

	[CompilerGenerated]
	private void <ShowInternal>g__ItemsCountHandler|15_0(BattlePassItem changedItem) { }

	private void CloseTooltip() { }

	[CompilerGenerated]
	protected BattlePassController get_Controller() { }

	protected abstract string GetCountText(int itemsCount) { }

	protected override int GetItemsCount() { }

	protected abstract bool IsActive(int itemsCount) { }

	protected void ItemsChangedHandler() { }

	[CompilerGenerated]
	private void set_Controller(BattlePassController value) { }

	protected void ShowInternal(BattlePassDocumentScheme document, BattlePassController controller, IImageLoader imageLoader) { }

	private void ShowTooltip() { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData _) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData _) { }

}

