namespace EFT.Dialogs;

public sealed class EmbeddedDynamicTraderDialog : DynamicTraderDialog
{

	protected virtual bool CanBeEmpty
	{
		 get { } //Length: 3
	}

	public EmbeddedDynamicTraderDialog(TraderDialogTemplate template, IDialogContext context) { }

	protected virtual bool get_CanBeEmpty() { }

}

