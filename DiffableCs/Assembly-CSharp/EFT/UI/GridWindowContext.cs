namespace EFT.UI;

public sealed class GridWindowContext : WindowContext
{
	[CompilerGenerated]
	private Action OnSelectedAsTarget; //Field offset: 0x20

	public event Action OnSelectedAsTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public GridWindowContext() { }

	[CompilerGenerated]
	public void add_OnSelectedAsTarget(Action value) { }

	public static bool CanSelectGridWindow(ItemContext itemContext) { }

	[CompilerGenerated]
	public void remove_OnSelectedAsTarget(Action value) { }

	public void SetSelectedAsTarget(bool status) { }

}

