namespace System.Linq.Expressions.Interpreter;

internal sealed class IntSwitchInstruction`1 : Instruction
{
	private readonly Dictionary _cases; //Field offset: 0x0

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 49
	}

	internal IntSwitchInstruction`1(Dictionary cases) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

