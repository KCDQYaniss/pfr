namespace EFT.Interactive;

public class ObstacleCollider : MonoBehaviour, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Collider parentCollider; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <BreakInToPieces>b__0(RaycastHit c) { }

	}

	private enum EBotPolitic
	{
		Default = 0,
		Ignore = 1,
	}

	public const float NO_SPEED_LIMIT = 1; //Field offset: 0x0
	private const float DEFAULT_SPEED_LIMIT = 0.2; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Ключ использования значений с бэкенда")]
	private string _id; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Запрещено ложиться")]
	private bool _disablesProne; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Запрещено ползать")]
	private bool _disablesProneMove; //Field offset: 0x29
	[SerializeField]
	[Tooltip("Запрещено прыгать")]
	private bool _disablesJump; //Field offset: 0x2A
	[SerializeField]
	[Tooltip("Запрещено спринтовать")]
	private bool _disablesSprint; //Field offset: 0x2B
	[SerializeField]
	[Tooltip("Ограничение скорости (болото)")]
	private bool _hasSwampSpeedLimit; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Работает ли на ботов")]
	private EBotPolitic _botPolitic; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Волтинг запрещен")]
	private bool _disablesVaulting; //Field offset: 0x34
	public float speedMlp; //Field offset: 0x38

	public EPhysicalCondition ConditionsMask
	{
		 get { } //Length: 56
	}

	public override string Description
	{
		 get { } //Length: 49
	}

	public bool DisablesVaulting
	{
		 get { } //Length: 5
	}

	public ObstacleCollider() { }

	public void BreakInToPieces() { }

	public EPhysicalCondition get_ConditionsMask() { }

	public override string get_Description() { }

	public bool get_DisablesVaulting() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	private void Start() { }

}

