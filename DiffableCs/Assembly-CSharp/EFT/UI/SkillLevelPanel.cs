namespace EFT.UI;

public sealed class SkillLevelPanel : UIElement
{
	[SerializeField]
	private GameObject _eliteIcon; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _level; //Field offset: 0x78

	public SkillLevelPanel() { }

	public void SetLevel(Skill skill) { }

}

