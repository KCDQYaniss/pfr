namespace EFT.RocketLauncher.Explosion;

public class ExplosionModel : IExplosionModel
{
	[CompilerGenerated]
	private sealed class <Explode>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ExplosionModel <>4__this; //Field offset: 0x20
		public Vector3 epicenter; //Field offset: 0x28

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
		public <Explode>d__9(int <>1__state) { }

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

	private readonly IExplosionSettings _explosionSettings; //Field offset: 0x10
	private readonly ParticleRenderer _renderer; //Field offset: 0x18
	private readonly ExplosionPropagationModel _explosionPropagation; //Field offset: 0x20
	private readonly CollisionsHandlerModel _collidersHandler; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnExplosionCompleatedEvent; //Field offset: 0x30

	public override event Action OnExplosionCompleatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ExplosionModel() { }

	[CompilerGenerated]
	private float <Initialize>b__8_0() { }

	[CompilerGenerated]
	private float <Initialize>b__8_1() { }

	[CompilerGenerated]
	private float <Initialize>b__8_2() { }

	[CompilerGenerated]
	private ComputableUnitType <Initialize>b__8_3() { }

	[CompilerGenerated]
	public override void add_OnExplosionCompleatedEvent(Action value) { }

	public override void Dispose() { }

	[IteratorStateMachine(typeof(<Explode>d__9))]
	public override IEnumerator Explode(Vector3 epicenter) { }

	public void Initialize(Weapon weapon, IPlayer player, IExplosionSettings settings, Material material, Gradient thermalGradient) { }

	private void OnCollectionUpdated(IEnumerable collection) { }

	[CompilerGenerated]
	public override void remove_OnExplosionCompleatedEvent(Action value) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

