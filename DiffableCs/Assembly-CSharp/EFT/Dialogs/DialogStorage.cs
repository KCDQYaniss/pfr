namespace EFT.Dialogs;

public sealed class DialogStorage
{
	[CompilerGenerated]
	private static readonly DialogStorage <Instance>k__BackingField; //Field offset: 0x0
	private readonly Dictionary _dialogTemplates; //Field offset: 0x10

	public static DialogStorage Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static DialogStorage() { }

	public DialogStorage() { }

	public void AddTemplate(TraderDialogTemplate template) { }

	public void AddTemplates(IEnumerable templates) { }

	public void Clear() { }

	[CompilerGenerated]
	public static DialogStorage get_Instance() { }

	public TraderDialogTemplate GetTemplate(MongoID dialogId) { }

	public bool TryGetTemplate(MongoID dialogId, out TraderDialogTemplate template) { }

}

