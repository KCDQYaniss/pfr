namespace EFT.UI.Prestige;

[UsedImplicitly]
public sealed class PrestigeLevelView : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	private PrestigeTemplate _prestigeLevel; //Field offset: 0x78
	private readonly BindableEvent _onClick; //Field offset: 0x80
	private readonly BindableState _selectionState; //Field offset: 0x88

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public PrestigeLevelView() { }

	public IBindableEvent get_OnClick() { }

	private void SelectionStateHandler(bool selected) { }

	public void SetCurrentLevel(PrestigeTemplate prestigeLevel) { }

	public void Show(PrestigeTemplate prestigeLevel, IImageLoader session) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

}

