namespace EFT.UI;

public abstract class ContextInteractions`1 : BaseContextInteractions
{
	private static readonly IEnumerable _allInteractions; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnRedrawRequired; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnCloseRequired; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IEnumerable <SubInteractions>k__BackingField; //Field offset: 0x0
	protected readonly ItemUiContext UIContext; //Field offset: 0x0
	private readonly Dictionary _dynamicInteractions; //Field offset: 0x0

	public event Action OnCloseRequired
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnRedrawRequired
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override IEnumerable AllInteractions
	{
		 get { } //Length: 119
	}

	public override Dictionary CustomNames
	{
		 get { } //Length: 3
	}

	public IEnumerable DynamicInteractions
	{
		 get { } //Length: 73
	}

	public override bool ExaminationRequired
	{
		 get { } //Length: 3
	}

	public override bool HasIcons
	{
		 get { } //Length: 3
	}

	public override bool HasInteractions
	{
		 get { } //Length: 3
	}

	protected override IEnumerable SubInteractions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static ContextInteractions`1() { }

	protected ContextInteractions`1(ItemUiContext uiContext) { }

	[CompilerGenerated]
	private void <SubscribeOnClose>b__32_0() { }

	[CompilerGenerated]
	private void <SubscribeOnRedraw>b__30_0() { }

	[CompilerGenerated]
	public void add_OnCloseRequired(Action value) { }

	[CompilerGenerated]
	public void add_OnRedrawRequired(Action value) { }

	protected void AddDynamicInteraction(string id, string key, Action callback, Sprite icon = null, Enum buttonType = null, string error = null) { }

	public override void CreateSubInteractions(T parentInteraction, ISubInteractionsWrapper subInteractionsWrapper) { }

	public bool ExecuteDynamicInteraction(string dynamicInteraction) { }

	public bool ExecuteInteraction(T interaction) { }

	protected abstract void ExecuteInteractionInternal(T interaction) { }

	public override IEnumerable get_AllInteractions() { }

	public override Dictionary get_CustomNames() { }

	public IEnumerable get_DynamicInteractions() { }

	public override bool get_ExaminationRequired() { }

	public override bool get_HasIcons() { }

	public override bool get_HasInteractions() { }

	[CompilerGenerated]
	protected override IEnumerable get_SubInteractions() { }

	public bool HasSubInteractions(T interaction) { }

	public abstract bool IsActive(T button) { }

	public IResult IsInteractionAvailable(T interaction) { }

	public abstract IResult IsInteractive(T button) { }

	[CompilerGenerated]
	public void remove_OnCloseRequired(Action value) { }

	[CompilerGenerated]
	public void remove_OnRedrawRequired(Action value) { }

	protected void RemoveDynamicInteraction(string key) { }

	protected void RequestClose() { }

	protected void RequestRedraw() { }

	public override Action SubscribeOnClose() { }

	public override Action SubscribeOnRedraw() { }

	public override bool TryGetCustomIcon(T key, out Sprite icon) { }

}

