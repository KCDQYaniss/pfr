namespace EFT.UI;

public class FilterButton : UIElement
{
	[SerializeField]
	protected Button _button; //Field offset: 0x70
	[SerializeField]
	protected Image _icon; //Field offset: 0x78
	[SerializeField]
	protected Sprite _on; //Field offset: 0x80
	[SerializeField]
	protected Sprite _off; //Field offset: 0x88

	public ButtonClickedEvent OnClicked
	{
		 get { } //Length: 30
	}

	public FilterButton() { }

	public void ApplyAscend() { }

	public void ApplyDescend() { }

	public ButtonClickedEvent get_OnClicked() { }

	public void HideIcon() { }

	public void Show() { }

	public void ShowIcon() { }

}

