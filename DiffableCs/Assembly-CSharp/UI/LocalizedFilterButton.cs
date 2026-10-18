namespace UI;

public class LocalizedFilterButton : UIElement
{
	[SerializeField]
	private Button _button; //Field offset: 0x70
	[SerializeField]
	private string _localizationKey; //Field offset: 0x78

	public string LocalizationKey
	{
		 get { } //Length: 5
	}

	public ButtonClickedEvent OnClick
	{
		 get { } //Length: 30
	}

	public LocalizedFilterButton() { }

	public string get_LocalizationKey() { }

	public ButtonClickedEvent get_OnClick() { }

}

