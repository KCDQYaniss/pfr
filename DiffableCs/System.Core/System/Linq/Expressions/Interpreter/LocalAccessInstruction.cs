namespace System.Linq.Expressions.Interpreter;

internal abstract class LocalAccessInstruction : Instruction
{
	internal readonly int _index; //Field offset: 0x10

	protected LocalAccessInstruction(int index) { }

	public virtual string ToDebugString(int instructionIndex, object cookie, Func labelIndexer, IReadOnlyList objects) { }

}

