namespace EFT.Dialogs;

public sealed class DialogLineTextConstructor : IDialogLineConstructor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ETraderServiceType selectedService; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetSubServiceDealDescription>b__0(KeyValuePair x) { }

	}

	private interface IDialogLineConstructor
	{

		public string GetDialogLine() { }

		public string GetDialogLineKey() { }

		public string GetFirstPersonPhrase() { }

	}

	private static readonly Regex _tagRegex; //Field offset: 0x0
	private readonly string _lineKey; //Field offset: 0x10
	private readonly string _firstPersonKey; //Field offset: 0x18
	private readonly IDialogLineConstructor _formatTextConstructor; //Field offset: 0x20
	private readonly bool _isTextLocalized; //Field offset: 0x28
	private readonly IDialogContext _context; //Field offset: 0x30

	private static DialogLineTextConstructor() { }

	public DialogLineTextConstructor(string lineKey, IDialogContext context, string firstPersonKey = null, bool isTextLocalized = true) { }

	private DialogLineTextConstructor(DialogLineTextConstructor source, DialogLineTextConstructor formatTextConstructor) { }

	[CompilerGenerated]
	private string <ResolveTags>b__11_0(Match match) { }

	public DialogLineTextConstructor Format(DialogLineTextConstructor format) { }

	private static string Format(string formatString, string value) { }

	public override string GetDialogLine() { }

	public override string GetDialogLineKey() { }

	public override string GetFirstPersonPhrase() { }

	private static string GetSubServiceDealDescription(IDialogContext context) { }

	private string ResolveTags(string text) { }

	private string ResolveTagValue(string tagName) { }

}

