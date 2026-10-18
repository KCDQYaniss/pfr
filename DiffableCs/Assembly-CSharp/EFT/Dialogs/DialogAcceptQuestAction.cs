namespace EFT.Dialogs;

public sealed class DialogAcceptQuestAction : DialogQuestAction
{

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogAcceptQuestAction() { }

	public DialogAcceptQuestAction(string questId) { }

	public virtual EActionType get_Type() { }

	public virtual string ToString() { }

}

