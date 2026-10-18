namespace EFT.UI;

public class PlayerExperiencePanel : UIElement
{
	[SerializeField]
	private PlayerLevelPanel _currentLevel; //Field offset: 0x70
	[SerializeField]
	private PlayerLevelPanel _nextLevel; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _currentExperience; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _remainingExperience; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _newExperience; //Field offset: 0x90
	[SerializeField]
	private TwoValueBar _experienceBar; //Field offset: 0x98
	[SerializeField]
	private PlayerExperienceIcon _expIcon; //Field offset: 0xA0

	public PlayerExperiencePanel() { }

	public void Set(Profile profile, int baseTotal, int targetExperience, bool showMyGameEditionBonus = false) { }

}

