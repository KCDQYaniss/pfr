//Type is in global namespace

public class BotLay : BotData
{
	public const float LAY_SHOOT_HEIGHT = 0.14; //Field offset: 0x0
	private int _damageTimes; //Field offset: 0x18
	private float _layTime; //Field offset: 0x1C
	private float _nextAttackCheckCanLay; //Field offset: 0x20
	private float _nextPosibleCheckCanLay; //Field offset: 0x24
	private float _nextPosibleGetUp; //Field offset: 0x28
	private readonly float _tan; //Field offset: 0x2C
	private readonly MovementContext _movementContext; //Field offset: 0x30
	private float _endPeriodNoCheck; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnLay; //Field offset: 0x40

	public event Action OnLay
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool CanProne
	{
		 get { } //Length: 107
	}

	public private bool IsLay
	{
		 get { } //Length: 42
		private set { } //Length: 1390
	}

	public BotLay(BotOwner owner) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnLay(Action value) { }

	public bool CanLayByPeriod() { }

	public bool CanLayWithoutCheck() { }

	public bool CanShootPos(Vector3 goalEnemy, bool withCheckShoot, bool withFriendlyFire) { }

	public bool CanShootPos(EnemyInfo goalEnemy, bool withCheckShoot, bool withFriendlyFire) { }

	public bool CheckDistGood() { }

	public void CheckGetUp() { }

	public void Damaged() { }

	public void DelayPosibleLayFor(float period) { }

	public void Dispose() { }

	public bool get_CanProne() { }

	public bool get_IsLay() { }

	public void GetUp(bool withCheck) { }

	private void OnCantRotate(ECantRotate cause) { }

	[CompilerGenerated]
	public void remove_OnLay(Action value) { }

	private void set_IsLay(bool value) { }

	private bool ShallIGetUp() { }

	public bool TryLay() { }

}

