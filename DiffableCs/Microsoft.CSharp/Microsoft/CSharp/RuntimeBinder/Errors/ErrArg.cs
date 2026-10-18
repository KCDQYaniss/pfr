namespace Microsoft.CSharp.RuntimeBinder.Errors;

internal class ErrArg
{
	public ErrArgKind eak; //Field offset: 0x10
	public ErrArgFlags eaf; //Field offset: 0x14
	internal int n; //Field offset: 0x18
	internal SYMKIND sk; //Field offset: 0x1C
	internal Name name; //Field offset: 0x20
	internal Symbol sym; //Field offset: 0x28
	internal string psz; //Field offset: 0x30
	internal CType pType; //Field offset: 0x38
	internal MethPropWithInstMemo mpwiMemo; //Field offset: 0x40
	internal SymWithTypeMemo swtMemo; //Field offset: 0x48

	public ErrArg() { }

	public ErrArg(MethPropWithInst mpwi) { }

	private ErrArg(Symbol pSym, ErrArgFlags eaf) { }

	public ErrArg(Symbol pSym) { }

	public ErrArg(CType pType, ErrArgFlags eaf) { }

	public ErrArg(SymWithType swt) { }

	public ErrArg(string psz) { }

	public ErrArg(Name name) { }

	public ErrArg(int n) { }

	public ErrArg(CType pType) { }

	public static ErrArg op_Implicit(SymWithType swt) { }

	public static ErrArg op_Implicit(int n) { }

	public static ErrArg op_Implicit(CType type) { }

	public static ErrArg op_Implicit(string psz) { }

	public static ErrArg op_Implicit(Name name) { }

	public static ErrArg op_Implicit(Symbol pSym) { }

	public static ErrArg op_Implicit(MethPropWithInst mpwi) { }

}

