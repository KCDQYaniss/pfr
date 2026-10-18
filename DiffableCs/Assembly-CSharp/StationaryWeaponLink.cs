//Type is in global namespace

public class StationaryWeaponLink : MonoBehaviour, IAICorePointLink
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Vector3 pos; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal StationaryWeapon <Init>b__0(StationaryWeapon x1, StationaryWeapon x2) { }

	}

	public StationaryWeapon Weapon; //Field offset: 0x20
	public Vector3 InitialDir; //Field offset: 0x28
	public float CosAngleBase; //Field offset: 0x34
	private Weapon _weaponItem; //Field offset: 0x38
	private BotOwner _curOwner; //Field offset: 0x40
	private int _curOwnerId; //Field offset: 0x48
	private float _lastDeathAtStationary; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <BadLoad>k__BackingField; //Field offset: 0x50
	[SerializeField]
	private int _corePointId; //Field offset: 0x54
	[SerializeField]
	private AICorePoint _corePoint; //Field offset: 0x58

	public private bool BadLoad
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public int CurOwnerId
	{
		 get { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public StationaryWeaponLink() { }

	public string AmmoInfo() { }

	public bool CanTakeByPrevDeath(float needPeriod) { }

	public void ClearOwner() { }

	public void DeathAtStationary() { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_BadLoad() { }

	public override AICorePoint get_CorePointInGame() { }

	public int get_CurOwnerId() { }

	public override Vector3 get_Position() { }

	public bool HaveAmmo() { }

	public bool Init() { }

	public bool IsFree(int id) { }

	public bool IsGrenade() { }

	public void Restore(AICorePointHolder holder) { }

	[CompilerGenerated]
	private void set_BadLoad(bool value) { }

	public void SetCorePoint(AICorePoint core) { }

	public void SetOwner(BotOwner bot) { }

}

