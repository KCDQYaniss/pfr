namespace EFT.Airdrop;

public class ClientAirDrop : ISynchronizableLogic
{
	[CompilerGenerated]
	private sealed class <ParachuteDisplayingCoroutine>d__48 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ClientAirDrop <>4__this; //Field offset: 0x20
		private float <fadeTime>5__2; //Field offset: 0x28
		private float <end>5__3; //Field offset: 0x2C

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
		public <ParachuteDisplayingCoroutine>d__48(int <>1__state) { }

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
	private sealed class <ParachuteFadeCoroutine>d__47 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ClientAirDrop <>4__this; //Field offset: 0x20
		private float <end>5__2; //Field offset: 0x28

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
		public <ParachuteFadeCoroutine>d__47(int <>1__state) { }

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
	private sealed class <ShakeAfterLanding>d__40 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ClientAirDrop <>4__this; //Field offset: 0x20
		private float <shakingTime>5__2; //Field offset: 0x28
		private float <end>5__3; //Field offset: 0x2C

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
		public <ShakeAfterLanding>d__40(int <>1__state) { }

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

	private const string COLLISION_ANIMATOR_PARAMETER = "collision"; //Field offset: 0x0
	private static readonly int _crossfade; //Field offset: 0x0
	public ServerAirDrop OfflineServerLogic; //Field offset: 0x10
	public bool offlineMode; //Field offset: 0x18
	private Vector3 _destinationPosition; //Field offset: 0x1C
	private Quaternion _destinationRotation; //Field offset: 0x28
	private SynchronizableObjectType _objectType; //Field offset: 0x38
	private EAirdropFallingStage _fallingStage; //Field offset: 0x3C
	private EAirdropFallingStage _startFallingStage; //Field offset: 0x40
	private AirdropSynchronizableObject _syncObject; //Field offset: 0x48
	private bool _startClosingParachute; //Field offset: 0x50
	private GameObject _parachute; //Field offset: 0x58
	private Material _parachuteMaterial; //Field offset: 0x60
	private GameObject _airdropFlare; //Field offset: 0x68
	private GameObject _airdropDust; //Field offset: 0x70
	private bool _signalFire; //Field offset: 0x78
	private List _myColliders; //Field offset: 0x80
	private ESurfaceSound CurrentSurface; //Field offset: 0x88
	private bool _isSurfaceHit; //Field offset: 0x8C
	private RaycastHit _surfaceHit; //Field offset: 0x90
	private AirdropSurfaceSet _currentSet; //Field offset: 0xC0
	private Dictionary _soundBySurface; //Field offset: 0xC8
	private BetterSource _loopSoundSource; //Field offset: 0xD0
	private Coroutine ParachuteUnFadeCorooutine; //Field offset: 0xD8
	private Renderer[] _airdropMeshRenderers; //Field offset: 0xE0
	private SkinnedMeshRenderer[] _airdropSkinnedMeshRenderers; //Field offset: 0xE8

	private EFTHardSettings EftSettings
	{
		private get { } //Length: 7
	}

	private BetterSource LoopSoundSource
	{
		private get { } //Length: 619
		private set { } //Length: 82
	}

	private Transform SyncObjectTransform
	{
		private get { } //Length: 90
	}

	private static ClientAirDrop() { }

	public ClientAirDrop(bool offlineServerLogic) { }

	private void CheckSurface() { }

	private void CloseParachute() { }

	public override void CollisionEnter(Collider collider) { }

	private EFTHardSettings get_EftSettings() { }

	private BetterSource get_LoopSoundSource() { }

	private Transform get_SyncObjectTransform() { }

	private bool GetRaycastPoint(Vector3 point, float distance, out RaycastHit raycastHit, LayerMask mask) { }

	private bool HasRaycastHit(Vector3 point, float distance) { }

	public override void Init(int objectID, Vector3 position, Vector3 rotation) { }

	private void InitializeLandedAirdrop() { }

	public override void InitStaticObject() { }

	public override void ManualUpdate(float deltaTime) { }

	[IteratorStateMachine(typeof(<ParachuteDisplayingCoroutine>d__48))]
	private IEnumerator ParachuteDisplayingCoroutine() { }

	[IteratorStateMachine(typeof(<ParachuteFadeCoroutine>d__47))]
	private IEnumerator ParachuteFadeCoroutine() { }

	private void PlayFlareSound() { }

	private void PlayLandingSound() { }

	private void PlaySound(TaggedClip clip, bool looped = false, bool oneShot = false) { }

	private void PlaySqueakSoundLoop() { }

	private void ReleaseSoundSource() { }

	public override void ReturnToPool() { }

	private void set_LoopSoundSource(BetterSource value) { }

	public override void SetSyncObject(SynchronizableObject syncObject) { }

	[IteratorStateMachine(typeof(<ShakeAfterLanding>d__40))]
	private IEnumerator ShakeAfterLanding() { }

	private void StopParachuteDisplayingCoroutine() { }

	private void SwitchAirdropContainerDecals(AirdropSynchronizableObject container, Material material) { }

	public override void TakeFromPool() { }

	private void UpdateContainerType(EAirdropType airdropContainerType) { }

	public override void UpdateSyncObjectData(ref SynchronizableObjectPacket packet) { }

}

