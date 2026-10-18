namespace EFT.WeaponMounting;

public sealed class MountingPointDetectionSystem : IDisposable
{
	[CompilerGenerated]
	private sealed class <FindHorizontalGridPoint>d__29 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MountingPointDetectionSystem <>4__this; //Field offset: 0x20
		public Vector3 horizontalGridStartPos; //Field offset: 0x28
		public int framesForRaycast; //Field offset: 0x34
		public int detectionLayer; //Field offset: 0x38

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
		public <FindHorizontalGridPoint>d__29(int <>1__state) { }

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
	private sealed class <FindHorizontalMountingPoint>d__25 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MountingPointDetectionSystem <>4__this; //Field offset: 0x20
		private Vector3 <bestHitPos>5__2; //Field offset: 0x28
		private RaycastHit <bestHit>5__3; //Field offset: 0x34

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
		public <FindHorizontalMountingPoint>d__25(int <>1__state) { }

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
	private sealed class <FindVerticalMountingPoint>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MountingPointDetectionSystem <>4__this; //Field offset: 0x20
		private Vector3 <horizontalGridStartPos>5__2; //Field offset: 0x28

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
		public <FindVerticalMountingPoint>d__28(int <>1__state) { }

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
	private sealed class <SetRaycasts>d__30 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MountingPointDetectionSystem <>4__this; //Field offset: 0x20
		public float gridSize; //Field offset: 0x28
		public int gridStepsAmount; //Field offset: 0x2C
		public Vector3 startPos; //Field offset: 0x30
		public Vector3 gridExpansionDirection; //Field offset: 0x3C
		public Vector3 raycastDirection; //Field offset: 0x48
		public float raycastDistance; //Field offset: 0x54
		public int detectionLayer; //Field offset: 0x58
		public int framesForCast; //Field offset: 0x5C
		private int <framesPassed>5__2; //Field offset: 0x60

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
		public <SetRaycasts>d__30(int <>1__state) { }

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

	private sealed class CoroutineWithData
	{
		[CompilerGenerated]
		private sealed class <Run>d__7 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public CoroutineWithData <>4__this; //Field offset: 0x20

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
			public <Run>d__7(int <>1__state) { }

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
		private Coroutine <Coroutine>k__BackingField; //Field offset: 0x10
		public object Result; //Field offset: 0x18
		private readonly IEnumerator _target; //Field offset: 0x20

		public private Coroutine Coroutine
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public CoroutineWithData(MonoBehaviour owner, IEnumerator target) { }

		[CompilerGenerated]
		public Coroutine get_Coroutine() { }

		[IteratorStateMachine(typeof(<Run>d__7))]
		private IEnumerator Run() { }

		[CompilerGenerated]
		private void set_Coroutine(Coroutine value) { }

	}

	private struct HorizontalHits
	{
		public RaycastHit Hit; //Field offset: 0x0
		public bool BlockedByDotDiff; //Field offset: 0x2C
		public bool HasBothNeighbours; //Field offset: 0x2D

	}

	private const float MAX_GROUND_SEARCH_DISTANCE = 0.4; //Field offset: 0x0
	private readonly Transform _gridRoot; //Field offset: 0x10
	private readonly IMountingPointDetectionSettings _pointDetectionSettings; //Field offset: 0x18
	private readonly WeaponMountingView _view; //Field offset: 0x20
	private readonly LayerMask _mainDetectionLayer; //Field offset: 0x28
	private readonly LayerMask _secondaryDetectionLayer; //Field offset: 0x2C
	private float _baseHeight; //Field offset: 0x30
	private Vector3 _gridRootPos; //Field offset: 0x34
	private Vector3 _gridRootForward; //Field offset: 0x40
	private Vector3 _gridRootRight; //Field offset: 0x4C
	private bool _canMountVertically; //Field offset: 0x58
	private float _horizontalHeightOffset; //Field offset: 0x5C
	private float _verticalHeightOffset; //Field offset: 0x60
	private NativeArray _raycastHits; //Field offset: 0x68
	private NativeArray _raycastCommands; //Field offset: 0x78
	private JobHandle _jobHandle; //Field offset: 0x88
	public Action OnMountingPointFound; //Field offset: 0x98
	public Action OnNoPointFound; //Field offset: 0xA0
	private bool _pointFound; //Field offset: 0xA8

	public MountingPointDetectionSystem(IMountingPointDetectionSettings pointDetectionSettings, WeaponMountingView view) { }

	public void CancelFindingPoint() { }

	private void ClearRaycastArrays() { }

	public override void Dispose() { }

	[IteratorStateMachine(typeof(<FindHorizontalGridPoint>d__29))]
	private IEnumerator FindHorizontalGridPoint(Vector3 horizontalGridStartPos, int detectionLayer, int framesForRaycast) { }

	[IteratorStateMachine(typeof(<FindHorizontalMountingPoint>d__25))]
	private IEnumerator FindHorizontalMountingPoint() { }

	public void FindMountingPoint(float yaw, float baseHeight, float horizontalHeightOffset, float verticalHeightOffset, bool canMountVertically) { }

	public void FindMountingPointProne(float yaw, float distance, float bipodHeight, float currentPitch) { }

	[IteratorStateMachine(typeof(<FindVerticalMountingPoint>d__28))]
	private IEnumerator FindVerticalMountingPoint() { }

	private void OnHorizontalMountingPointFound(MountPointData pointData) { }

	private void OnNothingFound() { }

	private void OnVerticalMountingPointFound(MountPointData pointData) { }

	[IteratorStateMachine(typeof(<SetRaycasts>d__30))]
	private IEnumerator SetRaycasts(Vector3 gridExpansionDirection, Vector3 raycastDirection, Vector3 startPos, float gridSize, int gridStepsAmount, float raycastDistance, int framesForCast, int detectionLayer) { }

}

