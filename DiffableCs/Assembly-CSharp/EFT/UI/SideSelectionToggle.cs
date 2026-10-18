namespace EFT.UI;

public class SideSelectionToggle : Toggle
{
	[SerializeField]
	private EPlayerSide _side; //Field offset: 0x128
	[SerializeField]
	private AnimatedToggle _sideSelectionToggle; //Field offset: 0x130
	public readonly BindableEvent OnHover; //Field offset: 0x138
	private Action _onSelectedAction; //Field offset: 0x140

	public SideSelectionToggle() { }

	public void Init(Action onSelectedAction) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	private void OnToggleSelected(bool value) { }

}

