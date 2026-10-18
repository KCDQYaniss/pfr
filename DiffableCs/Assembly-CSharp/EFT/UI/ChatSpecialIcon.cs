namespace EFT.UI;

public sealed class ChatSpecialIcon : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _specialLabel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _accountLevelLabel; //Field offset: 0x78
	[SerializeField]
	private string _accountLevelMask; //Field offset: 0x80
	[SerializeField]
	private Image _icon; //Field offset: 0x88
	[SerializeField]
	private Image _iconPrestige; //Field offset: 0x90
	private ChatSpecialIconSettings _iconsSettings; //Field offset: 0x98

	public ChatSpecialIcon() { }

	public virtual void Close() { }

	public void Show(PlayerInfo playerInfo, bool isNameColored = true) { }

	public void Show(PlayerInfo playerInfo, string playerName, bool isNameColored = true, Nullable category = null) { }

	public void Show(UpdatableChatMemberInfo info) { }

	public void Show(EMemberCategory category, string playerName = null, bool isNameColored = true, int prestigeLevel = 0, int accountLevel = 0, EGameMode prestigeGameMode = 0) { }

}

