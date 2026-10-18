namespace EFT.UI;

public class PlayerNamePanel : MonoBehaviour
{
	public const string MAIN_CHARACTER_DESCRIPTION = "YOUR MAIN CHARACTER"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _name; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0x28
	[SerializeField]
	private ChatSpecialIcon _icon; //Field offset: 0x30

	public PlayerNamePanel() { }

	public void Set(bool showDetails, EMemberCategory category, string nickname, int textSize = 23, int prestigeLevel = 0, EGameMode prestigeGameMode = 0) { }

	public void Set(Profile profile) { }

}

