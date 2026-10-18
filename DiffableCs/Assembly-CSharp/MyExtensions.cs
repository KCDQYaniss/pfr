//Type is in global namespace

[Extension]
public static class MyExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__59_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Type <CreateDelegate>b__59_0(ParameterInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__16`1
	{
		public static readonly <>c__16 <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x0

		private static <>c__16`1() { }

		public <>c__16`1() { }

		internal float <Shuffle>b__16_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__37`1
	{
		public static readonly <>c__37 <>9; //Field offset: 0x0
		public static Func <>9__37_0; //Field offset: 0x0

		private static <>c__37`1() { }

		public <>c__37`1() { }

		internal int <Randomize>b__37_0(T item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0`2
	{
		public TKey key; //Field offset: 0x0

		public <>c__DisplayClass35_0`2() { }

		internal bool <GetValueByClosestKey>b__0(TKey k) { }

		internal bool <GetValueByClosestKey>b__1(TKey k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0`1
	{
		public int offset; //Field offset: 0x0
		public int index; //Field offset: 0x0
		public int length; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal int <Shift>b__0(T item) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetActionType; //Field offset: 0x0
		public static Func <1>__GetFuncType; //Field offset: 0x8

	}

	[CompilerGenerated]
	private static class <>o__35`2
	{
		public static CallSite <>p__0; //Field offset: 0x0
		public static CallSite <>p__1; //Field offset: 0x0
		public static CallSite <>p__2; //Field offset: 0x0
		public static CallSite <>p__3; //Field offset: 0x0
		public static CallSite <>p__4; //Field offset: 0x0
		public static CallSite <>p__5; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <DistinctBy>d__39`2 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private Func keySelector; //Field offset: 0x0
		public Func <>3__keySelector; //Field offset: 0x0
		private HashSet <seenKeys>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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
		public <DistinctBy>d__39`2(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[DebuggerHidden]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum ESideTurn
	{
		Left = 0,
		Right = 1,
	}

	private static Random rnd; //Field offset: 0x0
	private static readonly Color32 _increasingColor; //Field offset: 0x8
	private static readonly Color32 _decreasingColor; //Field offset: 0xC
	private static readonly Dictionary _enemyVisibleTypeSymbols; //Field offset: 0x10
	private static readonly Dictionary _bodyPartSymbols; //Field offset: 0x18

	private static MyExtensions() { }

	[Extension]
	public static void AddRange(HashSet collection, IEnumerable range) { }

	[Extension]
	public static List ApplyFilter(List list, int maxCount, Func predicate) { }

	[Extension]
	public static List ApplyFilter(List list, Func predicate) { }

	private static long Clamp(long value, long min, long max) { }

	[Extension]
	public static string ColoredWithPrefix(float value, bool positive, string ending = "") { }

	[Extension]
	public static Delegate CreateDelegate(MethodInfo methodInfo, object target) { }

	[Extension]
	public static void Deconstruct(KeyValuePair kvp, out TKey key, out TValue value) { }

	[Extension]
	[IteratorStateMachine(typeof(<DistinctBy>d__39`2))]
	public static IEnumerable DistinctBy(IEnumerable source, Func keySelector) { }

	[Extension]
	public static void ExecuteForEach(IEnumerable collection, Action action) { }

	[Extension]
	public static void ExecuteForEach(IReadOnlyDictionary dictionary, Action action) { }

	[Extension]
	public static void ForceAddValue(List l, T v) { }

	[Extension]
	public static void ForceAddValue(Dictionary d, T k, W v) { }

	[Extension]
	public static string FormatValue(float value, string formatString = "F2") { }

	[Extension]
	public static string GetSymbol(EEnemyPartVisibleType type) { }

	[Extension]
	public static string GetSymbol(BodyPartType type) { }

	[Extension]
	public static TValue GetValueByClosestKey(IDictionary dictionary, TKey key) { }

	public static float GreateRandom(float val) { }

	public static float GreateRandom(int val) { }

	public static float GreateRandom(float val, float fraction) { }

	public static bool InBounds(Vector3 pos, BoxCollider[] colliders) { }

	[Extension]
	public static bool IsEqual(Vector3 a, Vector3 b, float sqrThreshold) { }

	[Extension]
	public static bool IsNanOrInfinity(float value) { }

	[Extension]
	public static bool IsNullOrEmpty(IEnumerable collection) { }

	public static bool IsTrue01(float v) { }

	public static bool IsTrue100(float v) { }

	[Extension]
	public static string LevelFormat(int level) { }

	[Extension]
	public static float NextFloat(Random random, int min, int max) { }

	[Extension]
	public static T ParseEnum(string value) { }

	[Extension]
	public static int ParseToInt(string str) { }

	[Extension]
	public static string Prefix(float value) { }

	public static float Random(float a, float b) { }

	public static bool RandomBool(float chanceInPercent = 50) { }

	[CanBeNull]
	[Extension]
	public static T RandomElement(IEnumerable list) { }

	[Extension]
	public static IList RandomElement(IReadOnlyList list, Func condition, int count) { }

	[CanBeNull]
	[Extension]
	public static T RandomElement(IReadOnlyList list) { }

	[Extension]
	public static IList RandomElement(IReadOnlyList list, int count) { }

	public static Vector3 RandomHorizontal(float min, float max) { }

	public static Vector3 RandomHorizontalSing(float min, float max) { }

	public static int RandomInclude(int a, int b) { }

	[Extension]
	public static IEnumerable Randomize(IEnumerable source) { }

	public static int RandomSing() { }

	[Extension]
	public static string RemoveAllNewLines(string string) { }

	public static Vector3 Rotate90(Vector3 n, ESideTurn side) { }

	public static Vector3 Rotate90(Vector3 n, int side) { }

	[Extension]
	public static Vector3 RotateAroundPivot(Vector3 Point, Vector3 Pivot, Quaternion Angle) { }

	[Extension]
	public static void RotateAroundPivot(Transform Me, Vector3 Pivot, Quaternion Angle) { }

	[Extension]
	public static void RotateAroundPivot(Transform Me, Vector3 Pivot, Vector3 Euler) { }

	[Extension]
	public static Vector3 RotateAroundPivot(Vector3 Point, Vector3 Pivot, Vector3 Euler) { }

	public static void SearchTransform(Transform transform, List findObjects) { }

	[Extension]
	public static void SetCount(List list, int count) { }

	[Extension]
	public static void SetUnlockStatus(CanvasGroup group, bool value, bool setRaycast = true) { }

	[Extension]
	public static IList ShakeElements(List list) { }

	[Extension]
	public static IList ShakeElements(IReadOnlyList list, int count) { }

	[Extension]
	public static IEnumerable Shift(IEnumerable source, int offset) { }

	[Extension]
	public static List Shuffle(List l) { }

	[Extension]
	public static string SplitCurrencyNumber(float number, string delimiter = " ") { }

	[Extension]
	public static string SplitCurrencyNumber(int number, string delimiter = " ") { }

	public static string SplitNumber(long number, string delimiter = " ", int count = 3) { }

	[Extension]
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	[Extension]
	public static bool StartsWith(string test, IEnumerable variations) { }

	[Extension]
	public static string SubstringIfNecessary(string string, int count) { }

	[Extension]
	public static string SubstringIfNecessary(int int) { }

	[Extension]
	public static string ToTimeString(float seconds) { }

	[Extension]
	public static string ToTimeString(int seconds) { }

	private static string ToTimeStringInternal(float seconds) { }

	[Extension]
	public static bool TryGetKey(IDictionary instance, TValue value, out TKey key) { }

	[Extension]
	public static string WithPrefix(float value, string ending = "") { }

}

