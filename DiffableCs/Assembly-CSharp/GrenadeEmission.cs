//Type is in global namespace

public class GrenadeEmission : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__55_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Removal>b__55_0(ParticleSystem x) { }

	}

	[CompilerGenerated]
	private sealed class <EmitFillSystem>d__49 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GrenadeEmission <>4__this; //Field offset: 0x20
		private float <groundDepenetration>5__2; //Field offset: 0x28
		private Vector3[] <>7__wrap2; //Field offset: 0x30
		private int <>7__wrap3; //Field offset: 0x38

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
		public <EmitFillSystem>d__49(int <>1__state) { }

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
	private sealed class <Removal>d__55 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public float refreshRate; //Field offset: 0x24
		public GrenadeEmission <>4__this; //Field offset: 0x28

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
		public <Removal>d__55(int <>1__state) { }

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
	private sealed class <StopFill>d__50 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int time; //Field offset: 0x20
		public GrenadeEmission <>4__this; //Field offset: 0x28

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
		public <StopFill>d__50(int <>1__state) { }

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

	private class PSMaterial
	{
		public ParticleSystem ParticleSystem; //Field offset: 0x10
		public Material Material; //Field offset: 0x18

		public PSMaterial() { }

	}

	private const float START_FADE_OUT_SEC = 0.05; //Field offset: 0x0
	private const float LOOP_FADE_OUT_SEC = 1; //Field offset: 0x0
	public static bool EnableMBOITEmission; //Field offset: 0x0
	private static readonly int _indoor; //Field offset: 0x4
	private static readonly int _grenadeWorldPositionId; //Field offset: 0x8
	private static readonly Vector3 EmissionOcclusionWorldOffset; //Field offset: 0xC
	private Transform _parent; //Field offset: 0x20
	private Vector3 _offset; //Field offset: 0x28
	private string _poolName; //Field offset: 0x38
	[SerializeField]
	private ParticleSystem _particleSystem; //Field offset: 0x40
	[SerializeField]
	private ParticleSystem[] _crucialSystems; //Field offset: 0x48
	[SerializeField]
	private ParticleSystem _fillSystem; //Field offset: 0x50
	[SerializeField]
	private List _otherParticlesSystem; //Field offset: 0x58
	[SerializeField]
	private ParticleSystemRenderer[] _particleSystemRenderers; //Field offset: 0x60
	[SerializeField]
	private float _defaultStartFillDelay; //Field offset: 0x68
	[SerializeField]
	private float _startFillSize; //Field offset: 0x6C
	[SerializeField]
	private float _startFillDistance; //Field offset: 0x70
	private float _startFillDelay; //Field offset: 0x74
	private float _startFillLifeTime; //Field offset: 0x78
	private bool _isIndoors; //Field offset: 0x7C
	[Header("Sound Settings")]
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _emissionSoundVolume; //Field offset: 0x80
	[SerializeField]
	private float _emissionSoundRolloff; //Field offset: 0x84
	[SerializeField]
	private AnimationCurve _spreadCurve; //Field offset: 0x88
	[SerializeField]
	private AudioClip _startAudioClip; //Field offset: 0x90
	[SerializeField]
	private AudioClip _audioClip; //Field offset: 0x98
	[SerializeField]
	private AudioClip _endAudioClip; //Field offset: 0xA0
	[SerializeField]
	[Space]
	private float _removalDelay; //Field offset: 0xA8
	private Vector3 _lastCachedPosition; //Field offset: 0xAC
	private SpatialAudioSequencePlayer _audio; //Field offset: 0xB8
	private List _particleSystemsMaterials; //Field offset: 0xC0
	private float _smokeIndoorCoef; //Field offset: 0xC8
	private float _startTime; //Field offset: 0xCC
	[Header("Auto-fill parameters")]
	[SerializeField]
	private ColliderExtrusion _extrusion; //Field offset: 0xD0
	[SerializeField]
	private Vector2[] _startSpeed; //Field offset: 0xD8
	public Action OnRemove; //Field offset: 0xE0

	public string PoolName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	private static GrenadeEmission() { }

	public GrenadeEmission() { }

	private void AddMaterials() { }

	private void AddToMBOITOtherParticlesSources() { }

	public void AttachTo(Transform t, Vector3 offset) { }

	public void Clear() { }

	[IteratorStateMachine(typeof(<EmitFillSystem>d__49))]
	private IEnumerator EmitFillSystem() { }

	public void EnableRenderers(bool value) { }

	public string get_PoolName() { }

	public void LateUpdate() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	public void Precaution() { }

	private void Prewarm(float prewarmTime) { }

	[IteratorStateMachine(typeof(<Removal>d__55))]
	private IEnumerator Removal(float delay, float refreshRate) { }

	public void set_PoolName(string value) { }

	public void SetFillParams(float timePastSinceStart, float lifetimeLeft) { }

	private void SetSystemPosition() { }

	public void Stall(Throwable obj) { }

	private void StartAudioSequence() { }

	public void StartEmission(float prewarm) { }

	[ContextMenu("Start Fill")]
	public void StartFill() { }

	public void StopEmission(Grenade grenade) { }

	[IteratorStateMachine(typeof(<StopFill>d__50))]
	private IEnumerator StopFill(int time) { }

	public void TryAddParticleSystemToMBOIT(ParticleSystem system) { }

	private void TryRemoveParticleSystem(ParticleSystem system, MBOITParticlesManager manager) { }

	public void UpdateExternalForces(bool indoor) { }

	private void UpdateSmokeCoef(bool indoor) { }

}

