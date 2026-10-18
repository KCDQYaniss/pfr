namespace EFT.UI;

public class LocationTimeUIPanel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _timePanel; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private Sprite _sunriseIcon; //Field offset: 0x80
	[SerializeField]
	private Sprite _dayIcon; //Field offset: 0x88
	[SerializeField]
	private Sprite _nightIcon; //Field offset: 0x90
	private BattleUIComponentAnimation _animation; //Field offset: 0x98

	private DateTime GetCurrentTime
	{
		private get { } //Length: 75
	}

	public LocationTimeUIPanel() { }

	public virtual void Close() { }

	private DateTime get_GetCurrentTime() { }

	public void Hide() { }

	public void Initialize() { }

	public void Show() { }

	private void ShowTimeWithIcon(DateTime timeOfDay) { }

}

