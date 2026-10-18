namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadCachedObjectInstruction : Instruction
{
	private readonly uint _index; //Field offset: 0x10

	public virtual string InstructionName
	{
		 get { } //Length: 49
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	internal LoadCachedObjectInstruction(uint index) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToDebugString(int instructionIndex, object cookie, Func labelIndexer, IReadOnlyList objects) { }

	public virtual string ToString() { }

}

