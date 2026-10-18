namespace EFT.Ballistics;

public class BallisticsCalculator : MonoBehaviour, IBallisticsCalculator
{
	private struct Task
	{
		public readonly float SimulationTime; //Field offset: 0x0
		public readonly Shot Shot; //Field offset: 0x8

		public Task(float simulationTime, Shot shot) { }

	}

	public const int RND_COUNT = 512; //Field offset: 0x0
	private static BallisticCollider _defaultHitBody; //Field offset: 0x0
	private int _fireIndex; //Field offset: 0x20
	public List Shots; //Field offset: 0x28
	private List _shotsToRelease; //Field offset: 0x30
	private readonly Queue _schedule; //Field offset: 0x38
	private ShotDelegate _shotDelegate; //Field offset: 0x40
	private readonly List _visualAmmoInfos; //Field offset: 0x48
	[CompilerGenerated]
	private PrecalculatedRandoms <Randoms>k__BackingField; //Field offset: 0x50
	private bool _showDebug; //Field offset: 0x58
	private Predicate _removePredicate; //Field offset: 0x60

	public static BallisticCollider DefaultHitBody
	{
		 get { } //Length: 658
	}

	private override int EFT.Ballistics.IBallisticsCalculator.ActiveShotsCount
	{
		private get { } //Length: 65
	}

	private override BallisticCollider EFT.Ballistics.IBallisticsCalculator.DefaultHitBody
	{
		private get { } //Length: 7
	}

	public private PrecalculatedRandoms Randoms
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BallisticsCalculator() { }

	public override void ClearShots() { }

	public static BallisticsCalculator Create(GameObject gameObject, int seed, ShotDelegate shotCallback, bool showDebug = true) { }

	public void CreateMultiProjectileShot(Ammo ammo, Vector3 origin, Vector3 direction, float speedFactor, List preallocatedShots, Vector3 abc, int playerRaidId, Item weapon) { }

	public Shot CreateShot(Ammo ammo, Vector3 origin, Vector3 direction, int fireIndex, Vector3 abc, int playerRaidId, Item weapon, float speedFactor = 1, int fragmentIndex = 0) { }

	[Conditional("CLIENT")]
	private void CreateVisualBulletInstance(Shot shot) { }

	[Conditional("CLIENT")]
	private void CreateVisualRocketInstance(Shot shot, Transform ammoPrefab, bool needReturnToPool) { }

	private override int EFT.Ballistics.IBallisticsCalculator.get_ActiveShotsCount() { }

	private override BallisticCollider EFT.Ballistics.IBallisticsCalculator.get_DefaultHitBody() { }

	private override Shot EFT.Ballistics.IBallisticsCalculator.GetActiveShot(int shotsIndex) { }

	private override Shot EFT.Ballistics.IBallisticsCalculator.Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, Vector3 abc, int playerRaidId, Item item, float speedFactor, int fragmentIndex) { }

	private override Shot EFT.Ballistics.IBallisticsCalculator.Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, int fireIndex, int playerRaidId, Item item, float speedFactor, int fragmentIndex) { }

	private override Shot EFT.Ballistics.IBallisticsCalculator.Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, int playerRaidId, Item item, float speedFactor, int fragmentIndex, Transform ammoPrefab, bool needReturnToPool) { }

	private override void EFT.Ballistics.IBallisticsCalculator.ShotMultiProjectileShot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, float speedFactor, List preAllocatedShots, Vector3 abc, int playerRaidId, Item item) { }

	public static BallisticCollider get_DefaultHitBody() { }

	[CompilerGenerated]
	public PrecalculatedRandoms get_Randoms() { }

	public static float GetAmmoPenetrationPower(Ammo ammo, int randomInt, IRandom randoms) { }

	public override void ManualUpdate(float deltaTime) { }

	public void PreWarmerSimulateShotNoPool(Shot shot, float simulationTime, float simulationStep) { }

	private bool RemovePredicate(Shot shot) { }

	[CompilerGenerated]
	private void set_Randoms(PrecalculatedRandoms value) { }

	public void Shoot(Shot shot, Transform ammoPrefab, bool needReturnToPool) { }

	public void Shoot(Shot shot) { }

	public void SimulateShot(Shot shot, float simulationTime, float simulationStep) { }

	private void SimulateShotInternal(Shot shot, float simulationTime, float simulationStep) { }

	private void UpdateShots(float simulationTime) { }

	[Conditional("CLIENT")]
	private void UpdateVisualBullets() { }

}

