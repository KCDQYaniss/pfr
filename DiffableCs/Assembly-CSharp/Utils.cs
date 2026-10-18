//Type is in global namespace

[Extension]
public static class Utils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0`1
	{
		public Action action; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public <>c__DisplayClass81_0`1() { }

		internal void <Bind>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0`2
	{
		public Action action; //Field offset: 0x0
		public T1 value1; //Field offset: 0x0

		public <>c__DisplayClass82_0`2() { }

		internal void <Bind>b__0(T2 value2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0`2
	{
		public Action action; //Field offset: 0x0
		public T1 value1; //Field offset: 0x0
		public T2 value2; //Field offset: 0x0

		public <>c__DisplayClass83_0`2() { }

		internal void <Bind>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0`1
	{
		public Action action; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public <>c__DisplayClass84_0`1() { }

		internal void <BindToUnityAction>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0`2
	{
		public Action action; //Field offset: 0x0
		public T1 value1; //Field offset: 0x0
		public T2 value2; //Field offset: 0x0

		public <>c__DisplayClass85_0`2() { }

		internal void <BindToUnityAction>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_Wait>d__92 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float seconds; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <Co_Wait>d__92(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Co_WaitForEndOfFrame>d__94 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <Co_WaitForEndOfFrame>d__94(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Co_WaitFrames>d__93 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int framesCount; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <Co_WaitFrames>d__93(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LoadAndAssignSprite>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool resetImage; //Field offset: 0x20
		public Image image; //Field offset: 0x28
		public string url; //Field offset: 0x30
		public IImageLoader session; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadIconSprite>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string imageUrl; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum SideTurn
	{
		left = 0,
		right = 1,
	}

	public const float LOW_ACCURACY_DELTA = 0.001; //Field offset: 0x0
	private static bool haveNextNextGaussian; //Field offset: 0x0
	public const float MAX_NAVMESH_HIT_OFFSET = 0.04; //Field offset: 0x0
	private static float nextNextGaussian; //Field offset: 0x4
	private static readonly Random random; //Field offset: 0x8
	private static bool uselast; //Field offset: 0x10
	private static double next_gaussian; //Field offset: 0x18
	private static readonly Dictionary _spriteTasks; //Field offset: 0x20

	private static Utils() { }

	[Extension]
	public static Vector3 Abs(Vector3 vector) { }

	public static float AngOfNormazedVectors(Vector3 a, Vector3 b) { }

	public static float AngOfNormazedVectorsCoef(Vector3 a, Vector3 b) { }

	[Extension]
	public static bool ApproxEquals(float value, float value2) { }

	[Extension]
	public static bool ApproxEquals(double value, double value2) { }

	public static Action Bind(Action action, T value) { }

	public static Action Bind(Action action, T1 value1) { }

	public static Action Bind(Action action, T1 value1, T2 value2) { }

	public static UnityAction BindToUnityAction(Action action, T1 value1, T2 value2) { }

	public static UnityAction BindToUnityAction(Action action, T value) { }

	public static double BoxMuller() { }

	public static double BoxMuller(double mean, double standard_deviation) { }

	[Extension]
	public static Vector2 Ceil(Vector2 vector) { }

	[Extension]
	public static Vector3 Ceil(Vector3 vector) { }

	[Extension]
	public static Vector3 Clamp(Vector3 vector, Vector3 min, Vector3 max) { }

	[Extension]
	public static double Clamp(double value, double limit1, double limit2) { }

	[Extension]
	public static double Clamp01(double value) { }

	[Extension]
	public static float Clamp180(float value) { }

	[Extension]
	public static Vector3 Clamp180(Vector3 vector3) { }

	[Extension]
	public static Vector3 ClampVerticalAngle(Vector3 vector, float maxAngleTan) { }

	[Extension]
	public static void ClearTransform(Transform t) { }

	[Extension]
	public static void ClearTransformImmediate(Transform t) { }

	[IteratorStateMachine(typeof(<Co_Wait>d__92))]
	public static IEnumerator Co_Wait(float seconds, Action callback) { }

	[IteratorStateMachine(typeof(<Co_WaitForEndOfFrame>d__94))]
	private static IEnumerator Co_WaitForEndOfFrame(Action callback) { }

	[IteratorStateMachine(typeof(<Co_WaitFrames>d__93))]
	private static IEnumerator Co_WaitFrames(int framesCount, Action callback) { }

	public static Func CreateGetter(FieldInfo fieldInfo, Type objectType) { }

	public static Func CreateGetter(FieldInfo fieldInfo) { }

	public static DynamicMethod CreateGetterFieldDynamicMethod(FieldInfo fieldInfo, Type objectType, Type valueType) { }

	public static Action CreateSetter(FieldInfo field, Type objectType) { }

	public static Action CreateSetter(FieldInfo field) { }

	private static DynamicMethod CreateSetterFieldDynamicMethod(FieldInfo field, Type objType, Type valueType) { }

	[Extension]
	public static void DecomposeSwingTwist(Quaternion quaternion, Vector3 twistNormal, out Quaternion swing, out Quaternion twist) { }

	[Extension]
	public static Vector3 DeltaAngle(Vector3 from, Vector3 to) { }

	[Extension]
	public static Vector3 Divide(Vector3 divisible, Vector3 divisor) { }

	[Extension]
	public static Vector2 Divide(Vector2 divisible, Vector2 divisor) { }

	[Extension]
	public static double ExactLength(AudioClip clip) { }

	public static Transform GetChildName(Transform transform, string name, string nocontains = "") { }

	public static List GetChildsName(Transform transform, string name, bool onlyActive = true) { }

	private static Func GetFunction(MethodInfo methodInfo) { }

	[Extension]
	public static T GetRandomItem(List list, T excludedItem) { }

	[Extension]
	public static T GetRandomItem(List list) { }

	public static EHysteresisState Hysteresis(float input, float threshold, float negativeDeviation, float positiveDeviation) { }

	public static EHysteresisState Hysteresis(float input, float threshold, float deviation) { }

	public static bool IsAngLessNormalized(Vector3 a, Vector3 b, float cos) { }

	public static bool IsCloseDebug(Vector3 v, float x, float z) { }

	public static bool IsCloseDebug(Vector3 v, float x, float y, float z) { }

	[Extension]
	public static bool IsDisplayChildCount(EViewListType type) { }

	[Extension]
	public static bool IsIdBased(EFilterType type) { }

	public static bool IsOdd(int value) { }

	public static bool IsOnNavMesh(Vector3 v, float dist = 0.04) { }

	[Extension]
	public static bool IsUpdateChildStatus(EViewListType type) { }

	[Extension]
	public static bool IsZero(Vector3 vector) { }

	[Extension]
	public static bool IsZero(Vector2 vector) { }

	[Extension]
	public static bool IsZero(double value) { }

	[Extension]
	public static bool IsZero(float value) { }

	[Extension]
	public static float Length(Quaternion quaternion) { }

	[Extension]
	public static float Lerp(Vector2 vector, float t) { }

	[AsyncStateMachine(typeof(<LoadAndAssignSprite>d__64))]
	[Extension]
	public static Task LoadAndAssignSprite(IImageLoader session, string url, Image image, bool resetImage, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<LoadIconSprite>d__65))]
	public static Task LoadIconSprite(IImageLoader session, string imageUrl) { }

	public static string LoadTextResource(string name) { }

	[Extension]
	public static bool LowAccuracyApprox(float value, float value2) { }

	public static Mesh MakeFullScreenMesh(Camera cam) { }

	[Extension]
	public static Vector3 Multiply(Vector3 multiplier1, Vector3 multiplier2) { }

	[Extension]
	public static Vector2 Multiply(Vector2 multiplier1, Vector2 multiplier2) { }

	[Extension]
	public static bool Negative(float value) { }

	[Extension]
	public static bool Negative(double value) { }

	[Extension]
	public static void Normalize(Quaternion quaternion) { }

	public static Vector3 NormalizeFast(Vector3 v) { }

	public static Vector3 NormalizeFastSelf(Vector3 v) { }

	public static void NormalizeFastSelf(ref Vector3 v) { }

	[Extension]
	public static bool Positive(float value) { }

	[Extension]
	public static bool Positive(double value) { }

	public static void ProcessException(Exception exception) { }

	public static float RandomNormal(float min, float max) { }

	public static bool RemoveFromQueue(T item, Queue q) { }

	public static Vector3 Rotate90(Vector3 n, SideTurn side) { }

	public static Vector2 RotateOnAng(Vector2 b, float a) { }

	public static Vector3 RotateOnAngUp(Vector3 b, float angDegree) { }

	public static Vector3 RotateVectorOnAngToZ(Vector3 d, float angDegree) { }

	[Extension]
	public static Rect Scale(Rect rect, Vector2 scale) { }

	public static List ServerOptimizeCountWaves(List wavesProfiles) { }

	private static Action SetAction(MethodInfo methodInfo) { }

	[Extension]
	public static void SetCanvasRestriction(CanvasScaler scaler, float scaleFactor) { }

	public static float SqrDistHorizontal(Vector3 a, Vector3 b) { }

	[Extension]
	public static IEnumerable TakeLast(IEnumerable collection, int n) { }

	public static void UnloadAssetFromBundle(AssetBundle bundle) { }

	[Extension]
	public static Coroutine WaitForEndOfFrame(MonoBehaviour component, Action action) { }

	[Extension]
	public static Coroutine WaitFrames(MonoBehaviour component, int frames, Action callback) { }

	[Extension]
	public static Coroutine WaitOneFrame(MonoBehaviour component, Action callback) { }

	[Extension]
	public static Coroutine WaitSeconds(MonoBehaviour component, float time, Action action) { }

	[Extension]
	public static bool ZeroOrNegative(float value) { }

	[Extension]
	public static bool ZeroOrPositive(float value) { }

}

