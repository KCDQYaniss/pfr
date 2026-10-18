namespace System.Linq.Expressions.Interpreter;

internal sealed class StringSwitchInstruction : Instruction
{
	private readonly Dictionary _cases; //Field offset: 0x10
	private readonly StrongBox _nullCase; //Field offset: 0x18

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 49
	}

	internal StringSwitchInstruction(Dictionary cases, StrongBox nullCase) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

