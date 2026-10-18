namespace EFT.RocketLauncher.Explosion;

public class ExplosionTester : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Explode>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ExplosionTester <>4__this; //Field offset: 0x20

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
		public <Explode>d__11(int <>1__state) { }

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

	private class VisualSettings : IVisualSettings
	{
		[CompilerGenerated]
		private readonly float <Duration>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly float <ParticleSize>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private readonly int <Capacity>k__BackingField; //Field offset: 0x18

		public override int Capacity
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public override float Duration
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public override float ParticleSize
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public VisualSettings(float duration, float particleSize, int capacity) { }

		[CompilerGenerated]
		public override int get_Capacity() { }

		[CompilerGenerated]
		public override float get_Duration() { }

		[CompilerGenerated]
		public override float get_ParticleSize() { }

	}

	private ParticleRenderer _renderer; //Field offset: 0x20
	private bool _isInProgress; //Field offset: 0x28
	[SerializeField]
	private Material _material; //Field offset: 0x30
	[SerializeField]
	private float _radius; //Field offset: 0x38
	[SerializeField]
	private float _particleSize; //Field offset: 0x3C
	[SerializeField]
	private float _duration; //Field offset: 0x40
	[SerializeField]
	private int _capacity; //Field offset: 0x44
	[SerializeField]
	private KeyCode _explodeKey; //Field offset: 0x48
	[SerializeField]
	private Gradient _thermalVision; //Field offset: 0x50

	public ExplosionTester() { }

	[IteratorStateMachine(typeof(<Explode>d__11))]
	private IEnumerator Explode() { }

	private IEnumerable GetEdge() { }

	private IEnumerable GetGrid() { }

	private void TryInitialize() { }

	private void Update() { }

}

