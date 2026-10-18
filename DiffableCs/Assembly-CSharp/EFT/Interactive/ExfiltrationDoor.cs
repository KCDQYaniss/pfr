namespace EFT.Interactive;

[ExecuteInEditMode]
public class ExfiltrationDoor : ExfiltrationSubscriber
{
	[CompilerGenerated]
	private sealed class <LerpByCurve>d__30 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public ExfiltrationDoor <>4__this; //Field offset: 0x28
		public AudioClip clip; //Field offset: 0x30
		public bool isOpen; //Field offset: 0x38
		private float <startTime>5__2; //Field offset: 0x3C
		private float <t>5__3; //Field offset: 0x40
		private float <duration>5__4; //Field offset: 0x44

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
		public <LerpByCurve>d__30(int <>1__state) { }

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
	private sealed class <LerpDoor>d__31 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public AudioClip clip; //Field offset: 0x28
		public ExfiltrationDoor <>4__this; //Field offset: 0x30
		public Quaternion q; //Field offset: 0x38
		public Vector3 pos; //Field offset: 0x48

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
		public <LerpDoor>d__31(int <>1__state) { }

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

	internal class DoorTransform
	{
		[HideInInspector]
		public Quaternion OpenRotation; //Field offset: 0x10
		[HideInInspector]
		public Quaternion CloseRotation; //Field offset: 0x20
		[HideInInspector]
		public Vector3 OpenPosition; //Field offset: 0x30
		[HideInInspector]
		public Vector3 ClosePosition; //Field offset: 0x3C
		[HideInInspector]
		public Vector3 OpenScale; //Field offset: 0x48
		[HideInInspector]
		public Vector3 CloseScale; //Field offset: 0x54
		public Transform Transform; //Field offset: 0x60
		public bool PlaySoundAt; //Field offset: 0x68
		[HideInInspector]
		public Vector3 StartPosition; //Field offset: 0x6C
		[HideInInspector]
		public Vector3 StartScale; //Field offset: 0x78
		[HideInInspector]
		public Quaternion StartRotation; //Field offset: 0x84

		public DoorTransform() { }

		public void StoreValues() { }

	}

	[SerializeField]
	private DoorTransform[] _doorTransforms; //Field offset: 0x30
	[HideInInspector]
	[Obsolete]
	public Quaternion OpenRotation; //Field offset: 0x38
	[HideInInspector]
	[Obsolete]
	public Quaternion CloseRotation; //Field offset: 0x48
	[HideInInspector]
	[Obsolete]
	public Vector3 OpenPosition; //Field offset: 0x58
	[HideInInspector]
	[Obsolete]
	public Vector3 ClosePosition; //Field offset: 0x64
	[HideInInspector]
	[Obsolete]
	public Vector3 OpenScale; //Field offset: 0x70
	[HideInInspector]
	[Obsolete]
	public Vector3 ClosedScale; //Field offset: 0x7C
	public bool DisableWhenClosed; //Field offset: 0x88
	private Coroutine _coroutine; //Field offset: 0x90
	public AudioClip OpenClip; //Field offset: 0x98
	public AudioClip CloseClip; //Field offset: 0xA0
	public float Volume; //Field offset: 0xA8
	public int Rolloff; //Field offset: 0xAC
	public float LerpSpeed; //Field offset: 0xB0
	public bool ForceStateOnStart; //Field offset: 0xB4
	public AnimationCurve Curve; //Field offset: 0xB8
	public EExfiltrationStatus[] OpenStatus; //Field offset: 0xC0
	private bool _isOpen; //Field offset: 0xC8
	[SerializeField]
	private List _collisionColliders; //Field offset: 0xD0

	private List CollisionColliders
	{
		private get { } //Length: 88
	}

	public DoorTransform[] DoorTransforms
	{
		 get { } //Length: 76
	}

	public ExfiltrationDoor() { }

	[CompilerGenerated]
	internal static bool <CacheCollisionColliders>g__DoesCollideWithPlayer|22_0(Collider currentCollider) { }

	public void Awake() { }

	[ContextMenu("Cache collision colliders")]
	private void CacheCollisionColliders() { }

	private List get_CollisionColliders() { }

	public DoorTransform[] get_DoorTransforms() { }

	[IteratorStateMachine(typeof(<LerpByCurve>d__30))]
	private IEnumerator LerpByCurve(bool isOpen, AudioClip clip, float delay) { }

	[IteratorStateMachine(typeof(<LerpDoor>d__31))]
	private IEnumerator LerpDoor(Quaternion q, Vector3 pos, AudioClip clip, float delay) { }

	private void OnDestroy() { }

	protected virtual void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	protected void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus, bool force) { }

	[ContextMenu("Set close")]
	public void SetCloseRotation() { }

	private void SetCollisionCollidersActive(bool value) { }

	[ContextMenu("Set open")]
	public void SetOpenRotation() { }

	public virtual void Start() { }

	[ContextMenu("try close")]
	public void TryClose() { }

	[ContextMenu("try open")]
	public void TryOpen() { }

}

