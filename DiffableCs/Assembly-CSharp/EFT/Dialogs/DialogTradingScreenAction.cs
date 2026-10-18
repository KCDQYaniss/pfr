namespace EFT.Dialogs;

public sealed class DialogTradingScreenAction : DialogNotifiedAction
{

	public virtual bool IsQuitAction
	{
		 get { } //Length: 3
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public DialogTradingScreenAction() { }

	public virtual bool get_IsQuitAction() { }

	public virtual EActionType get_Type() { }

}

