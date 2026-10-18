namespace EFT.UI.Quests;

public sealed class MainQuestNotificationView : BaseNotificationView, INotificationView
{
	[SerializeField]
	[Space]
	private CustomTextMeshProUGUI _title; //Field offset: 0xE8
	[SerializeField]
	[Space]
	private Image _checkmarkIcon; //Field offset: 0xF0
	[SerializeField]
	[Space]
	private Sprite _chapterBackgroundSprite; //Field offset: 0xF8
	[SerializeField]
	private Sprite _subtaskBackgroundSprite; //Field offset: 0x100
	[SerializeField]
	[Space]
	private Sprite _checkmarkStartedSprite; //Field offset: 0x108
	[SerializeField]
	private Sprite _checkmarkSuccessSprite; //Field offset: 0x110
	[SerializeField]
	private Sprite _checkmarkFailSprite; //Field offset: 0x118

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public MainQuestNotificationView() { }

	public virtual bool get_ReturnToPool() { }

	public override void Init(NotificationMainQuest notification) { }

}

