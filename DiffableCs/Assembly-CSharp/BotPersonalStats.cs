//Type is in global namespace

public class BotPersonalStats
{
	public const float DIST1 = 13; //Field offset: 0x0
	public const float DIST2 = 27; //Field offset: 0x0
	public const float DIST3 = 43; //Field offset: 0x0
	public const float DIST4 = 60; //Field offset: 0x0
	public const float DIST5 = 86; //Field offset: 0x0
	public const float DIST6 = 120; //Field offset: 0x0
	public const float DIST7 = 160; //Field offset: 0x0
	private const string NULL_ID = "Null_id"; //Field offset: 0x0
	public static float[] DISTANCES; //Field offset: 0x0
	public static int STAT_INDEX; //Field offset: 0x8
	public float LifeTime; //Field offset: 0x10
	public int CoverPointsTaken; //Field offset: 0x14
	public bool IsDead; //Field offset: 0x18
	public float TotaTimeInCover; //Field offset: 0x1C
	public float middleGrendaThrowDist; //Field offset: 0x20
	public float MiddleTimeInCover; //Field offset: 0x24
	public string WeaponType; //Field offset: 0x28
	public string Zone; //Field offset: 0x30
	public string MySide; //Field offset: 0x38
	public string ProfileId; //Field offset: 0x40
	public string Difficulty; //Field offset: 0x48
	public float TotalDamage; //Field offset: 0x50
	public float BornTime; //Field offset: 0x54
	public int HaveGrenadesStart; //Field offset: 0x58
	public int GrenadeTrowed; //Field offset: 0x5C
	public int KilledByGrenade; //Field offset: 0x60
	public Dictionary targetStats; //Field offset: 0x68
	public Dictionary HitsGain; //Field offset: 0x70
	public Dictionary Frags; //Field offset: 0x78
	public Dictionary StandByTimes; //Field offset: 0x80
	public GainSightStat gainSightStats; //Field offset: 0x88
	public AimingStats AimingStats; //Field offset: 0x90
	private float TimeComeToCover; //Field offset: 0x98
	private BotOwner _owner; //Field offset: 0xA0
	private bool isWritten; //Field offset: 0xA8
	private float curStandByTime; //Field offset: 0xAC
	public string WildType; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnKillTarget; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0xC0
	private bool isEnable; //Field offset: 0xC8

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnKillTarget
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool IsEnable
	{
		 get { } //Length: 8
	}

	private static BotPersonalStats() { }

	public BotPersonalStats() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	[CompilerGenerated]
	public void add_OnKillTarget(Action value) { }

	public void AddGetVision(float distanceToEnemy, float visibilityK) { }

	public void Aim(Vector3 to, float time) { }

	public void CoverTaken() { }

	public void Death(EDamageType damageType) { }

	public void Dispose() { }

	public void Enable(bool val = true) { }

	public bool get_IsEnable() { }

	public void GetHit(DamageInfo damageInfo, EBodyPart bodyType) { }

	public static int GetIndex(float d) { }

	public int GetShootByTarget(EnemyInfo person) { }

	public void GrendateThrow(Nullable trg) { }

	public void HitTarget(IPlayer person, DamageInfo damageInfo, EBodyPart bodyPart) { }

	public void Init(BotOwner owner, string Zone) { }

	public void KillTarget(string killer, DamageInfo info) { }

	public void LeaveCover() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	[CompilerGenerated]
	public void remove_OnKillTarget(Action value) { }

	public void SetStandByState(BotStandByType prevByType) { }

	public void SetWeapon(Weapon weapon) { }

	public void ShootToTarget(EnemyInfo person, Nullable pos = null) { }

	private void WriteToFile() { }

}

