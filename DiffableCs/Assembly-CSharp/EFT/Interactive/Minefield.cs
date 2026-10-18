namespace EFT.Interactive;

public class Minefield : BorderZone
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EBodyPart <DealExplosionDamage>b__16_2(BodyPartCollider x) { }

	}

	[CompilerGenerated]
	private sealed class <FireCoroutine>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IPlayer player; //Field offset: 0x20
		public Minefield <>4__this; //Field offset: 0x28
		private IObserverToPlayerBridge <bridge>5__2; //Field offset: 0x30
		private Vector3 <entrancePosition>5__3; //Field offset: 0x38
		private float <nextExplosionDeepening>5__4; //Field offset: 0x44

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
		public <FireCoroutine>d__14(int <>1__state) { }

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

	private const float DEEPENING_STEP = 1; //Field offset: 0x0
	[SerializeField]
	private float _zoneDistortionPeriod; //Field offset: 0x70
	[SerializeField]
	private float _zoneDistortionPower; //Field offset: 0x74
	[SerializeField]
	private float _contusionStrength; //Field offset: 0x78
	[SerializeField]
	private float _contusionDuration; //Field offset: 0x7C
	[SerializeField]
	private float _collateralContusionRange; //Field offset: 0x80
	[SerializeField]
	private float _collateralDamageRange; //Field offset: 0x84
	[SerializeField]
	private List _explosionTarget; //Field offset: 0x88
	[SerializeField]
	private List _collateralDamageTarget; //Field offset: 0x90
	[SerializeField]
	private float _firstExplosionDamage; //Field offset: 0x98
	[SerializeField]
	private float _minRangeToNextExplosion; //Field offset: 0x9C
	[SerializeField]
	private float _maxRangeToNextExplosion; //Field offset: 0xA0
	[SerializeField]
	private float _secondExplosionDamage; //Field offset: 0xA4

	public Minefield() { }

	[CompilerGenerated]
	private bool <DealExplosionDamage>b__16_0(BodyPartCollider x) { }

	[CompilerGenerated]
	private bool <DealExplosionDamage>b__16_1(BodyPartCollider x) { }

	private void DealExplosionDamage(IPlayer player, float distance, bool first, bool isCollateral) { }

	private void Explode(IPlayer player, bool first) { }

	[IteratorStateMachine(typeof(<FireCoroutine>d__14))]
	protected virtual IEnumerator FireCoroutine(IPlayer player) { }

	protected virtual bool IsInTriggerZone(Vector3 global) { }

}

