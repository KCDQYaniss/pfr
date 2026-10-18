namespace System.Text.Json.Reflection;

[Extension]
internal static class ReflectionExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ICollection <GetSortedTypeHierarchy>b__33_0(Type t) { }

	}

	private static readonly Type s_nullableType; //Field offset: 0x0

	private static ReflectionExtensions() { }

	[Extension]
	public static object CreateInstanceNoWrapExceptions(Type type, Type[] parameterTypes, object[] parameters) { }

	private static string GetBaseNameFromGenericType(Type genericType) { }

	[Extension]
	public static Type GetCompatibleGenericBaseClass(Type type, Type baseType) { }

	[Extension]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The 'interfaceType' must exist and so trimmer kept it. In which case It also kept it on any type which implements it. The below call to GetInterfaces may return fewer results when trimmed but it will return the 'interfaceType' if the type implemented it, even after trimming.")]
	public static Type GetCompatibleGenericInterface(Type type, Type interfaceType) { }

	[Extension]
	public static object GetDefaultValue(ParameterInfo parameterInfo) { }

	[Extension]
	public static string GetImmutableDictionaryConstructingTypeName(Type type) { }

	[Extension]
	public static string GetImmutableEnumerableConstructingTypeName(Type type) { }

	[Extension]
	[RequiresUnreferencedCode("Should only be used by the reflection-based serializer.")]
	public static Type[] GetSortedTypeHierarchy(Type type) { }

	[Extension]
	public static TAttribute GetUniqueCustomAttribute(MemberInfo memberInfo, bool inherit) { }

	[Extension]
	private static bool HasCustomAttributeWithName(MemberInfo memberInfo, string fullName, bool inherit) { }

	private static bool HasJsonConstructorAttribute(ConstructorInfo constructorInfo) { }

	[Extension]
	public static bool HasRequiredMemberAttribute(MemberInfo memberInfo) { }

	[Extension]
	public static bool HasSetsRequiredMembersAttribute(MemberInfo memberInfo) { }

	[Extension]
	public static bool IsAssignableFromInternal(Type type, Type from) { }

	[Extension]
	public static bool IsImmutableDictionaryType(Type type) { }

	[Extension]
	public static bool IsImmutableEnumerableType(Type type) { }

	[Extension]
	public static bool IsInSubtypeRelationshipWith(Type type, Type other) { }

	[Extension]
	public static bool IsKeyValuePair(Type type) { }

	[Extension]
	public static bool IsNullableOfT(Type type) { }

	[Extension]
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	public static bool TryGetDeserializationConstructor(Type type, bool useDefaultCtorInAnnotatedStructs, out ConstructorInfo deserializationCtor) { }

}

