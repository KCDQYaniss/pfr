namespace Microsoft.CSharp.RuntimeBinder;

internal static class Error
{

	internal static Exception ArgumentNull(string paramName) { }

	internal static Exception BindCallToConditionalMethod(object p0) { }

	internal static Exception BindInvokeFailedNonDelegate() { }

	internal static Exception BindPropertyFailedEvent(object p0) { }

	internal static Exception BindPropertyFailedMethodGroup(object p0) { }

	internal static Exception BindStaticRequiresType(string paramName) { }

	internal static Exception BindToVoidMethodButExpectResult() { }

	internal static Exception DynamicArgumentNeedsValue(string paramName) { }

	internal static Exception InternalCompilerError() { }

	internal static Exception NullReferenceOnMemberException() { }

}

