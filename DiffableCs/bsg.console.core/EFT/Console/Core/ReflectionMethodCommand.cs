namespace EFT.Console.Core;

public class ReflectionMethodCommand : SyncCommand, ICustomPrintCommand
{
	private Action _method; //Field offset: 0x18
	protected ConsoleProcessor _processor; //Field offset: 0x20
	protected Func _originalInput; //Field offset: 0x28
	[CompilerGenerated]
	private readonly object[] <ArgumentsValue>k__BackingField; //Field offset: 0x30

	public virtual object[] ArgumentsValue
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public ReflectionMethodCommand(Func originalInput, Action method, object[] pars) { }

	public virtual void Execute() { }

	[CompilerGenerated]
	public virtual object[] get_ArgumentsValue() { }

	public override string PrintCommand() { }

}

