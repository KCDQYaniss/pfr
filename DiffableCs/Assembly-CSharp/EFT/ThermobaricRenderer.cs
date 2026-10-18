namespace EFT;

public class ThermobaricRenderer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__32_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ProceedStepByStep>b__32_0(Cell cell) { }

	}

	[CompilerGenerated]
	private sealed class <ProceedParticles>d__31 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ParticlesConfig config; //Field offset: 0x20
		public HashSet explosionNodes; //Field offset: 0x38
		public ParticleSystem ps; //Field offset: 0x40
		public Particle[] buffer; //Field offset: 0x48
		public Vector3 origin; //Field offset: 0x50
		public ThermobaricRenderer <>4__this; //Field offset: 0x60
		private float <startTime>5__2; //Field offset: 0x68
		private float <deltaTime>5__3; //Field offset: 0x6C

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
		public <ProceedParticles>d__31(int <>1__state) { }

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
	private sealed class <ProceedStepByStep>d__32 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HashSet nodes; //Field offset: 0x20
		public ParticleSystem ps; //Field offset: 0x28
		public Particle[] buffer; //Field offset: 0x30
		public ThermobaricRenderer <>4__this; //Field offset: 0x38
		private HashSet <currentSet>5__2; //Field offset: 0x40
		private IEnumerator <>7__wrap2; //Field offset: 0x48
		private int <count>5__4; //Field offset: 0x50

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
		public <ProceedStepByStep>d__32(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <TargetParticleSystems>d__19 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ParticleSystem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ThermobaricRenderer <>4__this; //Field offset: 0x28
		private ParticlesConfig[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override ParticleSystem System.Collections.Generic.IEnumerator<UnityEngine.ParticleSystem>.Current
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
		public <TargetParticleSystems>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem>.GetEnumerator() { }

		[DebuggerHidden]
		private override ParticleSystem System.Collections.Generic.IEnumerator<UnityEngine.ParticleSystem>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct ParticleData
	{
		public ParticleSystem System; //Field offset: 0x0
		public ParticleSystemRenderer Renderer; //Field offset: 0x8
		public Material Material; //Field offset: 0x10

	}

	private struct ParticlesConfig
	{
		public ParticleSystem ParticleSystem; //Field offset: 0x0
		public float InitialDelay; //Field offset: 0x8
		public bool UseEase; //Field offset: 0xC
		public float ExpandDuration; //Field offset: 0x10

	}

	private static readonly int _indoorParamId; //Field offset: 0x0
	public static ThermobaricRenderer Instance; //Field offset: 0x8
	private float _indoorParam; //Field offset: 0x20
	[SerializeField]
	private ParticlesConfig[] _controlledSystems; //Field offset: 0x28
	[SerializeField]
	private ParticleSystem _debugPS; //Field offset: 0x30
	[SerializeField]
	private ParticleSystem[] _explosionCenters; //Field offset: 0x38
	[SerializeField]
	private bool _debug; //Field offset: 0x40
	[SerializeField]
	private bool _debugStepByStep; //Field offset: 0x41
	private HashSet _cellsBuffer; //Field offset: 0x48
	private Dictionary _buffers; //Field offset: 0x50
	private Dictionary _particlesConfigs; //Field offset: 0x58
	private ParticleData[] _particleData; //Field offset: 0x60
	private Vector3 _position; //Field offset: 0x68

	public bool IsDebug
	{
		 set { } //Length: 13
	}

	private static ThermobaricRenderer() { }

	public ThermobaricRenderer() { }

	private void Awake() { }

	private static float EaseOutExpo(float start, float end, float value) { }

	private void InitializeParticleData() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	[IteratorStateMachine(typeof(<ProceedParticles>d__31))]
	private IEnumerator ProceedParticles(Vector3 origin, HashSet explosionNodes, ParticleSystem ps, Particle[] buffer, ParticlesConfig config) { }

	[IteratorStateMachine(typeof(<ProceedStepByStep>d__32))]
	private IEnumerator ProceedStepByStep(HashSet nodes, ParticleSystem ps, Particle[] buffer) { }

	public void Push(IEnumerable explosionPositions, Vector3 explosionCenter, Vector3 forward) { }

	public void Push(HashSet explosionNodes, Vector3 explosionCenter, Vector3 forward) { }

	public void set_IsDebug(bool value) { }

	private void Start() { }

	[IteratorStateMachine(typeof(<TargetParticleSystems>d__19))]
	private IEnumerable TargetParticleSystems() { }

	[ContextMenu("TestPush")]
	private void TestPush() { }

	public void TryAddToMBOITParticleManager(ParticleData[] containers) { }

	private void TryRemoveFromMBOITParticleManager(ParticleData[] containers) { }

	private void UpdateIndoorAttenuation(ParticleData[] particleData, bool indoor, bool instant = false) { }

	public void UpdateIndoorAttenuation(Vector3 position) { }

}

