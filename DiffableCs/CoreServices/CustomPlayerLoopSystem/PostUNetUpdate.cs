namespace CustomPlayerLoopSystem;

[Obfuscation(Exclude = True)]
public struct PostUNetUpdate
{
	[CompilerGenerated]
	private static class <>O
	{
		public static UpdateFunction <0>__UpdateFunction; //Field offset: 0x0

	}

	[CompilerGenerated]
	private static Action OnUpdate; //Field offset: 0x0

	public static event Action OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	[CompilerGenerated]
	public static void add_OnUpdate(Action value) { }

	public static PlayerLoopSystem GetNewSystem() { }

	[CompilerGenerated]
	public static void remove_OnUpdate(Action value) { }

	private static void UpdateFunction() { }

}

