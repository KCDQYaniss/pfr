namespace Sirenix.Serialization;

[Extension]
public static class DictionaryKeyUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <.cctor>b__12_0(Assembly ass) { }

		internal bool <.cctor>b__12_1(<>f__AnonymousType0 n) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Assembly ass; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal <>f__AnonymousType0 <.cctor>b__2(object attr) { }

	}

	[CompilerGenerated]
	private sealed class <GetPersistentPathKeyTypes>d__14 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private Type <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28
		private Enumerator <>7__wrap2; //Field offset: 0x40

		private override Type System.Collections.Generic.IEnumerator<System.Type>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetPersistentPathKeyTypes>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

		[DebuggerHidden]
		private override Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class FallbackKeyComparer`1 : IComparer
	{

		public FallbackKeyComparer`1() { }

		public override int Compare(T x, T y) { }

	}

	internal class KeyComparer`1 : IComparer
	{
		public static readonly KeyComparer Default; //Field offset: 0x0
		private readonly IComparer actualComparer; //Field offset: 0x0

		private static KeyComparer`1() { }

		public KeyComparer`1() { }

		public override int Compare(T x, T y) { }

	}

	private class UnityObjectKeyComparer`1 : IComparer
	{

		public UnityObjectKeyComparer`1() { }

		public override int Compare(T x, T y) { }

	}

	private static readonly Dictionary GetSupportedDictionaryKeyTypesResults; //Field offset: 0x0
	private static readonly HashSet BaseSupportedDictionaryKeyTypes; //Field offset: 0x8
	private static readonly HashSet AllowedSpecialKeyStrChars; //Field offset: 0x10
	private static readonly Dictionary TypeToKeyPathProviders; //Field offset: 0x18
	private static readonly Dictionary IDToKeyPathProviders; //Field offset: 0x20
	private static readonly Dictionary ProviderToID; //Field offset: 0x28
	private static readonly Dictionary ObjectsToTempKeys; //Field offset: 0x30
	private static readonly Dictionary TempKeysToObjects; //Field offset: 0x38
	private static long tempKeyCounter; //Field offset: 0x40

	private static DictionaryKeyUtility() { }

	[Extension]
	private static string FromTo(string str, int from, int to) { }

	public static string GetDictionaryKeyString(object key) { }

	public static object GetDictionaryKeyValue(string keyStr, Type expectedType) { }

	[IteratorStateMachine(typeof(<GetPersistentPathKeyTypes>d__14))]
	public static IEnumerable GetPersistentPathKeyTypes() { }

	public static bool KeyTypeSupportsPersistentPaths(Type type) { }

	private static void LogInvalidKeyPathProvider(Type type, Assembly assembly, string reason) { }

	private static bool PrivateIsSupportedDictionaryKeyType(Type type) { }

}

