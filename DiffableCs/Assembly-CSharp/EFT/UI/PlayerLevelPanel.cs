namespace EFT.UI;

public sealed class PlayerLevelPanel : MonoBehaviour
{
	private const int MAX_PLAYER_ICON_LEVEL = 80; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _level; //Field offset: 0x20
	[SerializeField]
	private Image _icon; //Field offset: 0x28

	public PlayerLevelPanel() { }

	public void Set(int level, ESideType side) { }

	public static void SetLevelIcon(Image image, int level) { }

}

