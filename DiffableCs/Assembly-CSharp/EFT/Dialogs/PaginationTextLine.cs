namespace EFT.Dialogs;

public sealed class PaginationTextLine : TraderDialogTextLine
{
	private readonly Action _onExecute; //Field offset: 0x40

	public PaginationTextLine(DialogLineTemplate template, IDialogContext dialogContext, DialogLineTextConstructor lineTextConstructor, Action onExecute) { }

	public static BaseTraderDialogLine Create(BaseTraderDialogController dialogController, string textLocaleKey, EDialogLineIconType icon, Action onExecute) { }

	protected virtual void ExecuteInternal() { }

}

