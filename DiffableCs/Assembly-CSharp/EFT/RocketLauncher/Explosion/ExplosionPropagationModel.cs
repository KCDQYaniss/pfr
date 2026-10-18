namespace EFT.RocketLauncher.Explosion;

public class ExplosionPropagationModel : IExplosionPropagationModel
{
	[CompilerGenerated]
	private sealed class <StartPropagation>d__43 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ExplosionPropagationModel <>4__this; //Field offset: 0x20
		public Vector3 epicenter; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x34

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
		public <StartPropagation>d__43(int <>1__state) { }

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

	internal sealed class OnColliderDetected : MulticastDelegate
	{

		public OnColliderDetected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Collider collider, ComputableUnit unit, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Collider collider, ComputableUnit unit) { }

	}

	[CompilerGenerated]
	private OnColliderDetected OnColliderDetectedEvent; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnNewCalcalateIterationEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action CollectionUpdated; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnExplosionEndedEvent; //Field offset: 0x28
	private readonly bool[,,] _normalizedSpaceGrid; //Field offset: 0x30
	private readonly List _computableUnitsGrid; //Field offset: 0x38
	private readonly List _computableUnitsGridFull; //Field offset: 0x40
	private readonly ComputableUnit[] _randomInnerGrid; //Field offset: 0x48
	private Func _explosionRadiusGetter; //Field offset: 0x50
	private Func _explosionPropagationSpeed; //Field offset: 0x58
	private Func _unitSize; //Field offset: 0x60
	private Func _unitType; //Field offset: 0x68
	private readonly int _collidersCapacity; //Field offset: 0x70
	private readonly Collider[] _colliders; //Field offset: 0x78
	private int _halfSizeGrid; //Field offset: 0x80
	private int _unitsCount; //Field offset: 0x84
	private int _iterationsCount; //Field offset: 0x88
	private int _unitsCounter; //Field offset: 0x8C
	private int _iterationsCounter; //Field offset: 0x90
	private int _unitsPerFrameCount; //Field offset: 0x94
	private int _unitsPerFrameCounter; //Field offset: 0x98
	private readonly Vector3Int[] _directions; //Field offset: 0xA0
	private readonly Vector3Int[] _nonVerticalDirections; //Field offset: 0xA8

	public event Action CollectionUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event OnColliderDetected OnColliderDetectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnExplosionEndedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnNewCalcalateIterationEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private float _currenWeight
	{
		private get { } //Length: 27
	}

	public IEnumerable ComputableUnits
	{
		 get { } //Length: 5
	}

	public IEnumerable ComputableUnitsFull
	{
		 get { } //Length: 5
	}

	public override IEnumerable RandomInnerGrid
	{
		 get { } //Length: 5
	}

	public ExplosionPropagationModel() { }

	[CompilerGenerated]
	public void add_CollectionUpdated(Action value) { }

	[CompilerGenerated]
	public override void add_OnColliderDetectedEvent(OnColliderDetected value) { }

	[CompilerGenerated]
	public void add_OnExplosionEndedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnNewCalcalateIterationEvent(Action value) { }

	private void AddToNormilizeGrid(Vector3Int normalizePos) { }

	private int CalculateCalculationPerFrameCount() { }

	private int CalculateComputableUnitsCount() { }

	private bool CheckAbilityToExpand(ref ComputableUnit unit, out Vector3Int direction) { }

	private bool CheckIterationsCountReached() { }

	private bool CheckNormalizedGrid(Vector3Int normalizePos) { }

	private bool CheckUnitsCountReached() { }

	private bool CheckUnitsPerFrameCountReached() { }

	private void ClearCollidersArray() { }

	private void FormFirstGeneration(ComputableUnit epicenterUnit) { }

	private void FormRandomInnerGrid() { }

	private float get__currenWeight() { }

	public IEnumerable get_ComputableUnits() { }

	public IEnumerable get_ComputableUnitsFull() { }

	public override IEnumerable get_RandomInnerGrid() { }

	private void HandleCollisions(ref ComputableUnit unit, out Nullable canExpand) { }

	public void Initialize(Func explosionRadiusGetter, Func explosionPropagationSpeed, Func unitSize, Func unitType) { }

	[CompilerGenerated]
	public void remove_CollectionUpdated(Action value) { }

	[CompilerGenerated]
	public override void remove_OnColliderDetectedEvent(OnColliderDetected value) { }

	[CompilerGenerated]
	public void remove_OnExplosionEndedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnNewCalcalateIterationEvent(Action value) { }

	[IteratorStateMachine(typeof(<StartPropagation>d__43))]
	public override IEnumerator StartPropagation(Vector3 epicenter) { }

}

