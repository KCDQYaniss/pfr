namespace EFT.UI.Chat;

public class ChatFriendsPanel : UIElement, IPointerClickHandler, IEventSystemHandler
{
	private const int REQUEST_COOLDOWN = 1; //Field offset: 0x0
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x70
	[SerializeField]
	private FriendsListContentButton _friendsButton; //Field offset: 0x78
	[SerializeField]
	private FriendsListContentButton _requestsButton; //Field offset: 0x80
	[SerializeField]
	private FriendsListContentButton _steamButton; //Field offset: 0x88
	[SerializeField]
	private ChatFriendsListPanel _chatFriendsListPanel; //Field offset: 0x90
	[SerializeField]
	private ChatFriendsRequestsPanel _chatFriendsRequestsPanel; //Field offset: 0x98
	[SerializeField]
	private ChatFriendsSteamPanel _chatFriendsSteamPanel; //Field offset: 0xA0
	[SerializeField]
	private Button _closeButton; //Field offset: 0xA8
	[SerializeField]
	private GameObject _loader; //Field offset: 0xB0
	[SerializeField]
	private GameObject _searchIcon; //Field offset: 0xB8
	[SerializeField]
	private ValidationInputField _friendsInputField; //Field offset: 0xC0
	[SerializeField]
	private ChatMembersPanel _chatMembersPanel; //Field offset: 0xC8
	private SocialNetwork _social; //Field offset: 0xD0
	private bool _startCounting; //Field offset: 0xD8
	private float _ticks; //Field offset: 0xDC

	public ChatFriendsPanel() { }

	[CompilerGenerated]
	private void <Awake>b__16_0() { }

	[CompilerGenerated]
	private void <Awake>b__16_1() { }

	[CompilerGenerated]
	private void <Awake>b__16_2() { }

	[CompilerGenerated]
	private void <Awake>b__16_3(string arg) { }

	[CompilerGenerated]
	private void <Update>b__18_0() { }

	private void Awake() { }

	public virtual void Close() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void SetLoadingProcess(bool status) { }

	private void SetPriority() { }

	public void Show(SocialNetwork social) { }

	private void Update() { }

}

