namespace System.Dynamic;

public sealed class CallInfo
{
	[CompilerGenerated]
	private readonly int <ArgumentCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection <ArgumentNames>k__BackingField; //Field offset: 0x18

	public int ArgumentCount
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public ReadOnlyCollection ArgumentNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CallInfo(int argCount, IEnumerable argNames) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_ArgumentCount() { }

	[CompilerGenerated]
	public ReadOnlyCollection get_ArgumentNames() { }

	public virtual int GetHashCode() { }

}

