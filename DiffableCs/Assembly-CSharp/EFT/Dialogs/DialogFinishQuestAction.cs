namespace EFT.Dialogs;

public class DialogFinishQuestAction : DialogQuestAction
{

	public override bool Generated
	{
		 get { } //Length: 3
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogFinishQuestAction() { }

	public override bool get_Generated() { }

	public virtual EActionType get_Type() { }

	public virtual string ToString() { }

}

