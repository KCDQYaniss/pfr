namespace EFT.UI.Chat;

public sealed class ChatMessageSendBlock : UIElement
{
	[SerializeField]
	private DefaultUIButton _receiveAllButton; //Field offset: 0x70
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x78
	[SerializeField]
	private GameObject _enterMessagePanel; //Field offset: 0x80
	[SerializeField]
	private GameObject _messageSendBlockPanel; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _messageBlockLabel; //Field offset: 0x90
	private UpdatableChatDialogue _dialogue; //Field offset: 0x98
	private Action _onTransferAll; //Field offset: 0xA0
	private float _nextCheckTime; //Field offset: 0xA8
	private UpdatableBindableList _friendsList; //Field offset: 0xB0

	public ChatMessageSendBlock() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	private void Awake() { }

	private void CalculateEndStorageTime(DialogueChatMessage message) { }

	public void CloseMessageSendBlock(UpdatableChatDialogue dialogue) { }

	private void DisableBlock() { }

	private void EnableBlock() { }

	private void LastMessageUpdatedHandler(KeyValuePair dialogue) { }

	public void Show(UpdatableBindableList friendsList, BindableEvent onLastMessageUpdatedGlobal, UpdatableChatDialogue selectedDialogue, UpdatableChatDialogue dialogue, Action onTransferAll) { }

	private void Update() { }

	private void UpdateInputField() { }

	private void UpdateRewards() { }

}

