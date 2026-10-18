namespace Microsoft.CSharp.RuntimeBinder;

[Extension]
internal static class RuntimeBinderExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_1; //Field offset: 0x8
		public static Func <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__11_0(MemberInfo m1, MemberInfo m2) { }

		internal bool <.cctor>b__11_1(MemberInfo m1param, MemberInfo m2param) { }

		internal bool <IsGenericallyEquivalentTo>b__5_1(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <GetTypeIndexerName>b__0(PropertyInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public MemberInfo member1; //Field offset: 0x10
		public MemberInfo member2; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <IsGenericallyEquivalentTo>b__0(Type ta1, Type ta2) { }

	}

	private static Func s_MemberEquivalence; //Field offset: 0x0

	private static RuntimeBinderExtensions() { }

	[Extension]
	private static bool AreParametersEquivalent(MethodBase method1, MethodBase method2) { }

	[Extension]
	public static string GetIndexerName(Type type) { }

	private static string GetTypeIndexerName(Type type) { }

	[Extension]
	public static bool IsEquivalentTo(MemberInfo mi1, MemberInfo mi2) { }

	[Extension]
	private static bool IsEquivalentTo(ParameterInfo pi1, ParameterInfo pi2, MethodBase method1, MethodBase method2) { }

	[Extension]
	private static bool IsGenericallyEqual(Type t1, Type t2) { }

	[Extension]
	private static bool IsGenericallyEquivalentTo(Type t1, Type t2, MemberInfo member1, MemberInfo member2) { }

	[Extension]
	public static bool IsNullableType(Type type) { }

	[Extension]
	private static bool IsTypeParameterEquivalentToTypeInst(Type typeParam, Type typeInst, MemberInfo member) { }

}

