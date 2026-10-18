//Type is in global namespace

public class BotGrenadeController : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__49_0; //Field offset: 0x8
		public static Func <>9__64_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CheckGrenadeWithType>b__64_0(Item x) { }

		internal bool <HaveGrenadeOfType>b__49_0(Item x) { }

	}

	public const float DEFAULT_GRENADE_WIEGHT = 0.5; //Field offset: 0x0
	private const float WAIT_FOR_THROW_TIME = 0.4; //Field offset: 0x0
	[CompilerGenerated]
	private AIGreanageThrowData <AIGreanageThrowData>k__BackingField; //Field offset: 0x18
	public Vector3 LastThrowDirection; //Field offset: 0x20
	public float MaxThrowForce; //Field offset: 0x2C
	private ThrowWeap grenade; //Field offset: 0x30
	private GrenadeActionType GrenadeActionType; //Field offset: 0x38
	private float _clearTime; //Field offset: 0x3C
	private bool _checkStop; //Field offset: 0x40
	private float _nextPosibleAttempt; //Field offset: 0x44
	private readonly float _lastThrowTime; //Field offset: 0x48
	private Vector3 _precisionOffset; //Field offset: 0x4C
	private bool _inventoryUpdateDirty; //Field offset: 0x58
	private readonly Stopwatch _grenadeThrowStopwatch; //Field offset: 0x60
	private double _lastGrenadeThrowElapsedMs; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnGrenadeThrowComplete; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnGrenadeThrowStart; //Field offset: 0x78
	[CompilerGenerated]
	private bool <ThrowindNow>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private float <Mass>k__BackingField; //Field offset: 0x84

	public event Action OnGrenadeThrowComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnGrenadeThrowStart
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private AIGreanageThrowData AIGreanageThrowData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveGrenade
	{
		 get { } //Length: 9
	}

	public private float Mass
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float MaxPower
	{
		 get { } //Length: 66
	}

	public bool NearLastThrow
	{
		 get { } //Length: 136
	}

	public Vector3 PrecisionOffset
	{
		 get { } //Length: 19
	}

	public bool ReadyToThrow
	{
		 get { } //Length: 29
	}

	public Vector3 StartThrow
	{
		 get { } //Length: 95
	}

	public private bool ThrowindNow
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Vector3 ToThrowDirection
	{
		 get { } //Length: 78
	}

	public BotGrenadeController(BotOwner owner) { }

	[CompilerGenerated]
	private void <EndAll>b__69_0() { }

	[CompilerGenerated]
	private void <ThrowCallbackInner>b__54_0() { }

	[CompilerGenerated]
	private void <ThrowCallbackInner>b__54_1(Result throwResult) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnGrenadeThrowComplete(Action value) { }

	[CompilerGenerated]
	public void add_OnGrenadeThrowStart(Action value) { }

	private bool AimingUpd() { }

	public bool CanThrowGrenade(Vector3 playerPosition, Vector3 trg) { }

	public bool CanThrowGrenade(Vector3 trg) { }

	private bool CheckFriend(Vector3 trg) { }

	private void CheckGrenade() { }

	private void CheckGrenadeWithType(ThrowWeapType grenadeType) { }

	public bool CheckPeriodTime() { }

	public void Dispose() { }

	public bool DoThrow() { }

	private void EndAll(ThrowWeap grenade = null) { }

	[CompilerGenerated]
	public AIGreanageThrowData get_AIGreanageThrowData() { }

	public bool get_HaveGrenade() { }

	[CompilerGenerated]
	public float get_Mass() { }

	public float get_MaxPower() { }

	public bool get_NearLastThrow() { }

	public Vector3 get_PrecisionOffset() { }

	public bool get_ReadyToThrow() { }

	public Vector3 get_StartThrow() { }

	[CompilerGenerated]
	public bool get_ThrowindNow() { }

	public Vector3 get_ToThrowDirection() { }

	public int GetGrenadeCount() { }

	public double GetLastGrenadeThrowElapsedMs() { }

	public bool HaveGrenadeOfType(ThrowWeapType grenadeType) { }

	private bool Look2ThrowDir() { }

	public void NextThrowNoOffset() { }

	public void NextThrowOffset(Vector3 nextOffset) { }

	[CompilerGenerated]
	public void remove_OnGrenadeThrowComplete(Action value) { }

	[CompilerGenerated]
	public void remove_OnGrenadeThrowStart(Action value) { }

	[CompilerGenerated]
	private void set_AIGreanageThrowData(AIGreanageThrowData value) { }

	[CompilerGenerated]
	private void set_Mass(float value) { }

	[CompilerGenerated]
	private void set_ThrowindNow(bool value) { }

	public void SetDirty() { }

	public bool SetThrowData(AIGreanageThrowData data) { }

	private void SetThrowParams(ThrowWeap potentialGrenade) { }

	private void ThrowCallbackInner() { }

	private void ThrowCallbackQuick(Result result) { }

	private void ThrowCallbackSlow(Result result) { }

	public void UpdateCheck() { }

	private void UpdatePrecisionOffset() { }

	private void UpdNextAttempt() { }

}

