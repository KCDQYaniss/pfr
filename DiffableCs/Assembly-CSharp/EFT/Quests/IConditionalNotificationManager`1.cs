namespace EFT.Quests;

public interface IConditionalNotificationManager`1
{

	public IImageLoader ImageLoader
	{
		 get { } //Length: 0
	}

	public IImageLoader get_ImageLoader() { }

	public void NotifyConditionalStatusChanged(TConditional quest) { }

	public void NotifyConditionChanged(TConditional quest) { }

	public void NotifyReward(TConditional quest, EQuestStatus status) { }

}

