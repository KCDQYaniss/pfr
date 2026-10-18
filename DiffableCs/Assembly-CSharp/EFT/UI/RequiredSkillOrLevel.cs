namespace EFT.UI;

public class RequiredSkillOrLevel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x70

	public RequiredSkillOrLevel() { }

	public void Show(string text, bool available, Color goodColor, Color badColor, Sprite icon = null, float textWidth = -1) { }

}

