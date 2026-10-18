namespace EFT.Dialogs;

public sealed class DialogQuestRewardAction : DialogQuestAction
{
	[JsonProperty("reward")]
	public readonly QuestReward Reward; //Field offset: 0x40

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogQuestRewardAction(QuestReward reward) { }

	public virtual EActionType get_Type() { }

}

