namespace System.Reflection.Emit;

[ComVisible(True)]
[IsReadOnly]
public struct OpCode : IEquatable
{
	internal readonly byte op1; //Field offset: 0x0
	internal readonly byte op2; //Field offset: 0x1
	private readonly byte push; //Field offset: 0x2
	private readonly byte pop; //Field offset: 0x3
	private readonly byte size; //Field offset: 0x4
	private readonly byte type; //Field offset: 0x5
	private readonly byte args; //Field offset: 0x6
	private readonly byte flow; //Field offset: 0x7

	public string Name
	{
		 get { } //Length: 181
	}

	internal OpCode(int p, int q) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(OpCode obj) { }

	public string get_Name() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

