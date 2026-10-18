namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class AggregateSymbol : NamespaceOrAggregateSymbol
{
	public Type AssociatedSystemType; //Field offset: 0x48
	public Assembly AssociatedAssembly; //Field offset: 0x50
	private AggregateType _atsInst; //Field offset: 0x58
	private AggregateType _pBaseClass; //Field offset: 0x60
	private AggregateType _pUnderlyingType; //Field offset: 0x68
	private TypeArray _ifaces; //Field offset: 0x70
	private TypeArray _ifacesAll; //Field offset: 0x78
	private TypeArray _typeVarsThis; //Field offset: 0x80
	private TypeArray _typeVarsAll; //Field offset: 0x88
	private MethodSymbol _pConvFirst; //Field offset: 0x90
	private AggKindEnum _aggKind; //Field offset: 0x98
	private bool _isPredefined; //Field offset: 0x9C
	private PredefinedType _iPredef; //Field offset: 0xA0
	private bool _isAbstract; //Field offset: 0xA4
	private bool _isSealed; //Field offset: 0xA5
	private bool _hasPubNoArgCtor; //Field offset: 0xA6
	private bool _isSkipUDOps; //Field offset: 0xA7
	private Nullable _hasConversion; //Field offset: 0xA8

	public AggregateSymbol() { }

	public AggKindEnum AggKind() { }

	public bool FindBaseAgg(AggregateSymbol agg) { }

	public AggregateSymbol GetBaseAgg() { }

	public AggregateType GetBaseClass() { }

	public MethodSymbol GetFirstUDConversion() { }

	public TypeArray GetIfaces() { }

	public TypeArray GetIfacesAll() { }

	public AggregateSymbol GetOuterAgg() { }

	public PredefinedType GetPredefType() { }

	public AggregateType getThisType() { }

	public TypeArray GetTypeVars() { }

	public TypeArray GetTypeVarsAll() { }

	public AggregateType GetUnderlyingType() { }

	public bool HasConversion() { }

	public bool HasPubNoArgCtor() { }

	public bool InternalsVisibleTo(Assembly assembly) { }

	public bool IsAbstract() { }

	public bool IsClass() { }

	public bool IsDelegate() { }

	public bool IsEnum() { }

	public bool IsInterface() { }

	public bool isNested() { }

	public bool isPredefAgg(PredefinedType pt) { }

	public bool IsPredefined() { }

	public bool IsRefType() { }

	public bool IsSealed() { }

	public bool IsSkipUDOps() { }

	public bool IsStatic() { }

	public bool IsStruct() { }

	public bool IsValueType() { }

	public void SetAbstract(bool abstract) { }

	public void SetAggKind(AggKindEnum aggKind) { }

	public void SetBaseClass(AggregateType baseClass) { }

	public void SetFirstUDConversion(MethodSymbol conv) { }

	public void SetHasConversion() { }

	public void SetHasPubNoArgCtor(bool hasPubNoArgCtor) { }

	public void SetIfaces(TypeArray ifaces) { }

	public void SetIfacesAll(TypeArray ifacesAll) { }

	public void SetPredefined(bool predefined) { }

	public void SetPredefType(PredefinedType predef) { }

	public void SetSealed(bool sealed) { }

	public void SetSkipUDOps(bool skipUDOps) { }

	public void SetTypeVars(TypeArray typeVars) { }

	public void SetUnderlyingType(AggregateType underlyingType) { }

}

