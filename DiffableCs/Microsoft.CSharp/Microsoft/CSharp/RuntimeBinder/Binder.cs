namespace Microsoft.CSharp.RuntimeBinder;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public static class Binder
{

	public static CallSiteBinder BinaryOperation(CSharpBinderFlags flags, ExpressionType operation, Type context, IEnumerable argumentInfo) { }

	public static CallSiteBinder Convert(CSharpBinderFlags flags, Type type, Type context) { }

	public static CallSiteBinder GetMember(CSharpBinderFlags flags, string name, Type context, IEnumerable argumentInfo) { }

	public static CallSiteBinder InvokeMember(CSharpBinderFlags flags, string name, IEnumerable typeArguments, Type context, IEnumerable argumentInfo) { }

	public static CallSiteBinder SetMember(CSharpBinderFlags flags, string name, Type context, IEnumerable argumentInfo) { }

}

