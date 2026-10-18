namespace System.Text.Json.Serialization.Metadata;

internal sealed class ReflectionMemberAccessor : MemberAccessor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Type type; //Field offset: 0x10
		public ConstructorInfo ctorInfo; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal object <CreateParameterlessConstructor>b__0() { }

		internal object <CreateParameterlessConstructor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0`1
	{
		public int parameterCount; //Field offset: 0x0
		public ConstructorInfo constructor; //Field offset: 0x0

		public <>c__DisplayClass1_0`1() { }

		internal T <CreateParameterizedConstructor>b__0(object[] arguments) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0`5
	{
		public int parameterCount; //Field offset: 0x0
		public ConstructorInfo constructor; //Field offset: 0x0

		public <>c__DisplayClass2_0`5() { }

		internal T <CreateParameterizedConstructor>b__0(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0`1
	{
		public MethodInfo addMethod; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal void <CreateAddMethodDelegate>b__0(TCollection collection, object element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0`1
	{
		public MethodInfo getMethodInfo; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		internal TProperty <CreatePropertyGetter>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0`1
	{
		public MethodInfo setMethodInfo; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

		internal void <CreatePropertySetter>b__0(object obj, TProperty value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0`1
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass8_0`1() { }

		internal TProperty <CreateFieldGetter>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0`1
	{
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass9_0`1() { }

		internal void <CreateFieldSetter>b__0(object obj, TProperty value) { }

	}


	public ReflectionMemberAccessor() { }

	public virtual Action CreateAddMethodDelegate() { }

	public virtual Func CreateFieldGetter(FieldInfo fieldInfo) { }

	public virtual Action CreateFieldSetter(FieldInfo fieldInfo) { }

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public virtual Func CreateImmutableDictionaryCreateRangeDelegate() { }

	[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
	public virtual Func CreateImmutableEnumerableCreateRangeDelegate() { }

	public virtual Func CreateParameterizedConstructor(ConstructorInfo constructor) { }

	public virtual ParameterizedConstructorDelegate CreateParameterizedConstructor(ConstructorInfo constructor) { }

	public virtual Func CreateParameterlessConstructor(Type type, ConstructorInfo ctorInfo) { }

	public virtual Func CreatePropertyGetter(PropertyInfo propertyInfo) { }

	public virtual Action CreatePropertySetter(PropertyInfo propertyInfo) { }

}

