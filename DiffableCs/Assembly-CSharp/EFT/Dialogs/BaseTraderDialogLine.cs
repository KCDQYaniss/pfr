namespace EFT.Dialogs;

public abstract class BaseTraderDialogLine
{
	[CompilerGenerated]
	private Action OnRedrawDialog; //Field offset: 0x10
	public bool IsActiveAndInteractive; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IDialogContext <Context>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly DialogLineTemplate <Template>k__BackingField; //Field offset: 0x28

	public event Action OnRedrawDialog
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override IReadOnlyList Actions
	{
		 get { } //Length: 27
	}

	public CombinedAnimationData AnimationData
	{
		 get { } //Length: 27
	}

	protected IDialogContext Context
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EDialogSide DialogSide
	{
		 get { } //Length: 26
	}

	public Sprite Icon
	{
		 get { } //Length: 134
	}

	protected override EDialogLineIconType IconType
	{
		 get { } //Length: 26
	}

	public abstract DialogLineTextConstructor LineTextConstructor
	{
		 get { } //Length: 0
	}

	public string SpeakerName
	{
		 get { } //Length: 444
	}

	public DialogLineTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected BaseTraderDialogLine(DialogLineTemplate template, IDialogContext context) { }

	[CompilerGenerated]
	public void add_OnRedrawDialog(Action value) { }

	public void Execute() { }

	protected override void ExecuteInternal() { }

	public override IReadOnlyList get_Actions() { }

	public CombinedAnimationData get_AnimationData() { }

	[CompilerGenerated]
	protected IDialogContext get_Context() { }

	public EDialogSide get_DialogSide() { }

	public Sprite get_Icon() { }

	protected override EDialogLineIconType get_IconType() { }

	public abstract DialogLineTextConstructor get_LineTextConstructor() { }

	public string get_SpeakerName() { }

	[CompilerGenerated]
	public DialogLineTemplate get_Template() { }

	[CompilerGenerated]
	public void remove_OnRedrawDialog(Action value) { }

}

