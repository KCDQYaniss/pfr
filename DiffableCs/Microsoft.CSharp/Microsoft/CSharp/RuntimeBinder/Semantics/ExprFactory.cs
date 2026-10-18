namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class ExprFactory
{

	public static void AppendItemToList(Expr newItem, ref Expr first, ref Expr last) { }

	public static ExprBoundLambda CreateAnonymousMethod(AggregateType delegateType, Scope argumentScope, Expr expression) { }

	public static ExprArrayIndex CreateArrayIndex(CType type, Expr array, Expr index) { }

	public static ExprArrayInit CreateArrayInit(CType type, Expr arguments, Expr argumentDimensions, int[] dimSizes, int dimSize) { }

	public static ExprAssignment CreateAssignment(Expr left, Expr right) { }

	public static ExprBinOp CreateBinop(ExpressionKind exprKind, CType type, Expr left, Expr right) { }

	public static ExprConstant CreateBoolConstant(bool b) { }

	public static ExprCall CreateCall(EXPRFLAG flags, CType type, Expr arguments, ExprMemberGroup memberGroup, MethWithInst method) { }

	public static ExprCast CreateCast(CType type, Expr argument) { }

	public static ExprCast CreateCast(EXPRFLAG flags, CType type, Expr argument) { }

	public static ExprClass CreateClass(CType type) { }

	public static ExprConcat CreateConcat(Expr first, Expr second) { }

	public static ExprConstant CreateConstant(CType type, ConstVal constVal) { }

	public static ExprField CreateField(CType type, Expr optionalObject, FieldWithType field) { }

	public static ExprFieldInfo CreateFieldInfo(FieldSymbol field, AggregateType fieldType) { }

	public static ExprConstant CreateIntegerConstant(int x) { }

	public static ExprList CreateList(Expr op1, Expr op2, Expr op3) { }

	public static ExprList CreateList(Expr op1, Expr op2) { }

	public static ExprList CreateList(Expr op1, Expr op2, Expr op3, Expr op4) { }

	public static ExprLocal CreateLocal(LocalVariableSymbol local) { }

	public static ExprMemberGroup CreateMemGroup(EXPRFLAG flags, Name name, TypeArray typeArgs, SYMKIND symKind, CType parentType, Expr obj, CMemberLookupResults memberLookupResults) { }

	public static ExprMemberGroup CreateMemGroup(Expr obj, MethPropWithInst method) { }

	public static ExprMethodInfo CreateMethodInfo(MethPropWithInst mwi) { }

	public static ExprMethodInfo CreateMethodInfo(MethodSymbol method, AggregateType methodType, TypeArray methodParameters) { }

	public static ExprMulti CreateMulti(EXPRFLAG flags, CType type, Expr left, Expr op) { }

	public static ExprMultiGet CreateMultiGet(EXPRFLAG flags, CType type, ExprMulti multi) { }

	public static ExprNamedArgumentSpecification CreateNamedArgumentSpecification(Name name, Expr value) { }

	public static ExprUnaryOp CreateNeg(EXPRFLAG flags, Expr operand) { }

	public static ExprConstant CreateNull() { }

	public static ExprOperator CreateOperator(ExpressionKind exprKind, CType type, Expr arg1, Expr arg2) { }

	public static ExprProperty CreateProperty(CType type, Expr optionalObjectThrough, Expr arguments, ExprMemberGroup memberGroup, PropWithType property, MethWithType setMethod) { }

	public static ExprPropertyInfo CreatePropertyInfo(PropertySymbol prop, AggregateType propertyType) { }

	public static ExprBinOp CreateSave(ExprWrap wrap) { }

	public static ExprBinOp CreateSequence(Expr first, Expr second) { }

	public static ExprConstant CreateStringConstant(string str) { }

	public static ExprTypeOf CreateTypeOf(CType sourceType) { }

	public static ExprUnaryOp CreateUnaryOp(ExpressionKind exprKind, CType type, Expr operand) { }

	public static ExprBinOp CreateUserDefinedBinop(ExpressionKind exprKind, CType type, Expr left, Expr right, Expr call, MethPropWithInst userMethod) { }

	public static ExprUserDefinedConversion CreateUserDefinedConversion(Expr arg, Expr call, MethWithInst method) { }

	public static ExprUnaryOp CreateUserDefinedUnaryOperator(ExpressionKind exprKind, CType type, Expr operand, ExprCall call, MethPropWithInst userMethod) { }

	public static ExprUserLogicalOp CreateUserLogOp(CType type, Expr trueFalseCall, ExprCall operatorCall) { }

	public static ExprWrap CreateWrap(Expr expression) { }

	public static Expr CreateZeroInit(CType type) { }

}

