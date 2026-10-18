//Type is in global namespace

[Extension]
public static class UnityUtils
{
	[CompilerGenerated]
	private sealed class <>c__29`1
	{
		public static readonly <>c__29 <>9; //Field offset: 0x0
		public static Func <>9__29_0; //Field offset: 0x0
		public static Func <>9__29_1; //Field offset: 0x0

		private static <>c__29`1() { }

		public <>c__29`1() { }

		internal bool <GetAllComponentsOfType>b__29_0(Scene s) { }

		internal IEnumerable <GetAllComponentsOfType>b__29_1(Scene s) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetSceneAt; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <DoMap>d__14`1 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable t; //Field offset: 0x0
		public IEnumerable <>3__t; //Field offset: 0x0
		private Action action; //Field offset: 0x0
		public Action <>3__action; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 172
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 171
		}

		[DebuggerHidden]
		public <DoMap>d__14`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal static class RRTExtension
	{

		public static Color ToLossColor(int loss) { }

		public static Color ToPlayerRTTColor(double rtt) { }

		public static Color ToRTTColor(double rtt) { }

	}

	public static bool False; //Field offset: 0x0
	public static bool True; //Field offset: 0x1
	public static bool DisabledForNow; //Field offset: 0x2
	public static readonly Vector2 Vector2Zero; //Field offset: 0x4
	public static readonly Vector3 Vector3Zero; //Field offset: 0xC
	public static readonly Vector4 Vector4Zero; //Field offset: 0x18
	public static readonly Vector3 Vector3Up; //Field offset: 0x28
	public static readonly Vector3 Vector3Down; //Field offset: 0x34
	public static readonly Color WHITE_COLOR; //Field offset: 0x40
	public static readonly Color GREEN_COLOR; //Field offset: 0x50
	public static readonly Color YELLOW_COLOR; //Field offset: 0x60
	public static readonly Color RED_COLOR; //Field offset: 0x70

	private static UnityUtils() { }

	public static float ClampAngle(float angle, float min, float max) { }

	public static float ClampAngle360Sensitive(float angle, float min, float max) { }

	public static void ClearLog() { }

	[Extension]
	public static bool Contains(LODGroup lodGroup, Renderer renderer) { }

	[Extension]
	public static T Do(T t, Action action) { }

	[Extension]
	[IteratorStateMachine(typeof(<DoMap>d__14`1))]
	public static IEnumerable DoMap(IEnumerable t, Action action) { }

	[Extension]
	public static List FillWith(List list, T value) { }

	[Extension]
	public static T[] FillWith(T[] list, T value) { }

	public static ICollection GetAllComponentsOfType(bool includeInactive) { }

	public static Bounds GetColliderBoundsWithoutRotation(Collider collider) { }

	[Extension]
	public static Vector3 GetDestination(NavMeshAgent agent) { }

	[Extension]
	public static float GetDuration(AnimationCurve c) { }

	public static string GetFullPathWithoutExtension(string path) { }

	public static float GetHorizontalFovFromVertical(float fov, float aspect) { }

	[Extension]
	public static float GetTime(AnimationCurve c, float value, float checkFrequency, uint valueOrder = 0) { }

	public static float GetVerticalFovFromHorizontal(float fov, float aspect) { }

	[Extension]
	public static bool HasTagInParent(GameObject gameObject, string tag) { }

	public static bool IsComponentEnabled(Component component) { }

	public static float RoundFloatValue(float value, int digits) { }

	public static void ToggleStaticRecursively(GameObject go, bool isStatic) { }

	public static float ZipAngle(float angle) { }

}

