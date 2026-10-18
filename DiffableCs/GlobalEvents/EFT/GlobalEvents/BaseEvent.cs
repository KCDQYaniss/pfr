namespace EFT.GlobalEvents;

public abstract class BaseEvent : IEvent
{
	[CompilerGenerated]
	private static Action InvokeAction; //Field offset: 0x0
	public int ID; //Field offset: 0x10

	public static event Action InvokeAction
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	protected BaseEvent() { }

	[CompilerGenerated]
	public static void add_InvokeAction(Action value) { }

	public override void Invoke() { }

	public override void ParseParams(Dictionary data) { }

	[CompilerGenerated]
	public static void remove_InvokeAction(Action value) { }

	public abstract void Reset() { }

}

