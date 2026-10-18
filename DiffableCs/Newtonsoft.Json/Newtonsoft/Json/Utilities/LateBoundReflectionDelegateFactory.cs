namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Nullable(0)]
		public ConstructorInfo c; //Field offset: 0x10
		[Nullable(0)]
		public MethodBase method; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal object <CreateParameterizedConstructor>b__0(object[] a) { }

		internal object <CreateParameterizedConstructor>b__1(object[] a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0`1
	{
		[Nullable(0)]
		public ConstructorInfo c; //Field offset: 0x0
		[Nullable(0)]
		public MethodBase method; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		[NullableContext(0)]
		internal object <CreateMethodCall>b__0(T o, object[] a) { }

		[NullableContext(0)]
		internal object <CreateMethodCall>b__1(T o, object[] a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0`1
	{
		[Nullable(0)]
		public Type type; //Field offset: 0x0
		[Nullable(0)]
		public ConstructorInfo constructorInfo; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		[NullableContext(0)]
		internal T <CreateDefaultConstructor>b__0() { }

		[NullableContext(0)]
		internal T <CreateDefaultConstructor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0`1
	{
		[Nullable(0)]
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		[NullableContext(0)]
		internal object <CreateGet>b__0(T o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0`1
	{
		[Nullable(0)]
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

		[NullableContext(0)]
		internal object <CreateGet>b__0(T o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0`1
	{
		[Nullable(0)]
		public FieldInfo fieldInfo; //Field offset: 0x0

		public <>c__DisplayClass8_0`1() { }

		[NullableContext(0)]
		internal void <CreateSet>b__0(T o, object v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0`1
	{
		[Nullable(0)]
		public PropertyInfo propertyInfo; //Field offset: 0x0

		public <>c__DisplayClass9_0`1() { }

		[NullableContext(0)]
		internal void <CreateSet>b__0(T o, object v) { }

	}

	private static readonly LateBoundReflectionDelegateFactory _instance; //Field offset: 0x0

	internal static ReflectionDelegateFactory Instance
	{
		internal get { } //Length: 83
	}

	private static LateBoundReflectionDelegateFactory() { }

	public LateBoundReflectionDelegateFactory() { }

	public virtual Func CreateDefaultConstructor(Type type) { }

	public virtual Func CreateGet(PropertyInfo propertyInfo) { }

	public virtual Func CreateGet(FieldInfo fieldInfo) { }

	public virtual MethodCall CreateMethodCall(MethodBase method) { }

	public virtual ObjectConstructor CreateParameterizedConstructor(MethodBase method) { }

	public virtual Action CreateSet(FieldInfo fieldInfo) { }

	public virtual Action CreateSet(PropertyInfo propertyInfo) { }

	internal static ReflectionDelegateFactory get_Instance() { }

}

