namespace EFT.Interactive;

public class Door : WorldInteractiveObject
{
	[CompilerGenerated]
	private sealed class <AnimateSealingHandleCoroutine>d__65 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Door <>4__this; //Field offset: 0x20
		public Quaternion targetRotation; //Field offset: 0x28
		private float <animationDuration>5__2; //Field offset: 0x38
		private Quaternion <startRotation>5__3; //Field offset: 0x3C
		private float <elapsedTime>5__4; //Field offset: 0x4C

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
		public <AnimateSealingHandleCoroutine>d__65(int <>1__state) { }

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
	private sealed class <FailBreachRoutine>d__47 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Door <>4__this; //Field offset: 0x20

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
		public <FailBreachRoutine>d__47(int <>1__state) { }

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
	private sealed class <SmoothDoorOpenCoroutine>d__63 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Door <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public bool isLocalInteraction; //Field offset: 0x29

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
		public <SmoothDoorOpenCoroutine>d__63(int <>1__state) { }

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

	[Header("---Anti cheat trigger---")]
	[SerializeField]
	private PhysicsTriggerHandler _relatedTrigger; //Field offset: 0x178
	private BrokenDoor _broken; //Field offset: 0x180
	public AudioClip HitClip; //Field offset: 0x188
	public AudioClip BreachSound; //Field offset: 0x190
	[SerializeField]
	private int _hitSoundRolloff; //Field offset: 0x198
	[SerializeField]
	private int _breachSoundRolloff; //Field offset: 0x19C
	[Space]
	public bool IsBroken; //Field offset: 0x1A0
	public bool CanBeBreached; //Field offset: 0x1A1
	public bool CanInteractWithBreach; //Field offset: 0x1A2
	public bool CanBeSealed; //Field offset: 0x1A3
	[SerializeField]
	private float _sealDuration; //Field offset: 0x1A4
	[SerializeField]
	private Transform _sealingHandle; //Field offset: 0x1A8
	[SerializeField]
	private Vector3 _unsealedRotation; //Field offset: 0x1B0
	[SerializeField]
	private Vector3 _sealedRotation; //Field offset: 0x1BC
	[SerializeField]
	private AnimationCurve _sealingHandleAnimationCurve; //Field offset: 0x1C8
	[Header("Seal Sounds")]
	[SerializeField]
	[Space]
	private AudioMultipleClipContainer _startSealSounds; //Field offset: 0x1D0
	[SerializeField]
	private AudioMultipleClipContainer _loopSealSounds; //Field offset: 0x1D8
	[SerializeField]
	private AudioMultipleClipContainer _loopUnsealSounds; //Field offset: 0x1E0
	[SerializeField]
	private AudioMultipleClipContainer _endSealSounds; //Field offset: 0x1E8
	[SerializeField]
	private AudioMultipleClipContainer _dropSealSounds; //Field offset: 0x1F0
	[Space]
	private AudioHandle _sealSoundLoopHandle; //Field offset: 0x1F8
	[SerializeField]
	private bool _disableOperationsAfterOpen; //Field offset: 0x208
	private Coroutine _sealingHandleAnimationCoroutine; //Field offset: 0x210
	[ClassStateStorageIgnore]
	[Space(10)]
	public AnimationCurve KickCurve; //Field offset: 0x218
	public ParticleSystem HitEffect; //Field offset: 0x220
	[SerializeField]
	private OcclusionPortal _occlusionPortal; //Field offset: 0x228
	private List _collisionColliders; //Field offset: 0x230

	public List CollisionColliders
	{
		 get { } //Length: 735
	}

	public virtual float CurrentAngle
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public virtual EDoorState DoorState
	{
		 get { } //Length: 8
		 set { } //Length: 218
	}

	public float SealDuration
	{
		 get { } //Length: 9
	}

	public virtual string TypeKey
	{
		 get { } //Length: 49
	}

	public Door() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(EDoorState state, bool isLocalInteraction, float speed) { }

	public bool AIEditorPosibleState() { }

	[IteratorStateMachine(typeof(<AnimateSealingHandleCoroutine>d__65))]
	private IEnumerator AnimateSealingHandleCoroutine(Quaternion targetRotation) { }

	private void ApplySealingHandleState(EDoorState state, bool instant) { }

	public bool BreachSuccessRoll(Vector3 yourPosition) { }

	protected virtual int CalculateInteractionIndex(Vector3 playerPosition) { }

	public virtual void CancelInteraction() { }

	private void CheckOcclusionPortal() { }

	public void DropSealing() { }

	public void FailBreach(Vector3 yourPosition) { }

	[IteratorStateMachine(typeof(<FailBreachRoutine>d__47))]
	private IEnumerator FailBreachRoutine() { }

	public NavMeshObstacle FindSelfObstalce() { }

	public List get_CollisionColliders() { }

	public virtual float get_CurrentAngle() { }

	public virtual EDoorState get_DoorState() { }

	public float get_SealDuration() { }

	public virtual string get_TypeKey() { }

	public virtual float GetAngle(EDoorState state) { }

	public InteractionParameters GetBreakInParameters(Vector3 yourPosition) { }

	private Vector3 GetBreakInPosition(Vector3 yourPosition) { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	protected virtual Vector3 GetSoundPos() { }

	public virtual InteractiveObjectStatusInfo GetStatusInfo(bool solidState = false) { }

	public static Option Interact(Player player, EInteractionType interactionType) { }

	public virtual void Interact(InteractionResult interactionResult) { }

	public bool IsBreachAngle(Vector3 yourPosition) { }

	public void KickOpen(Vector3 yourPosition, bool confirmed = false) { }

	public void KickOpen(bool confirmed) { }

	protected virtual void OnAwake() { }

	protected virtual void OnDestroy() { }

	public virtual void OnEnable() { }

	public virtual void OnValidate() { }

	public void PlayLoopSealSound(IAudioClipContainer audioContainer) { }

	public void PlayOneShotSealSound(IAudioClipContainer audioContainer) { }

	protected virtual void Seal() { }

	protected virtual void set_CurrentAngle(float value) { }

	public virtual void set_DoorState(EDoorState value) { }

	public virtual void SetInitialSyncState(InteractiveObjectStatusInfo info) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__63))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

	protected void Start() { }

	public void StartSealing() { }

	public void StartUnsealing() { }

	private void StopSealLoopSound() { }

	public virtual void SyncInteractState(InteractiveObjectStatusInfo info) { }

	protected virtual void Unseal() { }

}

