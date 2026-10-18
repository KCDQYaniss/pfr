namespace EFT.Interactive;

public class SniperImitator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ShotCoroutine>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SniperWeaponView sniperView; //Field offset: 0x20
		public Vector3 sniperPosition; //Field offset: 0x28
		public SniperImitator <>4__this; //Field offset: 0x38
		public float tMinus; //Field offset: 0x40
		public Quaternion sniperRotation; //Field offset: 0x44
		public IObserverToPlayerBridge player; //Field offset: 0x58
		public bool willHit; //Field offset: 0x60
		private float <sqrDistance>5__2; //Field offset: 0x64
		private float <bulletTime>5__3; //Field offset: 0x68

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
		public <ShotCoroutine>d__16(int <>1__state) { }

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

	private static readonly Quaternion _offset; //Field offset: 0x0
	[SerializeField]
	private FirearmsEffects FirearmsEffects; //Field offset: 0x20
	[SerializeField]
	private SniperFiringZone SniperFiringZone; //Field offset: 0x28
	[SerializeField]
	private SoundBank SoundBank; //Field offset: 0x30
	[SerializeField]
	private List SniperPositions; //Field offset: 0x38
	[SerializeField]
	private Transform _effectsTransform; //Field offset: 0x40
	[Header("Weapon View Settings")]
	[SerializeField]
	private bool _useWeaponViews; //Field offset: 0x48
	[SerializeField]
	private List _sniperViews; //Field offset: 0x50
	private bool _isInitialized; //Field offset: 0x58

	public Transform GetRandomSniperPosition
	{
		 get { } //Length: 196
	}

	public SniperWeaponView GetRandomSniperView
	{
		 get { } //Length: 196
	}

	private static SniperImitator() { }

	public SniperImitator(FirearmsEffects firearmsEffects, SniperFiringZone sniperFiringZone, SoundBank soundBank, List sniperPositions, List sniperViews = null) { }

	public void Awake() { }

	public Transform get_GetRandomSniperPosition() { }

	public SniperWeaponView get_GetRandomSniperView() { }

	private void OnDestroy() { }

	private void OnPlayerShotEvent(IObserverToPlayerBridge player, BorderZone firingZone, float tMinus, bool willHit) { }

	[IteratorStateMachine(typeof(<ShotCoroutine>d__16))]
	private IEnumerator ShotCoroutine(float tMinus, IObserverToPlayerBridge player, Vector3 sniperPosition, Quaternion sniperRotation, bool willHit, SniperWeaponView sniperView = null) { }

}

