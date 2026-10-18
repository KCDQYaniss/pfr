namespace EFT.UI;

public sealed class SkillClassIcon : UIElement
{
	private static readonly Dictionary SkillClassColors; //Field offset: 0x0
	private static readonly Dictionary SkillClassNames; //Field offset: 0x8
	[SerializeField]
	private Image _background; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _symbol; //Field offset: 0x78

	private static SkillClassIcon() { }

	public SkillClassIcon() { }

	public void Set(ESkillClass skillClass) { }

}

