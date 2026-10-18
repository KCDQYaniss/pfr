namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class ReflectionObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func ctor; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal object <Create>b__0(object[] args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_1
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public MethodCall call; //Field offset: 0x10

		public <>c__DisplayClass11_1() { }

		internal object <Create>b__1(object target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_2
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		public MethodCall call; //Field offset: 0x10

		public <>c__DisplayClass11_2() { }

		internal void <Create>b__2(object target, object arg) { }

	}

	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private readonly ObjectConstructor <Creator>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IDictionary <Members>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor Creator
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IDictionary Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private ReflectionObject(ObjectConstructor creator) { }

	public static ReflectionObject Create(Type t, string[] memberNames) { }

	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }

	[CompilerGenerated]
	public ObjectConstructor get_Creator() { }

	[CompilerGenerated]
	public IDictionary get_Members() { }

	public Type GetType(string member) { }

	public object GetValue(object target, string member) { }

	public void SetValue(object target, string member, object value) { }

}

