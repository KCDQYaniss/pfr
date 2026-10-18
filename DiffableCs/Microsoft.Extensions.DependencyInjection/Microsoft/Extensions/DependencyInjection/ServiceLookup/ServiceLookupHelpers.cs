namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Nullable(0)]
[NullableContext(1)]
internal static class ServiceLookupHelpers
{
	private static readonly MethodInfo ArrayEmptyMethodInfo; //Field offset: 0x0
	internal static readonly MethodInfo InvokeFactoryMethodInfo; //Field offset: 0x8
	internal static readonly MethodInfo CaptureDisposableMethodInfo; //Field offset: 0x10
	internal static readonly MethodInfo TryGetValueMethodInfo; //Field offset: 0x18
	internal static readonly MethodInfo ResolveCallSiteAndScopeMethodInfo; //Field offset: 0x20
	internal static readonly MethodInfo AddMethodInfo; //Field offset: 0x28
	internal static readonly MethodInfo MonitorEnterMethodInfo; //Field offset: 0x30
	internal static readonly MethodInfo MonitorExitMethodInfo; //Field offset: 0x38

	private static ServiceLookupHelpers() { }

	[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2060:MakeGenericMethod", Justification = "Calling Array.Empty<T>() is safe since the T doesn't have trimming annotations.")]
	internal static MethodInfo GetArrayEmptyMethodInfo(Type itemType) { }

}

