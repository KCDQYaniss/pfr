namespace System.Text.Json.Serialization.Metadata;

internal abstract class MemberAccessor
{

	protected MemberAccessor() { }

	public abstract Action CreateAddMethodDelegate() { }

	public abstract Func CreateFieldGetter(FieldInfo fieldInfo) { }

	public abstract Action CreateFieldSetter(FieldInfo fieldInfo) { }

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public abstract Func CreateImmutableDictionaryCreateRangeDelegate() { }

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public abstract Func CreateImmutableEnumerableCreateRangeDelegate() { }

	public abstract Func CreateParameterizedConstructor(ConstructorInfo constructor) { }

	public abstract ParameterizedConstructorDelegate CreateParameterizedConstructor(ConstructorInfo constructor) { }

	public abstract Func CreateParameterlessConstructor(Type type, ConstructorInfo constructorInfo) { }

	public abstract Func CreatePropertyGetter(PropertyInfo propertyInfo) { }

	public abstract Action CreatePropertySetter(PropertyInfo propertyInfo) { }

}

