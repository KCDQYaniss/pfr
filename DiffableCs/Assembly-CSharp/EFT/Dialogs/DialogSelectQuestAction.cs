namespace EFT.Dialogs;

public sealed class DialogSelectQuestAction : DialogQuestAction
{

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogSelectQuestAction() { }

	public DialogSelectQuestAction(string questId) { }

	public virtual EActionType get_Type() { }

	public virtual string ToString() { }

}

