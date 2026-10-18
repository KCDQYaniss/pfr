namespace System.Linq.Expressions.Interpreter;

internal abstract class OffsetInstruction : Instruction
{
	protected int _offset; //Field offset: 0x10

	public abstract Instruction[] Cache
	{
		 get { } //Length: 0
	}

	protected OffsetInstruction() { }

	public Instruction Fixup(int offset) { }

	public abstract Instruction[] get_Cache() { }

	public virtual string ToDebugString(int instructionIndex, object cookie, Func labelIndexer, IReadOnlyList objects) { }

	public virtual string ToString() { }

}

