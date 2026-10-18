namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[IsReadOnly]
internal struct ExpressionBinder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public ExpressionBinder binder; //Field offset: 0x10
		public CType pDestType; //Field offset: 0x20
		public CType pIntType; //Field offset: 0x28

		public <>c__DisplayClass78_0() { }

		internal Expr <BindArrayIndexCore>b__0(Expr x) { }

	}

	private sealed class BinOpArgInfo
	{
		public Expr arg1; //Field offset: 0x10
		public Expr arg2; //Field offset: 0x18
		public PredefinedType pt1; //Field offset: 0x20
		public PredefinedType pt2; //Field offset: 0x24
		public PredefinedType ptRaw1; //Field offset: 0x28
		public PredefinedType ptRaw2; //Field offset: 0x2C
		public CType type1; //Field offset: 0x30
		public CType type2; //Field offset: 0x38
		public CType typeRaw1; //Field offset: 0x40
		public CType typeRaw2; //Field offset: 0x48
		public BinOpKind binopKind; //Field offset: 0x50
		public BinOpMask mask; //Field offset: 0x54

		public BinOpArgInfo(Expr op1, Expr op2) { }

		public bool ValidForDelegate() { }

		public bool ValidForEnum() { }

		public bool ValidForEnumAndUnderlyingType() { }

		public bool ValidForUnderlyingTypeAndEnum() { }

	}

	private sealed class BinOpFullSig : BinOpSig
	{
		private readonly LiftFlags _grflt; //Field offset: 0x30
		private readonly CType _type1; //Field offset: 0x38
		private readonly CType _type2; //Field offset: 0x40

		public BinOpFullSig(CType type1, CType type2, PfnBindBinOp pfn, OpSigFlags grfos, LiftFlags grflt, BinOpFuncKind fnkind) { }

		public BinOpFullSig(ExpressionBinder fnc, BinOpSig bos) { }

		public bool ConvertFirst() { }

		public bool ConvertSecond() { }

		public bool FPreDef() { }

		public bool isLifted() { }

		public CType Type1() { }

		public CType Type2() { }

	}

	private class BinOpSig
	{
		public PredefinedType pt1; //Field offset: 0x10
		public PredefinedType pt2; //Field offset: 0x14
		public BinOpMask mask; //Field offset: 0x18
		public int cbosSkip; //Field offset: 0x1C
		public PfnBindBinOp pfn; //Field offset: 0x20
		public OpSigFlags grfos; //Field offset: 0x28
		public BinOpFuncKind fnkind; //Field offset: 0x2C

		protected BinOpSig() { }

		public BinOpSig(PredefinedType pt1, PredefinedType pt2, BinOpMask mask, int cbosSkip, PfnBindBinOp pfn, OpSigFlags grfos, BinOpFuncKind fnkind) { }

		public bool AutoLift() { }

		public bool CanLift() { }

		public bool ConvertOperandsBeforeBinding() { }

	}

	private sealed class ConversionFunc : MulticastDelegate
	{

		public ConversionFunc(object object, IntPtr method) { }

		public override bool Invoke(Expr pSourceExpr, CType pSourceType, CType pDestinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags) { }

	}

	private sealed class ExplicitConversion
	{
		private readonly ExpressionBinder _binder; //Field offset: 0x10
		private Expr _exprSrc; //Field offset: 0x20
		private readonly CType _typeSrc; //Field offset: 0x28
		private readonly CType _typeDest; //Field offset: 0x30
		private Expr _exprDest; //Field offset: 0x38
		private readonly bool _needsExprDest; //Field offset: 0x40
		private readonly CONVERTTYPE _flags; //Field offset: 0x44

		public Expr ExprDest
		{
			 get { } //Length: 5
		}

		public ExplicitConversion(ExpressionBinder binder, Expr exprSrc, CType typeSrc, CType typeDest, bool needsExprDest, CONVERTTYPE flags) { }

		public bool Bind() { }

		private AggCastResult bindExplicitConversionBetweenAggregates(AggregateType aggTypeDest) { }

		private AggCastResult bindExplicitConversionBetweenSimpleTypes(AggregateType aggTypeDest) { }

		private bool bindExplicitConversionFromArrayToArray(ArrayType arraySrc, ArrayType arrayDest) { }

		private bool bindExplicitConversionFromArrayToIList() { }

		private AggCastResult bindExplicitConversionFromDecimalToEnum(AggregateType aggTypeDest) { }

		private AggCastResult bindExplicitConversionFromEnumToAggregate(AggregateType aggTypeDest) { }

		private AggCastResult bindExplicitConversionFromEnumToDecimal(AggregateType aggTypeDest) { }

		private bool bindExplicitConversionFromIListToArray(ArrayType arrayDest) { }

		private bool bindExplicitConversionFromNub() { }

		private AggCastResult bindExplicitConversionFromPointerToInt(AggregateType aggTypeDest) { }

		private AggCastResult bindExplicitConversionToAggregate(AggregateType aggTypeDest) { }

		private bool bindExplicitConversionToArray(ArrayType arrayDest) { }

		private AggCastResult bindExplicitConversionToEnum(AggregateType aggTypeDest) { }

		private bool bindExplicitConversionToPointer() { }

		public Expr get_ExprDest() { }

	}

	public sealed class GroupToArgsBinder
	{
		private enum Result
		{
			Success = 0,
			Failure_SearchForExpanded = 1,
			Failure_NoSearchForExpanded = 2,
		}

		private readonly ExpressionBinder _pExprBinder; //Field offset: 0x10
		private bool _fCandidatesUnsupported; //Field offset: 0x20
		private readonly BindingFlag _fBindFlags; //Field offset: 0x24
		private readonly ExprMemberGroup _pGroup; //Field offset: 0x28
		private readonly ArgInfos _pArguments; //Field offset: 0x30
		private readonly ArgInfos _pOriginalArguments; //Field offset: 0x38
		private readonly NamedArgumentsKind _namedArgumentsKind; //Field offset: 0x40
		private AggregateType _pCurrentType; //Field offset: 0x48
		private MethodOrPropertySymbol _pCurrentSym; //Field offset: 0x50
		private TypeArray _pCurrentTypeArgs; //Field offset: 0x58
		private TypeArray _pCurrentParameters; //Field offset: 0x60
		private int _nArgBest; //Field offset: 0x68
		private readonly GroupToArgsBinderResult _results; //Field offset: 0x70
		private readonly List _methList; //Field offset: 0x78
		private readonly MethPropWithInst _mpwiParamTypeConstraints; //Field offset: 0x80
		private readonly MethPropWithInst _mpwiBogus; //Field offset: 0x88
		private readonly MethPropWithInst _misnamed; //Field offset: 0x90
		private readonly MethPropWithInst _mpwiCantInferInstArg; //Field offset: 0x98
		private readonly MethWithType _mwtBadArity; //Field offset: 0xA0
		private Name _pInvalidSpecifiedName; //Field offset: 0xA8
		private Name _pNameUsedInPositionalArgument; //Field offset: 0xB0
		private Name _pDuplicateSpecifiedName; //Field offset: 0xB8
		private readonly List _HiddenTypes; //Field offset: 0xC0
		private bool _bArgumentsChangedForNamedOrOptionalArguments; //Field offset: 0xC8

		public GroupToArgsBinder(ExpressionBinder exprBinder, BindingFlag bindFlags, ExprMemberGroup grp, ArgInfos args, ArgInfos originalArgs, NamedArgumentsKind namedArgumentsKind) { }

		private bool AddArgumentsForOptionalParameters() { }

		private bool ArgumentsAreConvertible() { }

		public void Bind() { }

		private bool ConstructExpandedParameters() { }

		private static void CopyArgInfos(ArgInfos src, ArgInfos dst) { }

		private Result DetermineCurrentTypeArgs() { }

		private static bool DoesTypeArgumentsContainErrorSym(CType var) { }

		private static Expr FindArgumentWithName(ArgInfos pArguments, Name pName) { }

		private static MethodOrPropertySymbol FindMostDerivedMethod(MethodOrPropertySymbol pMethProp, Expr pObject) { }

		public static MethodOrPropertySymbol FindMostDerivedMethod(MethodOrPropertySymbol pMethProp, CType pType) { }

		private static Expr GenerateOptionalArgument(MethodOrPropertySymbol methprop, CType type, int index) { }

		private bool GetNextSym(CMethodIterator iterator) { }

		private bool GetResultOfBind() { }

		public GroupToArgsBinderResult GetResultsOfBind() { }

		private static CType GetTypeQualifier(ExprMemberGroup pGroup) { }

		private bool HasOptionalParameters() { }

		private void LookForCandidates() { }

		private bool NamedArgumentNamesAppearInParameterList(MethodOrPropertySymbol methprop) { }

		internal static bool ReOrderArgsForNamedArguments(MethodOrPropertySymbol methprop, TypeArray pCurrentParameters, AggregateType pCurrentType, ExprMemberGroup pGroup, ArgInfos pArguments) { }

		private bool ReOrderArgsForNamedArguments() { }

		private RuntimeBinderException ReportErrorsForBestMatching(bool bUseDelegateErrors) { }

		private RuntimeBinderException ReportErrorsOnFailure() { }

		private void ReportErrorsOnSuccess() { }

		private void UpdateArguments() { }

	}

	public sealed class GroupToArgsBinderResult
	{
		[CompilerGenerated]
		private MethPropWithInst <BestResult>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private MethPropWithInst <AmbiguousResult>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly MethPropWithInst <InaccessibleResult>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly MethPropWithInst <UninferableResult>k__BackingField; //Field offset: 0x28

		public MethPropWithInst AmbiguousResult
		{
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public MethPropWithInst BestResult
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public MethPropWithInst InaccessibleResult
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public MethPropWithInst UninferableResult
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public GroupToArgsBinderResult() { }

		[CompilerGenerated]
		public MethPropWithInst get_BestResult() { }

		[CompilerGenerated]
		public MethPropWithInst get_InaccessibleResult() { }

		[CompilerGenerated]
		public MethPropWithInst get_UninferableResult() { }

		private static bool IsBetterThanCurrent(TypeArray pTypeArgs1, TypeArray pTypeArgs2) { }

		public bool IsBetterUninferableResult(TypeArray pTypeArguments) { }

		private static int NumberOfErrorTypes(TypeArray pTypeArgs) { }

		[CompilerGenerated]
		public void set_AmbiguousResult(MethPropWithInst value) { }

		[CompilerGenerated]
		public void set_BestResult(MethPropWithInst value) { }

	}

	private sealed class ImplicitConversion
	{
		private Expr _exprDest; //Field offset: 0x10
		private readonly ExpressionBinder _binder; //Field offset: 0x18
		private readonly Expr _exprSrc; //Field offset: 0x28
		private readonly CType _typeSrc; //Field offset: 0x30
		private readonly CType _typeDest; //Field offset: 0x38
		private readonly bool _needsExprDest; //Field offset: 0x40
		private CONVERTTYPE _flags; //Field offset: 0x44

		public Expr ExprDest
		{
			 get { } //Length: 5
		}

		public ImplicitConversion(ExpressionBinder binder, Expr exprSrc, CType typeSrc, CType typeDest, bool needsExprDest, CONVERTTYPE flags) { }

		public bool Bind() { }

		private bool bindImplicitConversionBetweenSimpleTypes(AggregateType aggTypeSrc) { }

		private bool bindImplicitConversionFromAgg(AggregateType aggTypeSrc) { }

		private bool bindImplicitConversionFromArray() { }

		private bool bindImplicitConversionFromEnum(AggregateType aggTypeSrc) { }

		private bool bindImplicitConversionFromNull() { }

		private bool bindImplicitConversionFromNullable(NullableType nubSrc) { }

		private bool bindImplicitConversionFromPointer() { }

		private bool bindImplicitConversionToBase(AggregateType pSource) { }

		private bool bindImplicitConversionToEnum(AggregateType aggTypeSrc) { }

		private bool BindNubConversion(NullableType nubDst) { }

		public Expr get_ExprDest() { }

	}

	internal enum NamedArgumentsKind
	{
		None = 0,
		Positioning = 1,
		NonTrailing = 2,
	}

	private sealed class PfnBindBinOp : MulticastDelegate
	{

		public PfnBindBinOp(object object, IntPtr method) { }

		public override Expr Invoke(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr op1, Expr op2) { }

	}

	private sealed class PfnBindUnaOp : MulticastDelegate
	{

		public PfnBindUnaOp(object object, IntPtr method) { }

		public override Expr Invoke(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr op) { }

	}

	private sealed class UnaOpFullSig : UnaOpSig
	{
		private readonly LiftFlags _grflt; //Field offset: 0x30
		private readonly CType _type; //Field offset: 0x38

		public UnaOpFullSig(CType type, PfnBindUnaOp pfn, LiftFlags grflt, UnaOpFuncKind fnkind) { }

		public UnaOpFullSig(ExpressionBinder fnc, UnaOpSig uos) { }

		public bool Convert() { }

		public bool FPreDef() { }

		public CType GetType() { }

		public bool isLifted() { }

	}

	private class UnaOpSig
	{
		public PredefinedType pt; //Field offset: 0x10
		public UnaOpMask grfuom; //Field offset: 0x14
		public int cuosSkip; //Field offset: 0x18
		public PfnBindUnaOp pfn; //Field offset: 0x20
		public UnaOpFuncKind fnkind; //Field offset: 0x28

		protected UnaOpSig() { }

		public UnaOpSig(PredefinedType pt, UnaOpMask grfuom, int cuosSkip, PfnBindUnaOp pfn, UnaOpFuncKind fnkind) { }

	}

	private static readonly byte[][] s_betterConversionTable; //Field offset: 0x0
	private static readonly byte[][] s_simpleTypeConversions; //Field offset: 0x8
	private static readonly byte[][] s_simpleTypeBetter; //Field offset: 0x10
	private static readonly PredefinedType[] s_rgptIntOp; //Field offset: 0x18
	private static readonly PredefinedName[] s_EK2NAME; //Field offset: 0x20
	private static readonly BinOpSig[] s_binopSignatures; //Field offset: 0x28
	private static readonly UnaOpSig[] s_rguos; //Field offset: 0x30
	[CompilerGenerated]
	private readonly BindingContext <Context>k__BackingField; //Field offset: 0x0

	public BindingContext Context
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	private AggregateSymbol ContextForMemberLookup
	{
		private get { } //Length: 72
	}

	private static ExpressionBinder() { }

	public ExpressionBinder(BindingContext context) { }

	private void AdjustCallArgumentsForParams(CType callingObjectType, CType type, MethodOrPropertySymbol mp, TypeArray pTypeArgs, Expr argsPtr, out Expr newArgs) { }

	private Expr AdjustMemberObject(SymWithType swt, Expr pObject) { }

	private static RuntimeBinderException AmbiguousOperatorError(Expr op1, Expr op2) { }

	private static RuntimeBinderException BadOperatorTypesError(Expr pOperand1, Expr pOperand2) { }

	internal Expr BindArrayIndexCore(Expr pOp1, Expr pOp2) { }

	public Expr BindAssignment(Expr op1, Expr op2, bool allowExplicit) { }

	private static ExprBinOp BindBoolBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private ExprOperator BindBoolBitwiseOp(ExpressionKind ek, EXPRFLAG flags, Expr expr1, Expr expr2) { }

	private static Expr BindBoolUnaOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg) { }

	private ConstCastResult bindConstantCast(Expr exprSrc, CType typeDest, bool needExprDest, out Expr pexprDest, bool explicitConversion) { }

	private static ExprBinOp BindDecBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static Expr BindDecimalConstCast(CType destType, CType srcType, ExprConstant src) { }

	private static ExprUnaryOp BindDecUnaOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg) { }

	private static Expr BindDelBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static Expr BindEnumBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static Expr BindEnumUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg) { }

	private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, CONVERTTYPE flags) { }

	private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, out Expr ppDestinationExpr, CONVERTTYPE flags) { }

	private bool BindExplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags) { }

	private static ExprOperator BindFloatOp(ExpressionKind kind, Expr op1, Expr op2) { }

	private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, CONVERTTYPE flags) { }

	private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, out Expr ppDestinationExpr, CONVERTTYPE flags) { }

	private bool BindImplicitConversion(Expr pSourceExpr, CType pSourceType, CType destinationType, bool needsExprDest, out Expr ppDestinationExpr, CONVERTTYPE flags) { }

	private Expr BindIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs) { }

	private Expr BindIncOpCore(ExpressionKind ek, EXPRFLAG flags, Expr exprVal, CType type) { }

	private static ExprOperator BindIntBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private ExprOperator BindIntegerNeg(EXPRFLAG flags, Expr op, PredefinedType ptOp) { }

	private ExprOperator BindIntOp(ExpressionKind kind, EXPRFLAG flags, Expr op1, Expr op2, PredefinedType ptOp) { }

	private static ExprOperator BindIntUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg) { }

	private static Expr BindLiftedBoolBitwiseOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr expr1, Expr expr2) { }

	private Expr BindLiftedEnumArithmeticBinOp(ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private ExprMulti BindLiftedIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs) { }

	private ExprBinOp BindLiftedStandardBinOp(BinOpArgInfo info, BinOpFullSig bofs, ExpressionKind ek, EXPRFLAG flags) { }

	private ExprOperator BindLiftedStandardUnop(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs) { }

	private ExprCall BindLiftedUDBinop(ExpressionKind ek, Expr arg1, Expr arg2, TypeArray Params, MethPropWithInst mpwi) { }

	private ExprCall BindLiftedUDUnop(Expr arg, CType typeArg, MethPropWithInst mpwi) { }

	internal ExprWithArgs BindMethodGroupToArguments(BindingFlag bindFlags, ExprMemberGroup grp, Expr args) { }

	private GroupToArgsBinderResult BindMethodGroupToArgumentsCore(BindingFlag bindFlags, ExprMemberGroup grp, Expr args, int carg, NamedArgumentsKind namedArgumentsKind) { }

	private ExprMulti BindNonliftedIncOp(ExpressionKind ek, EXPRFLAG flags, Expr arg, UnaOpFullSig uofs) { }

	private static ExprCall BindNubNew(Expr exprSrc) { }

	private static Expr BindNubValue(Expr exprSrc) { }

	private static ExprBinOp BindNullEqualityComparison(ExpressionKind ek, BinOpArgInfo info) { }

	private static ExprOperator BindRealBinOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG _, Expr arg1, Expr arg2) { }

	private static ExprOperator BindRealUnaOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG _, Expr arg) { }

	private static ExprBinOp BindRefCmpOp(ExpressionBinder binder, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static ExprBinOp BindShiftOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private void bindSimpleCast(Expr exprSrc, CType typeDest, out Expr pexprDest) { }

	private void bindSimpleCast(Expr exprSrc, CType typeDest, out Expr pexprDest, EXPRFLAG exprFlags) { }

	public Expr BindStandardBinop(ExpressionKind ek, Expr arg1, Expr arg2) { }

	private Expr BindStandardBinopCore(BinOpArgInfo info, BinOpFullSig bofs, ExpressionKind ek, EXPRFLAG flags) { }

	public Expr BindStandardUnaryOperator(OperatorKind op, Expr pArgument) { }

	private static Expr BindStrBinOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static ExprBinOp BindStrCmpOp(ExpressionBinder _, ExpressionKind ek, EXPRFLAG flags, Expr arg1, Expr arg2) { }

	private static ExprConcat BindStringConcat(Expr op1, Expr op2) { }

	internal Expr BindToField(Expr pOptionalObject, FieldWithType fwt, BindingFlag bindFlags) { }

	private ExprCall BindToMethod(MethWithInst mwi, Expr pArguments, ExprMemberGroup pMemGroup, MemLookFlags flags) { }

	internal ExprProperty BindToProperty(Expr pObject, PropWithType pwt, BindingFlag bindFlags, Expr args, ExprMemberGroup pMemGroup) { }

	private ExprCall BindUDBinop(ExpressionKind ek, Expr arg1, Expr arg2, bool fDontLift, out MethPropWithInst ppmpwi) { }

	private ExprCall BindUDBinopCall(Expr arg1, Expr arg2, TypeArray Params, CType typeRet, MethPropWithInst mpwi) { }

	private Expr BindUDConversionCore(Expr pFrom, CType pTypeFrom, CType pTypeTo, CType pTypeDestination, MethWithInst mwiBest) { }

	private Expr BindUDConversionCore(Expr pFrom, CType pTypeFrom, CType pTypeTo, CType pTypeDestination, MethWithInst mwiBest, out Expr ppTransformedArgument) { }

	internal Expr bindUDUnop(ExpressionKind ek, Expr arg) { }

	private ExprCall BindUDUnopCall(Expr arg, CType typeArg, MethPropWithInst mpwi) { }

	private Expr BindUserBoolOp(ExpressionKind kind, ExprCall pCall) { }

	private ExprBinOp BindUserDefinedBinOp(ExpressionKind ek, BinOpArgInfo info) { }

	private bool bindUserDefinedConversion(Expr exprSrc, CType typeSrc, CType typeDst, bool needExprDest, out Expr pexprDst, bool fImplicitOnly) { }

	private static ValueTuple CalculateExprAndUnaryOpKinds(OperatorKind op, bool bChecked) { }

	private bool canCast(CType src, CType dest, CONVERTTYPE flags) { }

	public bool canConvert(CType src, CType dest) { }

	private bool canConvert(Expr expr, CType dest) { }

	private bool canConvert(CType src, CType dest, CONVERTTYPE flags) { }

	private bool canConvert(Expr expr, CType dest, CONVERTTYPE flags) { }

	private bool CanConvertArg1(BinOpArgInfo info, CType typeDst, out LiftFlags pgrflt, out CType ptypeSig1, out CType ptypeSig2) { }

	private bool CanConvertArg2(BinOpArgInfo info, CType typeDst, out LiftFlags pgrflt, out CType ptypeSig1, out CType ptypeSig2) { }

	private bool CanExplicitConversionBeBoundInUncheckedContext(Expr exprSrc, CType typeSrc, CType typeDest, CONVERTTYPE flags) { }

	private static RuntimeBinderException CantConvert(Expr expr, CType dest) { }

	private void CheckLvalue(Expr expr, CheckLvalueKind kind) { }

	private void CheckLvalueProp(ExprProperty prop) { }

	private void CheckPropertyAccess(MethWithType mwt, PropWithType pwtSlot, CType type) { }

	private static void CheckUnsafe(CType type) { }

	internal CType ChooseArrayIndexType(Expr args) { }

	private int CompareDstTypesBased(CType type1, bool fImplicit1, CType type2, bool fImplicit2) { }

	private int CompareSrcTypesBased(CType type1, bool fImplicit1, CType type2, bool fImplicit2) { }

	private static BetterType CompareTypes(TypeArray ta1, TypeArray ta2) { }

	internal static int CountArguments(Expr args) { }

	private static ExprBinOp CreateBinopForPredefMethodCall(ExpressionKind ek, PREDEFMETH predefMeth, CType RetType, Expr arg1, Expr arg2) { }

	private static ExprUnaryOp CreateUnaryOpForPredefMethodCall(ExpressionKind ek, PREDEFMETH predefMeth, CType pRetType, Expr pArg) { }

	private static Name ExpressionKindName(ExpressionKind ek) { }

	internal static void FillInArgInfoFromArgList(ArgInfos argInfo, Expr args) { }

	private bool FindApplicableSignatures(Expr pArgument, UnaOpMask unaryOpMask, List pSignatures) { }

	private CandidateFunctionMember FindBestMethod(List list, CType pTypeThrough, ArgInfos args, out CandidateFunctionMember methAmbig1, out CandidateFunctionMember methAmbig2) { }

	private int FindBestSignatureInList(List binopSignatures, BinOpArgInfo info) { }

	private static int FindName(List names, Name name) { }

	private static NamedArgumentsKind FindNamedArgumentsType(Expr args) { }

	private Expr GenerateAssignmentConversion(Expr op1, Expr op2, bool allowExplicit) { }

	private static ExprAssignment GenerateOptimizedAssignment(Expr op1, Expr op2) { }

	[CompilerGenerated]
	public BindingContext get_Context() { }

	private AggregateSymbol get_ContextForMemberLookup() { }

	private bool GetApplicableUserDefinedBinaryOperatorCandidates(List candidateList, ExpressionKind ek, AggregateType type, Expr arg1, Expr arg2, bool fDontLift) { }

	private AggregateType GetApplicableUserDefinedBinaryOperatorCandidatesInBaseTypes(List candidateList, ExpressionKind ek, AggregateType type, Expr arg1, Expr arg2, bool fDontLift, AggregateType atsStop) { }

	private ValueTuple GetBinopKindAndFlags(ExpressionKind ek) { }

	private static ConvKind GetConvKind(PredefinedType ptSrc, PredefinedType ptDst) { }

	private bool GetDelBinOpSigs(List prgbofs, BinOpArgInfo info) { }

	private bool GetEnumBinOpSigs(List prgbofs, BinOpArgInfo info) { }

	private static AggregateType GetEnumBinOpType(ExpressionKind ek, CType argType1, CType argType2, out AggregateType ppEnumType) { }

	private static AggregateType GetPredefindType(PredefinedType pt) { }

	private bool GetRefEqualSigs(List prgbofs, BinOpArgInfo info) { }

	private bool GetSpecialBinopSignatures(List prgbofs, BinOpArgInfo info) { }

	private bool GetStandardAndLiftedBinopSignatures(List rgbofs, BinOpArgInfo info) { }

	private static ErrorCode GetStandardLvalueError(CheckLvalueKind kind) { }

	private static AggregateType GetUserDefinedBinopArgumentType(CType type) { }

	private static int GetUserDefinedBinopArgumentTypes(CType type1, CType type2, AggregateType[] rgats) { }

	private static RuntimeBinderException HandleAmbiguity(CType typeSrc, CType typeDst, List prguci, int iuciBestSrc, int iuciBestDst) { }

	private static long I64(ulong x) { }

	private static long I64(long x) { }

	private static bool isConstantInRange(ExprConstant exprSrc, CType typeDest) { }

	private static bool isConstantInRange(ExprConstant exprSrc, CType typeDest, bool realsOk) { }

	private static bool IsConvInTable(List convTable, MethodSymbol meth, AggregateType ats, bool fSrc, bool fDst) { }

	private static bool IsEnumArithmeticBinOp(ExpressionKind ek, BinOpArgInfo info) { }

	private static bool IsMatchingStatic(SymWithType swt, Expr pObject) { }

	public static bool IsMethPropCallable(MethodOrPropertySymbol sym, bool requireUC) { }

	private static bool IsNullableConstructor(Expr expr, out ExprCall call) { }

	private static bool isUserDefinedConversion(PredefinedType ptSrc, PredefinedType ptDst) { }

	private void LiftArgument(Expr pArgument, CType pParameterType, bool bConvertBeforeLift, out Expr ppLiftedArgument, out Expr ppNonLiftedArgument) { }

	private Expr LScalar(ExpressionKind ek, EXPRFLAG flags, Expr exprVal, CType type, ConstVal cv, CType typeTmp) { }

	private static void MarkAsIntermediateConversion(Expr pExpr) { }

	public Expr mustCast(Expr expr, CType dest) { }

	public Expr mustCast(Expr expr, CType dest, CONVERTTYPE flags) { }

	private Expr mustCastCore(Expr expr, CType dest, CONVERTTYPE flags) { }

	private Expr MustCastInUncheckedContext(Expr expr, CType dest, CONVERTTYPE flags) { }

	private Expr mustConvert(Expr expr, CType dest, CONVERTTYPE flags) { }

	public Expr mustConvert(Expr expr, CType dest) { }

	private Expr mustConvertCore(Expr expr, CType destExpr) { }

	private Expr mustConvertCore(Expr expr, CType dest, CONVERTTYPE flags) { }

	private UnaryOperatorSignatureFindResult PopulateSignatureList(Expr pArgument, UnaOpKind unaryOpKind, UnaOpMask unaryOpMask, ExpressionKind exprKind, EXPRFLAG flags, List pSignatures, out Expr ppResult) { }

	private static void PostBindMethod(MethWithInst pMWI) { }

	private static void PostBindProperty(PropWithType pwt, out MethWithType pmwtGet, out MethWithType pmwtSet) { }

	private static TypeArray RearrangeNamedArguments(TypeArray pta, MethPropWithInst mpwi, CType pTypeThrough, ArgInfos args) { }

	private static void RecordBinOpSigFromArgs(List prgbofs, BinOpArgInfo info) { }

	private static void RoundToFloat(double d, out float f) { }

	private static Expr StripNullableConstructor(Expr pExpr) { }

	private Expr tryConvert(Expr expr, CType dest, CONVERTTYPE flags) { }

	public Expr tryConvert(Expr expr, CType dest) { }

	private static bool TryGetExpandedParams(TypeArray params, int count, out TypeArray ppExpandedParams) { }

	private static bool UserDefinedBinaryOperatorCanBeLifted(ExpressionKind ek, MethodSymbol method, AggregateType ats, TypeArray Params) { }

	private bool UserDefinedBinaryOperatorIsApplicable(List candidateList, ExpressionKind ek, MethodSymbol method, AggregateType ats, Expr arg1, Expr arg2, bool fDontLift) { }

	private void verifyMethodArgs(ExprWithArgs call, CType callingObjectType) { }

	private int WhichBofsIsBetter(BinOpFullSig bofs1, BinOpFullSig bofs2, CType type1, CType type2) { }

	private BetterType WhichConversionIsBetter(CType argType, CType p1, CType p2) { }

	private BetterType WhichMethodIsBetter(CandidateFunctionMember node1, CandidateFunctionMember node2, CType pTypeThrough, ArgInfos args) { }

	private static BetterType WhichMethodIsBetterTieBreaker(CandidateFunctionMember node1, CandidateFunctionMember node2, CType pTypeThrough, ArgInfos args) { }

	private BetterType WhichSimpleConversionIsBetter(PredefinedType pt1, PredefinedType pt2) { }

	private BetterType WhichTypeIsBetter(PredefinedType pt1, PredefinedType pt2, CType typeGiven) { }

	private BetterType WhichTypeIsBetter(CType type1, CType type2, CType typeGiven) { }

	private int WhichUofsIsBetter(UnaOpFullSig uofs1, UnaOpFullSig uofs2, CType typeArg) { }

	private static ExprWrap WrapShortLivedExpression(Expr expr) { }

}

