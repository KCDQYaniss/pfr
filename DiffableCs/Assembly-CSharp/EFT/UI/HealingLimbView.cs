namespace EFT.UI;

public class HealingLimbView : UIElement
{
	[SerializeField]
	private BodyPartView _bodyPartView; //Field offset: 0x70
	[SerializeField]
	private Image _background; //Field offset: 0x78

	public BodyPartView BodyPartView
	{
		 get { } //Length: 5
	}

	public HealingLimbView() { }

	public BodyPartView get_BodyPartView() { }

	public void SetBackgroundColor(Color color) { }

}

