namespace Sirenix.Utilities;

public static class DeepReflection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0`1
	{
		public Func del; //Field offset: 0x0

		public <>c__DisplayClass11_0`1() { }

		internal TResult <CreateWeakInstanceValueGetter>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0`1
	{
		public Func slowDelegate; //Field offset: 0x0

		public <>c__DisplayClass12_0`1() { }

		internal TResult <CreateValueGetter>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0`2
	{
		public Func slowDelegate; //Field offset: 0x0

		public <>c__DisplayClass13_0`2() { }

		internal TResult <CreateValueGetter>b__0(TTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0`2
	{
		public Func func; //Field offset: 0x0

		public <>c__DisplayClass14_0`2() { }

		internal object <CreateWeakAliasForInstanceGetDelegate1>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0`2
	{
		public Func func; //Field offset: 0x0

		public <>c__DisplayClass15_0`2() { }

		internal TResult <CreateWeakAliasForInstanceGetDelegate2>b__0(object obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0`1
	{
		public Func func; //Field offset: 0x0

		public <>c__DisplayClass16_0`1() { }

		internal object <CreateWeakAliasForStaticGetDelegate>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0`2
	{
		public Action func; //Field offset: 0x0

		public <>c__DisplayClass17_0`2() { }

		internal void <CreateWeakAliasForInstanceSetDelegate1>b__0(object obj, object arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0`2
	{
		public Action func; //Field offset: 0x0

		public <>c__DisplayClass18_0`2() { }

		internal void <CreateWeakAliasForInstanceSetDelegate2>b__0(object obj, TArg1 arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0`1
	{
		public Action func; //Field offset: 0x0

		public <>c__DisplayClass19_0`1() { }

		internal void <CreateWeakAliasForStaticSetDelegate>b__0(object arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public List memberPath; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal object <CreateSlowDeepStaticValueGetterDelegate>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public List memberPath; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal object <CreateSlowDeepInstanceValueGetterDelegate>b__0(object instance) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public List memberPath; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal void <CreateSlowDeepInstanceValueSetterDelegate>b__0(object instance, object arg) { }

	}

	private struct PathStep
	{
		public readonly PathStepType StepType; //Field offset: 0x0
		public readonly MemberInfo Member; //Field offset: 0x8
		public readonly int ElementIndex; //Field offset: 0x10
		public readonly Type ElementType; //Field offset: 0x18
		public readonly MethodInfo StrongListGetItemMethod; //Field offset: 0x20

		public PathStep(MemberInfo member) { }

		public PathStep(int elementIndex) { }

		public PathStep(int elementIndex, Type strongListElementType, bool isArray) { }

	}

	private enum PathStepType
	{
		Member = 0,
		WeakListElement = 1,
		StrongListElement = 2,
		ArrayElement = 3,
	}

	private static MethodInfo WeakListGetItem; //Field offset: 0x0
	private static MethodInfo WeakListSetItem; //Field offset: 0x8
	private static MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo; //Field offset: 0x10
	private static MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo; //Field offset: 0x18
	private static MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo; //Field offset: 0x20
	private static MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo; //Field offset: 0x28

	private static DeepReflection() { }

	private static Delegate CreateEmittedDeepValueGetterDelegate(string path, Type rootType, Type resultType, List memberPath, bool rootIsStatic) { }

	private static Func CreateSlowDeepInstanceValueGetterDelegate(List memberPath) { }

	private static Action CreateSlowDeepInstanceValueSetterDelegate(List memberPath) { }

	private static Func CreateSlowDeepStaticValueGetterDelegate(List memberPath) { }

	public static Func CreateValueGetter(Type rootType, string path, bool allowEmit = true) { }

	public static Func CreateValueGetter(string path, bool allowEmit = true) { }

	private static Func CreateWeakAliasForInstanceGetDelegate1(Func func) { }

	private static Func CreateWeakAliasForInstanceGetDelegate2(Func func) { }

	private static Action CreateWeakAliasForInstanceSetDelegate1(Action func) { }

	private static Action CreateWeakAliasForInstanceSetDelegate2(Action func) { }

	private static Func CreateWeakAliasForStaticGetDelegate(Func func) { }

	private static Action CreateWeakAliasForStaticSetDelegate(Action func) { }

	public static Func CreateWeakInstanceValueGetter(Type rootType, string path, bool allowEmit = true) { }

	public static Func CreateWeakInstanceValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true) { }

	public static Action CreateWeakInstanceValueSetter(Type rootType, Type argType, string path, bool allowEmit = true) { }

	public static Func CreateWeakStaticValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true) { }

	private static List GetMemberPath(Type rootType, ref Type resultType, string path, out bool rootIsStatic, bool isSet) { }

	private static MemberInfo GetStepMember(Type owningType, string name, bool expectMethod) { }

	private static object SlowGetMemberValue(PathStep step, object instance) { }

	private static void SlowSetMemberValue(PathStep step, object instance, object value) { }

}

