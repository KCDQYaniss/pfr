namespace EFT;

public class SpeedLimiter
{
	internal class Config
	{
		public PlayerStateLimits DefaultPlayerStateLimits; //Field offset: 0x10
		public Dictionary PlayerStateLimits; //Field offset: 0x18

		public Config() { }

		public void Deserialize(NetworkReader reader) { }

		public void Serialize(NetworkWriter writer) { }

	}

	internal struct PlayerStateLimits
	{
		public float MinSpeed; //Field offset: 0x0
		public float MaxSpeed; //Field offset: 0x4

		public void Deserialize(NetworkReader reader) { }

		public void Serialize(NetworkWriter writer) { }

	}

	private static readonly PlayerStateLimits _runSpeedLimit; //Field offset: 0x0
	private static readonly PlayerStateLimits _sprintSpeedLimit; //Field offset: 0x8
	private static readonly PlayerStateLimits _idleSpeedLimit; //Field offset: 0x10
	public static readonly Config DefaultSpeedLimits; //Field offset: 0x18
	private Config _config; //Field offset: 0x10
	private int _maxStrengthLevel; //Field offset: 0x18
	private float _speed; //Field offset: 0x1C
	[CompilerGenerated]
	private Action OnSpeedChanged; //Field offset: 0x20

	public event Action OnSpeedChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float Speed
	{
		 get { } //Length: 6
		 set { } //Length: 76
	}

	private static SpeedLimiter() { }

	public SpeedLimiter(Config config, int maxStrengthLevel) { }

	[CompilerGenerated]
	public void add_OnSpeedChanged(Action value) { }

	public static float CalculateDistance(Vector3 from, Vector3 to, bool skipY = false) { }

	public static float CalculateSpeed(float distance, float time) { }

	public static float CalculateSqrDistance(Vector3 from, Vector3 to, bool skipY = false) { }

	public float get_Speed() { }

	private PlayerStateLimits GetPlayerStateConfig(EPlayerState state) { }

	protected float GetSpeed(EPlayerState state, int strengthLevel, float walkSpeedLimit) { }

	[CompilerGenerated]
	public void remove_OnSpeedChanged(Action value) { }

	protected void set_Speed(float value) { }

	public override void Update(EPlayerState state, int strengthLevel, float walkSpeedLimit) { }

	public override void Update(float deltaTime) { }

}

