namespace System.Reflection.Emit;

[ComVisible(True)]
[IsReadOnly]
public struct Label : IEquatable
{
	internal readonly int label; //Field offset: 0x0

	public virtual bool Equals(object obj) { }

	public override bool Equals(Label obj) { }

	public virtual int GetHashCode() { }

}

