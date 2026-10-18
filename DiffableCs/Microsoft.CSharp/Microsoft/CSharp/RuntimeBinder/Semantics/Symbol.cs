namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class Symbol
{
	private SYMKIND _kind; //Field offset: 0x10
	private ACCESS _access; //Field offset: 0x14
	public Name name; //Field offset: 0x18
	public ParentSymbol parent; //Field offset: 0x20
	public Symbol nextChild; //Field offset: 0x28
	public Symbol nextSameName; //Field offset: 0x30

	public bool isStatic
	{
		 get { } //Length: 319
	}

	protected Symbol() { }

	public bool get_isStatic() { }

	public ACCESS GetAccess() { }

	private Assembly GetAssembly() { }

	public SYMKIND getKind() { }

	public CType getType() { }

	private bool InternalsVisibleTo(Assembly assembly) { }

	public bool IsHideByName() { }

	public bool IsOverride() { }

	public bool isUserCallable() { }

	public Symbol LookupNext(symbmask_t kindmask) { }

	public symbmask_t mask() { }

	public bool SameAssemOrFriend(Symbol sym) { }

	public void SetAccess(ACCESS access) { }

	public void setKind(SYMKIND kind) { }

}

