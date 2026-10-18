namespace System.Text.Json;

internal static class ThrowHelper
{

	public static void AddJsonExceptionInformation(ref WriteStack state, JsonException ex) { }

	private static ArgumentException GetArgumentException(string message) { }

	public static ArgumentException GetArgumentException_ReadInvalidUTF16(EncoderFallbackException innerException) { }

	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(string parameterName, string message) { }

	public static InvalidOperationException GetInvalidOperationException(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType) { }

	public static InvalidOperationException GetInvalidOperationException(string message, Exception innerException) { }

	private static InvalidOperationException GetInvalidOperationException(string message) { }

	public static Exception GetInvalidOperationException_NoMetadataForTypeProperties(IJsonTypeInfoResolver resolver, Type type) { }

	public static InvalidOperationException GetInvalidOperationException_ReadInvalidUTF8(DecoderFallbackException innerException = null) { }

	internal static InvalidOperationException GetJsonElementWrongTypeException(JsonValueKind expectedType, JsonValueKind actualType) { }

	public static NotSupportedException GetNotSupportedException_AmbiguousMetadataForType(Type type, Type match1, Type match2) { }

	public static NotSupportedException GetNotSupportedException_CollectionIsReadOnly() { }

	internal static string GetPrintableString(byte value) { }

	private static string GetResourceString(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType) { }

	private static bool IsPrintable(byte value) { }

	[DoesNotReturn]
	public static void ReThrowWithPath(ref WriteStack state, Exception ex) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_ArrayTooSmall(string paramName) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_DeserializeWrongType(Type type, object value) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_DuplicateKey(string paramName, string propertyName) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_InvalidUTF16(int charAsInt) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_InvalidUTF8(ReadOnlySpan value) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_NodeValueNotAllowed(string paramName) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_PropertyNameTooLarge(int tokenLength) { }

	[DoesNotReturn]
	public static void ThrowArgumentException_ValueNotSupported() { }

	[DoesNotReturn]
	public static void ThrowArgumentException_ValueTooLarge(long tokenLength) { }

	[DoesNotReturn]
	public static void ThrowArgumentNullException(string parameterName) { }

	[DoesNotReturn]
	public static void ThrowArgumentOutOfRangeException_ArrayIndexNegative(string paramName) { }

	[DoesNotReturn]
	public static void ThrowArgumentOutOfRangeException_MaxDepthMustBePositive(string parameterName) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException(ExceptionResource resource, int currentDepth, int maxDepth, byte token, JsonTokenType tokenType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException(string message) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException(int currentDepth, int maxDepth) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_CannotSerializeInvalidType(Type typeToConvert, Type declaringType, MemberInfo memberInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(Type runtimePropertyType, JsonConverter jsonConverter) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_CreateObjectConverterNotCompatible(Type type) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_DefaultTypeInfoResolverImmutable() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_DerivedTypeIsAlreadySpecified(Type baseType, Type derivedType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_DerivedTypeNotSupported(Type baseType, Type derivedType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(string propertyName, JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ExtensionDataConflictsWithUnmappedMemberHandling(Type classType, JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(string clrPropertyName, Type propertyDeclaringType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_InvalidCustomTypeDiscriminatorPropertyName() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_InvalidEnumTypeWithSpecialChar(Type enumType, string enumName) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonIncludeOnInaccessibleProperty(string memberName, Type declaringType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonPropertyInfoIsBoundToDifferentJsonTypeInfo(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonPropertyRequiredAndExtensionData(JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonPropertyRequiredAndNotDeserializable(JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonSerializerIsReflectionDisabled() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonSerializerOptionsNoTypeInfoResolverSpecified() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(JsonTypeInfoKind kind) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(Type parentType, string parameterName, string firstMatchName, string secondMatchName) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NamingPolicyReturnNull(JsonNamingPolicy namingPolicy) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NeedLargerSpan() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NodeAlreadyHasParent() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NodeCycleDetected() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NodeWrongType(string typeName) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NoMetadataForTypeProperties(IJsonTypeInfoResolver resolver, Type type) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPopulateNotSupportedByConverter(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReadOnlyMember(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReferenceHandling() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyMustHaveAGetter(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ObjectCreationHandlingPropertyValueTypeMustHaveASetter(JsonPropertyInfo propertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_PolymorphicTypeConfigurationDoesNotSpecifyDerivedTypes(Type baseType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ReadIncompleteUTF16() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ReadInvalidUTF16(int charAsInt) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ResolverTypeInfoOptionsNotCompatible() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_ResolverTypeNotCompatible(Type requestedType, Type actualType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationConverterNotCompatible(Type converterType, Type type) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(Type classType, MemberInfo memberInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(Type classTypeAttributeIsOn, MemberInfo memberInfo, Type typeToConvert) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationDuplicateAttribute(Type attribute, MemberInfo memberInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(Type classType, Type attribute) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(Type classType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializerConverterFactoryReturnsJsonConverterFactorty(Type converterType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializerConverterFactoryReturnsNull(Type converterType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializerOptionsReadOnly(JsonSerializerContext context) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializerPropertyNameConflict(Type type, string propertyName) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_SerializerPropertyNameNull(JsonPropertyInfo jsonPropertyInfo) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_TypeDicriminatorIdIsAlreadySpecified(Type baseType, object typeDiscriminator) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_TypeDoesNotSupportPolymorphism(Type baseType) { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_TypeInfoImmutable() { }

	[DoesNotReturn]
	public static void ThrowInvalidOperationException_TypeInfoResolverChainImmutable() { }

	[DoesNotReturn]
	internal static void ThrowJsonElementWrongTypeException(JsonTokenType expectedType, JsonTokenType actualType) { }

	[DoesNotReturn]
	public static void ThrowJsonException(string message = null) { }

	[DoesNotReturn]
	public static void ThrowJsonException_DeserializeUnableToConvertValue(Type propertyType) { }

	[DoesNotReturn]
	public static void ThrowJsonException_SerializationConverterWrite(JsonConverter converter) { }

	[DoesNotReturn]
	public static void ThrowJsonException_SerializerCycleDetected(int maxDepth) { }

	[DoesNotReturn]
	public static void ThrowMissingMemberException_MissingFSharpCoreMember(string missingFsharpCoreMember) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException(ref WriteStack state, NotSupportedException ex) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_BaseConverterDoesNotSupportMetadata(Type derivedType) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_CollectionIsReadOnly() { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_ConstructorContainsNullParameterNames(Type declaringType) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_DerivedConverterDoesNotSupportMetadata(Type derivedType) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_DictionaryKeyTypeNotSupported(Type keyType, JsonConverter converter) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_NoMetadataForType(Type type, IJsonTypeInfoResolver resolver) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors() { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_RuntimeTypeDiamondAmbiguity(Type baseType, Type runtimeType, Type derivedType1, Type derivedType2) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_RuntimeTypeNotSupported(Type baseType, Type runtimeType) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_SerializationNotSupported(Type propertyType) { }

	[DoesNotReturn]
	public static void ThrowNotSupportedException_TypeRequiresAsyncSerialization(Type propertyType) { }

	[DoesNotReturn]
	public static void ThrowObjectDisposedException_JsonDocument() { }

	[DoesNotReturn]
	public static void ThrowObjectDisposedException_Utf8JsonWriter() { }

	[DoesNotReturn]
	public static void ThrowOutOfMemoryException(uint capacity) { }

	[DoesNotReturn]
	public static void ThrowOutOfMemoryException_BufferMaximumSizeExceeded(uint capacity) { }

}

