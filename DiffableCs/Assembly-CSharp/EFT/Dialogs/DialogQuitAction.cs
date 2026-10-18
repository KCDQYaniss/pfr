namespace EFT.Dialogs;

public sealed class DialogQuitAction : DialogNotifiedAction
{

	public virtual bool IsQuitAction
	{
		 get { } //Length: 3
	}

	public virtual bool Queued
	{
		 get { } //Length: 3
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogQuitAction() { }

	public virtual bool get_IsQuitAction() { }

	public virtual bool get_Queued() { }

	public virtual EActionType get_Type() { }

}

