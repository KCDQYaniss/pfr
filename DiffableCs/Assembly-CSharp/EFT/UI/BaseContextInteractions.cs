namespace EFT.UI;

public class BaseContextInteractions
{
	[CompilerGenerated]
	private static Action OnGlobalRedrawRequired; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnGlobalCloseRequired; //Field offset: 0x8

	protected static event Action OnGlobalCloseRequired
	{
		[CompilerGenerated]
		 add { } //Length: 269
		[CompilerGenerated]
		 remove { } //Length: 269
	}

	protected static event Action OnGlobalRedrawRequired
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public BaseContextInteractions() { }

	[CompilerGenerated]
	protected static void add_OnGlobalCloseRequired(Action value) { }

	[CompilerGenerated]
	protected static void add_OnGlobalRedrawRequired(Action value) { }

	[CompilerGenerated]
	protected static void remove_OnGlobalCloseRequired(Action value) { }

	[CompilerGenerated]
	protected static void remove_OnGlobalRedrawRequired(Action value) { }

	public static void RequestGlobalClose() { }

	public static void RequestGlobalRedraw() { }

}

