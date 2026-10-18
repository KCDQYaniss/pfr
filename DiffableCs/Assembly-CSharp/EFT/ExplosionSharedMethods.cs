namespace EFT;

[Extension]
public static class ExplosionSharedMethods
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Vector3 grenadePosition; //Field offset: 0x10
		public LayerMask limbsMask; //Field offset: 0x1C

		public <>c__DisplayClass14_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public Vector3 hitPosition; //Field offset: 0x10
		public RaycastHit hit; //Field offset: 0x1C
		public float distance; //Field offset: 0x48
		public Vector3 forwardHitPoint; //Field offset: 0x4C
		public <>c__DisplayClass14_0 CS$<>8__locals1; //Field offset: 0x58

		public <>c__DisplayClass14_1() { }

		internal float <AffectPlayersShared>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <SpawnRandomFragments>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IExplosiveItem grenadeItem; //Field offset: 0x20
		public bool skyExpl; //Field offset: 0x28
		public bool groundExpl; //Field offset: 0x29
		public IBallisticsCalculator calculator; //Field offset: 0x30
		public Vector3 grenadePosition; //Field offset: 0x38
		public int playerProfileID; //Field offset: 0x44
		public Item originalWeaponItem; //Field offset: 0x48
		public int fragmentsCount; //Field offset: 0x50
		private Ammo <fragments>5__2; //Field offset: 0x58
		private int <i>5__3; //Field offset: 0x60

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
		public <SpawnRandomFragments>d__18(int <>1__state) { }

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
	private static Action OnExplosion; //Field offset: 0x0
	private const int GIZMOS_DURATION = 10; //Field offset: 0x0
	private const int MAX_FRAGMENTS = 30; //Field offset: 0x0
	private const int MAX_FRAGMENTS_PER_FRAME = 8; //Field offset: 0x0
	private static int GlobalFragmentNumber; //Field offset: 0x8
	private static readonly Dictionary _armorDamageBuffer; //Field offset: 0x10
	private static readonly Collider[] _colliderBuffer; //Field offset: 0x18
	private static readonly List _bodyPartCollidersBuffer; //Field offset: 0x20
	private static readonly HashSet _damagedPlayers; //Field offset: 0x28
	private static readonly RaycastHit[] _hitsBuffer; //Field offset: 0x30
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"limb", "damageInfo"})]
	private static readonly Dictionary _damagedParts; //Field offset: 0x38
	private static readonly Dictionary _playerBuffer; //Field offset: 0x40

	public static event Action OnExplosion
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	private static ExplosionSharedMethods() { }

	[CompilerGenerated]
	public static void add_OnExplosion(Action value) { }

	private static void AffectPlayersShared(IReadOnlyDictionary playerAndDistances, IExplosiveItem grenadeItem, Vector3 grenadePosition, Func getDamageInfo, float directionalDamageMultiplier, float directionalDamageAngle, Nullable explosionDirection, bool deadlyMinDistance) { }

	private static float CircularEaseIn(float p) { }

	[Extension]
	public static void Explosion(IExplosiveItem grenadeItem, Vector3 explosionPosition, int playerRaidIDWhoThrew, IBallisticsCalculator ballisticsCalculator, Item originalWeaponItem, Func getDamageInfo, float directionalDamageMultiplier, float directionalDamageAngle, Nullable explosionDirection, bool deadlyMinDistance) { }

	[CompilerGenerated]
	public static void remove_OnExplosion(Action value) { }

	[IteratorStateMachine(typeof(<SpawnRandomFragments>d__18))]
	private static IEnumerator SpawnRandomFragments(bool groundExpl, bool skyExpl, int fragmentsCount, IBallisticsCalculator calculator, IExplosiveItem grenadeItem, Vector3 grenadePosition, int playerProfileID, Item originalWeaponItem) { }

	private static bool TryGetBallisticCollider(RaycastHit hit, out BallisticCollider ballisticCollider) { }

}

