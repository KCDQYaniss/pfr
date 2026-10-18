namespace EFT.UI.Quests;

public sealed class QuestRewardNotificationView : BaseNotificationView, INotificationView
{
	[SerializeField]
	[Space]
	private CustomTextMeshProUGUI _title; //Field offset: 0xE8

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public QuestRewardNotificationView() { }

	public virtual bool get_ReturnToPool() { }

	protected virtual float GetHeight() { }

	public override void Init(NotificationQuestReward notification) { }

}

