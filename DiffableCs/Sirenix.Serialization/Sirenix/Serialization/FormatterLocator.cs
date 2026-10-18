namespace Sirenix.Serialization;

public static class FormatterLocator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__9_0(FormatterInfo a, FormatterInfo b) { }

		internal int <.cctor>b__9_1(FormatterLocatorInfo a, FormatterLocatorInfo b) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllPossibleMissingAOTTypes>d__17 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Type type; //Field offset: 0x28
		public Type <>3__type; //Field offset: 0x30
		private Type[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private Type <arg>5__4; //Field offset: 0x48
		private IEnumerator <>7__wrap4; //Field offset: 0x50

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <GetAllPossibleMissingAOTTypes>d__17(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct FormatterInfo
	{
		public Type FormatterType; //Field offset: 0x0
		public Type TargetType; //Field offset: 0x8
		public Type WeakFallbackType; //Field offset: 0x10
		public bool AskIfCanFormatTypes; //Field offset: 0x18
		public int Priority; //Field offset: 0x1C

	}

	private struct FormatterLocatorInfo
	{
		public IFormatterLocator LocatorInstance; //Field offset: 0x0
		public int Priority; //Field offset: 0x8

	}

	private static readonly object StrongFormatters_LOCK; //Field offset: 0x0
	private static readonly object WeakFormatters_LOCK; //Field offset: 0x8
	private static readonly Dictionary FormatterInstances; //Field offset: 0x10
	private static readonly DoubleLookupDictionary StrongTypeFormatterMap; //Field offset: 0x18
	private static readonly DoubleLookupDictionary WeakTypeFormatterMap; //Field offset: 0x20
	private static readonly List FormatterLocators; //Field offset: 0x28
	private static readonly List FormatterInfos; //Field offset: 0x30

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the new IFormatterLocator interface instead, and register your custom locator with the RegisterFormatterLocator assembly attribute.", True)]
	public static event Func FormatterResolve
	{
		 add { } //Length: 62
		 remove { } //Length: 62
	}

	private static FormatterLocator() { }

	public static void add_FormatterResolve(Func value) { }

	private static IFormatter CreateFormatter(Type type, ISerializationPolicy policy, bool allowWeakFormatters) { }

	internal static List GetAllCompatiblePredefinedFormatters(Type type, ISerializationPolicy policy) { }

	[IteratorStateMachine(typeof(<GetAllPossibleMissingAOTTypes>d__17))]
	private static IEnumerable GetAllPossibleMissingAOTTypes(Type type) { }

	public static IFormatter GetFormatter(ISerializationPolicy policy) { }

	public static IFormatter GetFormatter(Type type, ISerializationPolicy policy) { }

	public static IFormatter GetFormatter(Type type, ISerializationPolicy policy, bool allowWeakFallbackFormatters) { }

	private static IFormatter GetFormatterInstance(Type type) { }

	private static void LogAOTError(Type type, Exception ex) { }

	public static void remove_FormatterResolve(Func value) { }

}

