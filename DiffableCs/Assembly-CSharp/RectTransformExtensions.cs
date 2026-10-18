//Type is in global namespace

[Extension]
public static class RectTransformExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ActiveChildCount>b__1_0(Transform child) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		private struct <<RebuildLayout>g__DelayedRebuildLayout|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass18_0 <>4__this; //Field offset: 0x20
			private YieldAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public RectTransform transform; //Field offset: 0x10
		public bool useCanvasGroupAlpha; //Field offset: 0x18
		public CanvasGroup canvas; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		[AsyncStateMachine(typeof(<<RebuildLayout>g__DelayedRebuildLayout|0>d))]
		internal Task <RebuildLayout>g__DelayedRebuildLayout|0() { }

	}

	[CompilerGenerated]
	private sealed class <Children>d__0 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Transform <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Transform transform; //Field offset: 0x28
		public Transform <>3__transform; //Field offset: 0x30
		private int <childCount>5__2; //Field offset: 0x38
		private int <i>5__3; //Field offset: 0x3C

		private override Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
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
		public <Children>d__0(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator() { }

		[DebuggerHidden]
		private override Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static int ActiveChildCount(Transform transform) { }

	[Extension]
	[IteratorStateMachine(typeof(<Children>d__0))]
	public static IEnumerable Children(Transform transform) { }

	[Extension]
	public static void CopyValues(Transform target, Vector3 position, Vector3 rotation, Vector3 scale) { }

	[Extension]
	public static void CopyValues(Transform target, Transform template) { }

	[Extension]
	public static void CopyValues(Transform target, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Extension]
	public static void CopyValuesWithDiff(Transform target, Transform template, Vector3 diffPosition, Quaternion diffRotation) { }

	[Extension]
	public static void CorrectPositionResolution(RectTransform transform, MarginsRect margins = null) { }

	[Extension]
	public static void CorrectPositionResolution(RectTransform transform, RectTransform referenceTransform, MarginsRect margins = null) { }

	[Extension]
	public static MarginsRect GetDistanceToBorders(RectTransform transform, RectTransform referenceTransform = null, MarginsRect margins = null) { }

	[Extension]
	public static Rect GetGlobalBounds(RectTransform rectTransform) { }

	[Extension]
	public static Vector2 GetTopLeftToPivotDelta(RectTransform transform) { }

	[Extension]
	public static void Move(Transform transform, Vector3 delta) { }

	[Extension]
	public static void PlaceRelativeToCenter(RectTransform rectTransform, Vector2 relativePosition) { }

	[Extension]
	public static void RebuildLayout(RectTransform transform, bool useCanvasGroupAlpha = true) { }

	[Extension]
	public static RectTransform RectTransform(Component component) { }

	[Extension]
	public static RectTransform RectTransform(GameObject gameObject) { }

	[Extension]
	public static void ResetTransform(Transform target) { }

	[Extension]
	public static void SetInCenter(RectTransform transform) { }

	[Extension]
	public static void SetRectTransformParent(RectTransform transform, RectTransform objectToCopy) { }

}

