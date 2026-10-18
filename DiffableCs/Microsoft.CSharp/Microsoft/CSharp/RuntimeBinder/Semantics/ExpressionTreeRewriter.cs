namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExpressionTreeRewriter : ExprVisitorBase
{

	public ExpressionTreeRewriter() { }

	private static ExprTypeOf CreateTypeOf(CType type) { }

	private static Expr CreateWraps(ExprBoundLambda anonmeth) { }

	protected virtual Expr Dispatch(Expr expr) { }

	private static void FixLiftedUserDefinedBinaryOperators(ExprBinOp expr, ref Expr pp1, ref Expr pp2) { }

	private Expr GenerateArgsList(Expr oldArgs) { }

	private Expr GenerateBuiltInBinaryOperator(ExprBinOp expr) { }

	private Expr GenerateBuiltInUnaryOperator(ExprUnaryOp expr) { }

	private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2, Expr arg3, Expr arg4) { }

	private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2, Expr arg3) { }

	private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2) { }

	private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1) { }

	private static Expr GenerateConstant(Expr expr) { }

	private Expr GenerateConstructor(ExprCall expr) { }

	private Expr GenerateConversion(Expr arg, CType CType, bool bChecked) { }

	private static Expr GenerateConversionWithSource(Expr pTarget, CType pType, bool bChecked) { }

	private Expr GenerateDelegateInvoke(ExprCall expr) { }

	private Expr GenerateIndexList(Expr oldIndices) { }

	private static Expr GenerateParameter(string name, CType CType) { }

	private static ExprArrayInit GenerateParamsArray(Expr args, PredefinedType pt) { }

	private Expr GenerateUserDefinedBinaryOperator(ExprBinOp expr) { }

	private Expr GenerateUserDefinedComparisonOperator(ExprBinOp expr) { }

	private static Expr GenerateUserDefinedConversion(Expr arg, CType CType, Expr target, MethWithInst method) { }

	private Expr GenerateUserDefinedConversion(ExprUserDefinedConversion pExpr, Expr pArgument) { }

	private Expr GenerateUserDefinedConversion(Expr arg, CType type, MethWithInst method) { }

	private Expr GenerateUserDefinedUnaryOperator(ExprUnaryOp expr) { }

	private Expr GenerateValueAccessConversion(Expr pArgument) { }

	private static MethodSymbol GetPreDefMethod(PREDEFMETH pdm) { }

	private static bool isEnumToDecimalConversion(CType argtype, CType desttype) { }

	private static bool IsNullableValueAccess(Expr pExpr, Expr pObject) { }

	private static bool IsNullableValueType(CType pType) { }

	public static ExprBinOp Rewrite(ExprBoundLambda expr) { }

	protected virtual Expr VisitARRAYINDEX(ExprArrayIndex pExpr) { }

	protected virtual Expr VisitARRINIT(ExprArrayInit expr) { }

	protected virtual Expr VisitASSIGNMENT(ExprAssignment assignment) { }

	protected virtual Expr VisitBINOP(ExprBinOp expr) { }

	private ExprBinOp VisitBoundLambda(ExprBoundLambda anonmeth) { }

	protected virtual Expr VisitCALL(ExprCall expr) { }

	protected virtual Expr VisitCAST(ExprCast pExpr) { }

	protected virtual Expr VisitCONCAT(ExprConcat expr) { }

	protected virtual Expr VisitCONSTANT(ExprConstant expr) { }

	protected virtual Expr VisitFIELD(ExprField expr) { }

	protected virtual Expr VisitLOCAL(ExprLocal local) { }

	protected virtual Expr VisitMULTI(ExprMulti pExpr) { }

	protected virtual Expr VisitMULTIGET(ExprMultiGet pExpr) { }

	protected virtual Expr VisitPROP(ExprProperty expr) { }

	protected virtual Expr VisitTYPEOF(ExprTypeOf expr) { }

	protected virtual Expr VisitUNARYOP(ExprUnaryOp pExpr) { }

	protected virtual Expr VisitUSERDEFINEDCONVERSION(ExprUserDefinedConversion expr) { }

	protected virtual Expr VisitZEROINIT(ExprZeroInit expr) { }

}

