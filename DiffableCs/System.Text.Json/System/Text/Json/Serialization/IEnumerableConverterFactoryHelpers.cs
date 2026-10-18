namespace System.Text.Json.Serialization;

[Extension]
internal static class IEnumerableConverterFactoryHelpers
{

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	private static Type GetImmutableDictionaryConstructingType(Type type) { }

	[Extension]
	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public static MethodInfo GetImmutableDictionaryCreateRangeMethod(Type type, Type keyType, Type valueType) { }

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	private static Type GetImmutableEnumerableConstructingType(Type type) { }

	[Extension]
	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public static MethodInfo GetImmutableEnumerableCreateRangeMethod(Type type, Type elementType) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2057:TypeGetType", Justification = "This method exists to allow for 'weak references' to the Stack and Queue types. If those types are used in the app, they will be preserved by the app and Type.GetType will return them. If those types are not used in the app, we don't want to preserve them here.")]
	private static Type GetTypeIfExists(string name) { }

	[Extension]
	public static bool IsNonGenericStackOrQueue(Type type) { }

}

