namespace EFT.RocketLauncher.Explosion;

public class ParticleRenderer
{
	[CompilerGenerated]
	private sealed class <Execute>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Vector3 center; //Field offset: 0x20
		public ParticleRenderer <>4__this; //Field offset: 0x30
		public IEnumerable edge; //Field offset: 0x38
		public IEnumerable randomGrid; //Field offset: 0x40

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
		public <Execute>d__23(int <>1__state) { }

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
	private sealed class <Render>d__24 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ParticleRenderer <>4__this; //Field offset: 0x20
		private float <time>5__2; //Field offset: 0x28
		private float <intensity>5__3; //Field offset: 0x2C

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
		public <Render>d__24(int <>1__state) { }

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

	private struct Particle
	{
		[UsedImplicitly]
		public float3 WorldPos; //Field offset: 0x0
		[UsedImplicitly]
		public float Size; //Field offset: 0xC
		[UsedImplicitly]
		public float LifeTime; //Field offset: 0x10

	}

	private static readonly int ParticleBufferId; //Field offset: 0x0
	private const float InnerParticleCount = 100; //Field offset: 0x0
	private const float InnerParticleSizeMultiplier = 3; //Field offset: 0x0
	private const float EdgeLifeTime = 0.7; //Field offset: 0x0
	private const float BloomDuration = 0.55; //Field offset: 0x0
	private const CameraEvent InjectionEvent = 17; //Field offset: 0x0
	private static readonly int BlendId; //Field offset: 0x4
	private static readonly int ColorIntensity; //Field offset: 0x8
	private static readonly int IndoorId; //Field offset: 0xC
	private static readonly int ThermalVisionColorId; //Field offset: 0x10
	private readonly List _particles; //Field offset: 0x10
	private readonly int _capacity; //Field offset: 0x18
	private Gradient _gradient; //Field offset: 0x20
	private CommandBuffer _commandBuffer; //Field offset: 0x28
	private ComputeBuffer _particleBuffer; //Field offset: 0x30
	private Material _material; //Field offset: 0x38
	private SSAA _ssaa; //Field offset: 0x40
	private float _particleSize; //Field offset: 0x48
	private float _duration; //Field offset: 0x4C

	private static ParticleRenderer() { }

	public ParticleRenderer() { }

	public void Dispose() { }

	public void DrawEdge(IEnumerable edge) { }

	[IteratorStateMachine(typeof(<Execute>d__23))]
	public IEnumerator Execute(IEnumerable edge, IEnumerable randomGrid, Vector3 center) { }

	public void Initialize(Material material, IVisualSettings settings, Gradient gradient) { }

	private void OnOpticDisabled() { }

	private void OnOpticEnabled() { }

	[IteratorStateMachine(typeof(<Render>d__24))]
	private IEnumerator Render() { }

	private void SetupData(IEnumerable edge, IEnumerable randomGrid) { }

	private void ToggleCommandBuffer(Camera camera, bool add) { }

	private void ToggleGameCameras(bool value) { }

	private void UpdateBuffer() { }

}

