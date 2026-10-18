namespace EFT.UI;

public sealed class DogtagPreviewContextInteractions : BaseItemContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__8_0; //Field offset: 0x8
		public static Predicate <>9__8_1; //Field offset: 0x10
		public static Func <>9__8_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CreateAlivePreview>b__8_0(ItemAttribute attribute) { }

		internal bool <CreateAlivePreview>b__8_1(ItemAttribute attribute) { }

		internal string <CreateAlivePreview>b__8_2() { }

	}

	private static readonly IEnumerable _interactions; //Field offset: 0x0
	private readonly Action _closeAction; //Field offset: 0x60

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	public virtual bool ExaminationRequired
	{
		 get { } //Length: 3
	}

	private static DogtagPreviewContextInteractions() { }

	public DogtagPreviewContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction) { }

	private static Item CreateAlivePreview(Item source, Profile profile) { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	public virtual bool get_ExaminationRequired() { }

}

