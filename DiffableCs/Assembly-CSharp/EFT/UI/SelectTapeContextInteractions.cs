namespace EFT.UI;

public sealed class SelectTapeContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ItemUiContext uiContext; //Field offset: 0x10
		public RecorderItem recorder; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public TapeItem tape; //Field offset: 0x10
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass6_1() { }

		internal void <.ctor>b__0() { }

	}

	internal enum ESelectTapeInteraction
	{
		Default = 0,
		PlayTapeInRecorder = 1,
	}


	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	public SelectTapeContextInteractions(RecorderItem recorder, ItemUiContext uiContext) { }

	protected virtual void ExecuteInteractionInternal(ESelectTapeInteraction interaction) { }

	public virtual bool get_HasIcons() { }

	public virtual bool IsActive(ESelectTapeInteraction button) { }

	public virtual IResult IsInteractive(ESelectTapeInteraction button) { }

}

