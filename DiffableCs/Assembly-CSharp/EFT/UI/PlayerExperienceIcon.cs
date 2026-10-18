namespace EFT.UI;

public class PlayerExperienceIcon : MonoBehaviour
{
	public const string SINGLE_HOVER = "Lobby/PlayerBonusTooltip{0}{1}"; //Field offset: 0x0
	public const string GROUP_HOVER = "Matchmaker/GroupBonusTooltip{0}{1}{2}"; //Field offset: 0x0
	public const string GREEN_TEAM_LINE = "Lobby/GreenTeamBonusTooltip{0}"; //Field offset: 0x0
	public const string GREEN_TEAM_SECTION = "MatchEnd/GreenTeamExpBonus"; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x20
	[SerializeField]
	private HoverTooltipArea _hover; //Field offset: 0x28
	[SerializeField]
	private Sprite _commonSprite; //Field offset: 0x30
	[SerializeField]
	private Sprite _goldSprite; //Field offset: 0x38

	public PlayerExperienceIcon() { }

	public static string BuildTooltip(bool hasEditionBonus, string gameVersion, int editionPercent, int referralPercent, string groupPlayerName = null) { }

	public void Setup(bool hasBonus, string gameVersion, int bonusValue) { }

	public void Setup(bool hasEditionBonus, string gameVersion, int editionPercent, int referralPercent) { }

}

