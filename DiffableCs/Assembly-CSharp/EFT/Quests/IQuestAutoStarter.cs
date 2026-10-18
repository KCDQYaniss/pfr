namespace EFT.Quests;

public interface IQuestAutoStarter
{

	public event Action OnQuestAutoStartCondition
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnQuestAutoStartCondition(Action value) { }

	public void Connect() { }

	public void Disconnect() { }

	[CompilerGenerated]
	public void remove_OnQuestAutoStartCondition(Action value) { }

}

