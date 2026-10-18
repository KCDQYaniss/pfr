namespace EFT.Interactive;

public class SniperFiringZone : BorderZone
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Shoot>b__23_0(BodyPartCollider x) { }

	}

	[CompilerGenerated]
	private sealed class <FireCoroutine>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SniperFiringZone <>4__this; //Field offset: 0x20
		public IPlayer player; //Field offset: 0x28
		private bool <isFirst>5__2; //Field offset: 0x30
		private int <triggerZoneShots>5__3; //Field offset: 0x34
		private bool <isInTriggerZone>5__4; //Field offset: 0x38
		private bool <willHit>5__5; //Field offset: 0x39

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
		public <FireCoroutine>d__22(int <>1__state) { }

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

	protected const float IMITATOR_NOTIFICATION_DELAY = 2; //Field offset: 0x0
	[SerializeField]
	private float _shotFrequency; //Field offset: 0x70
	[SerializeField]
	private float _triggerZoneHitProbability; //Field offset: 0x74
	[SerializeField]
	private float _bufferZoneHitProbability; //Field offset: 0x78
	[SerializeField]
	private float _firstShotHitProbability; //Field offset: 0x7C
	[SerializeField]
	private int _becomeLethalIfShotsCountExceed; //Field offset: 0x80
	[SerializeField]
	private string _ammoTemplate; //Field offset: 0x88
	[SerializeField]
	private List _triggerZoneTarget; //Field offset: 0x90
	[SerializeField]
	private List _bufferZoneTarget; //Field offset: 0x98
	[SerializeField]
	private PlayersWithImmuneToSniperFire _playersWithImmuneToFire; //Field offset: 0xA0
	[SerializeField]
	private EDamageType _damageType; //Field offset: 0xA8
	[SerializeField]
	private bool _needToWaitDelay; //Field offset: 0xAC
	private Ammo _ammo; //Field offset: 0xB0

	public Ammo Ammo
	{
		 get { } //Length: 482
	}

	public float BulletSpeed
	{
		 get { } //Length: 93
	}

	public virtual float Delay
	{
		 get { } //Length: 22
	}

	private float ShotDamage
	{
		private get { } //Length: 96
	}

	public SniperFiringZone() { }

	[CompilerGenerated]
	private bool <Shoot>b__23_1(BodyPartCollider x) { }

	[CompilerGenerated]
	private bool <Shoot>b__23_2(BodyPartCollider x) { }

	[IteratorStateMachine(typeof(<FireCoroutine>d__22))]
	protected virtual IEnumerator FireCoroutine(IPlayer player) { }

	public Ammo get_Ammo() { }

	public float get_BulletSpeed() { }

	public virtual float get_Delay() { }

	private float get_ShotDamage() { }

	private bool IsInBtr(IPlayer player) { }

	private bool IsPlayerCanBeDamaged(IPlayer player) { }

	private bool IsSniperImmuneBot(IPlayer player) { }

	protected override void Shoot(IPlayer player, bool isInTriggerZone, bool first, bool lethal) { }

}

