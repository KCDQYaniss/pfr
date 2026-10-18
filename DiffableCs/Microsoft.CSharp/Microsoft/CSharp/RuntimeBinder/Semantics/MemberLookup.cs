namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class MemberLookup
{
	private CType _typeSrc; //Field offset: 0x10
	private CType _typeQual; //Field offset: 0x18
	private ParentSymbol _symWhere; //Field offset: 0x20
	private Name _name; //Field offset: 0x28
	private int _arity; //Field offset: 0x30
	private MemLookFlags _flags; //Field offset: 0x34
	private readonly List _rgtypeStart; //Field offset: 0x38
	private List _prgtype; //Field offset: 0x40
	private int _csym; //Field offset: 0x48
	private readonly SymWithType _swtFirst; //Field offset: 0x50
	private readonly List _methPropWithTypeList; //Field offset: 0x58
	private readonly SymWithType _swtAmbig; //Field offset: 0x60
	private readonly SymWithType _swtInaccess; //Field offset: 0x68
	private readonly SymWithType _swtBad; //Field offset: 0x70
	private readonly SymWithType _swtBogus; //Field offset: 0x78
	private readonly SymWithType _swtBadArity; //Field offset: 0x80
	private bool _fMulti; //Field offset: 0x88

	public MemberLookup() { }

	private bool FError() { }

	private static bool IsDelegateType(CType pSrcType, AggregateType pAggType) { }

	private static bool IsDynamicMember(Symbol sym) { }

	public bool Lookup(CType typeSrc, Expr obj, ParentSymbol symWhere, Name name, int arity, MemLookFlags flags) { }

	private bool LookupInClass(AggregateType typeStart, ref AggregateType ptypeEnd) { }

	private bool LookupInInterfaces(AggregateType typeStart, TypeArray types) { }

	private void RecordType(AggregateType type, Symbol sym) { }

	private static RuntimeBinderException ReportBogus(SymWithType swt) { }

	public Exception ReportErrors() { }

	private bool SearchSingleType(AggregateType typeCur, out bool pfHideByName) { }

	public SymWithType SwtFirst() { }

}

