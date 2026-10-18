namespace EFT.Dialogs;

public class TraderDialogTextLine : BaseTraderDialogLine
{
	private readonly DialogMainConditionGroup _trigger; //Field offset: 0x30
	[CompilerGenerated]
	private readonly DialogLineTextConstructor <LineTextConstructor>k__BackingField; //Field offset: 0x38

	public virtual DialogLineTextConstructor LineTextConstructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TraderDialogTextLine(DialogLineTemplate template, IDialogContext dialogContext, DialogLineTextConstructor lineTextConstructor = null) { }

	[CompilerGenerated]
	public virtual DialogLineTextConstructor get_LineTextConstructor() { }

}

