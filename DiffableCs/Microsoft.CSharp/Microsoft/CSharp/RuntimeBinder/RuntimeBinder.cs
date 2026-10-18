namespace Microsoft.CSharp.RuntimeBinder;

[IsReadOnly]
internal struct RuntimeBinder
{
	private static readonly object s_bindLock; //Field offset: 0x0
	private readonly ExpressionBinder _binder; //Field offset: 0x0

	private static RuntimeBinder() { }

	public RuntimeBinder(Type contextType, bool isChecked = false) { }

	private static void AddConversionsForArguments(ArgumentObject[] arguments) { }

	public Expression Bind(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args, out DynamicMetaObject deferredBinding) { }

	internal Expr BindAssignment(ICSharpBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	internal Expr BindBinaryOperation(CSharpBinaryOperationBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	private ExprWithArgs BindCall(ICSharpInvokeOrInvokeMemberBinder payload, Expr callingObject, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	private Expression BindCore(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args, out DynamicMetaObject deferredBinding) { }

	internal Expr BindExplicitConversion(ArgumentObject[] arguments, Type returnType, LocalVariableSymbol[] locals) { }

	internal Expr BindImplicitConversion(ArgumentObject[] arguments, Type returnType, LocalVariableSymbol[] locals, bool bIsArrayCreationConversion) { }

	internal Expr BindProperty(ICSharpBinder payload, ArgumentObject argument, LocalVariableSymbol local, Expr optionalIndexerArguments) { }

	internal Expr BindUnaryOperation(CSharpUnaryOperationBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	private ExprWithArgs BindWinRTEventAccessor(EventWithType ewt, Expr callingObject, ArgumentObject[] arguments, LocalVariableSymbol[] locals, bool isAddAccessor) { }

	private static void CheckForConditionalMethodError(ExprCall call) { }

	private ArgumentObject[] CreateArgumentArray(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args) { }

	private Expr CreateArgumentEXPR(ArgumentObject argument, LocalVariableSymbol local) { }

	internal Expr CreateArgumentListEXPR(ArgumentObject[] arguments, LocalVariableSymbol[] locals, int startIndex, int endIndex) { }

	private Expr CreateArray(Expr callingObject, Expr optionalIndexerArguments) { }

	private Expr CreateCallingObjectForCall(ICSharpInvokeOrInvokeMemberBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	private static Expression CreateExpressionTreeFromResult(Expression[] parameters, Scope pScope, Expr pResult) { }

	private Expr CreateField(SymWithType swt, Expr callingObject) { }

	private ExprWithArgs CreateIndexer(SymWithType swt, Expr callingObject, Expr arguments, BindingFlag bindFlags) { }

	private Expr CreateLocal(Type type, bool isOut, LocalVariableSymbol local) { }

	private static ExprMemberGroup CreateMemberGroupExpr(string Name, Type[] typeArguments, Expr callingObject, SYMKIND kind) { }

	private Expr CreateProperty(SymWithType swt, Expr callingObject, BindingFlag flags) { }

	private bool DeferBinding(ICSharpBinder payload, ArgumentObject[] arguments, DynamicMetaObject[] args, LocalVariableSymbol[] locals, out DynamicMetaObject deferredBinding) { }

	internal ExprWithArgs DispatchPayload(ICSharpInvokeOrInvokeMemberBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals) { }

	private static ExprBoundLambda GenerateBoundLambda(Scope pScope, Expr call) { }

	private Type GetArgumentType(ICSharpBinder p, CSharpArgumentInfo argInfo, Expression param, DynamicMetaObject arg, int index) { }

	private static OperatorKind GetOperatorKind(ExpressionType p) { }

	private static OperatorKind GetOperatorKind(ExpressionType p, bool bIsLogical) { }

	private static LocalVariableSymbol[] PopulateLocalScope(ICSharpBinder payload, Scope pScope, ArgumentObject[] arguments, Expression[] parameterExpressions) { }

	internal static void PopulateSymbolTableWithPayloadInformation(ICSharpInvokeOrInvokeMemberBinder callOrInvoke, Type callingType, ArgumentObject[] arguments) { }

	private void ReorderArgumentsForNamedAndOptional(Expr callingObject, ExprWithArgs result) { }

	private Expr StripNamedArgument(Expr pArg) { }

	private Expr StripNamedArguments(Expr pArg) { }

}

