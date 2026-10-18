namespace EFT.UI;

public class LocationWarningPanel : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0x70

	public LocationWarningPanel() { }

	public void SetByLevel(bool unavailableByLevel, int minLocationLevel, int maxLocationLevel, int minPlayerLevel, int maxPlayerLevel) { }

	public void SetByRules(LocationRules rules) { }

}

