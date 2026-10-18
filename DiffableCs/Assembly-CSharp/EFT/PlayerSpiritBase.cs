namespace EFT;

[DisallowMultipleComponent]
public abstract class PlayerSpiritBase : AssetPoolObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__35_37; //Field offset: 0x8
		public static Action <>9__35_39; //Field offset: 0x10
		public static Action <>9__35_40; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <Init>b__35_37(Vector3 value) { }

		internal void <Init>b__35_39(Quaternion value) { }

		internal void <Init>b__35_40(Vector3 pos, Quaternion rot) { }

	}

	public static int PLAYER_FOOTPRINTS_HISTORY_LENGTH; //Field offset: 0x0
	public const int FOOTPRINTS_POOL_LENGTH = 300; //Field offset: 0x0
	public static int BOT_FOOTPRINTS_HISTORY_LENGTH; //Field offset: 0x4
	public Animator BodyAnimator; //Field offset: 0x90
	private IAnimator _bodyAnimatorWrapper; //Field offset: 0x98
	[HideInInspector]
	public IAnimator ArmsAnimator; //Field offset: 0xA0
	[SerializeField]
	protected Transform _bodyTransform; //Field offset: 0xA8
	[SerializeField]
	protected Transform _animatedTransform; //Field offset: 0xB0
	[SerializeField]
	protected RootMotionBlendTable RootMotionTable; //Field offset: 0xB8
	[HideInInspector]
	public Vector2 LookRotation; //Field offset: 0xC0
	[HideInInspector]
	public Vector2 PreviousLookRotation; //Field offset: 0xC8
	[SerializeField]
	protected CharacterControllerSpawner _characterControllerSpawner; //Field offset: 0xD0
	protected ICharacterController _characterController; //Field offset: 0xD8
	[SerializeField]
	public PlayerSpiritAura PlayerSpiritAura; //Field offset: 0xE0
	public NavMeshAgent NavMeshAgent; //Field offset: 0xE8
	public PlayerSpiritBones Bones; //Field offset: 0xF0
	protected float _armsLength; //Field offset: 0xF8
	[HideInInspector]
	public Player _player; //Field offset: 0x100
	protected bool _isActive; //Field offset: 0x108
	protected bool _isBodyAnimatorUpdating; //Field offset: 0x109
	protected bool _updateFastAnimator; //Field offset: 0x10A
	private Mode _characterControllerMode; //Field offset: 0x110
	private Mode _disconnectedCharacterControllerMode; //Field offset: 0x118
	private bool _isInDisconnectedMode; //Field offset: 0x120
	private bool _needAuraUpdate; //Field offset: 0x121
	private bool PlayerSynced; //Field offset: 0x122

	public override IAnimator BodyAnimatorWrapper
	{
		 get { } //Length: 173
	}

	public ICharacterController CharacterController
	{
		 get { } //Length: 8
	}

	public Mode CharacterControllerMode
	{
		 get { } //Length: 25
	}

	public bool IsActive
	{
		 get { } //Length: 8
	}

	public TriggerColliderSearcher TriggerColliderSearcher
	{
		 get { } //Length: 30
	}

	private static PlayerSpiritBase() { }

	protected PlayerSpiritBase() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_0() { }

	[CompilerGenerated]
	private void <Init>b__35_1(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_10() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_11() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_12() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_13(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_14(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_15(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_16(Vector3 value) { }

	[CompilerGenerated]
	private void <Init>b__35_17(Vector3 v1, Vector3 v2) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_18() { }

	[CompilerGenerated]
	private void <Init>b__35_19(Vector3 value) { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_2() { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_20() { }

	[CompilerGenerated]
	private void <Init>b__35_21(Quaternion value) { }

	[CompilerGenerated]
	private void <Init>b__35_22(Vector3 pos, Quaternion rot) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_23() { }

	[CompilerGenerated]
	private void <Init>b__35_24(Vector3 value) { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_25() { }

	[CompilerGenerated]
	private void <Init>b__35_26(Quaternion value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_27() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_28() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_29() { }

	[CompilerGenerated]
	private void <Init>b__35_3(Quaternion value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_30() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_31(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_32(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_33(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_34(Vector3 value) { }

	[CompilerGenerated]
	private void <Init>b__35_35(Vector3 v1, Vector3 v2) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_36() { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_38() { }

	[CompilerGenerated]
	private void <Init>b__35_4(Vector3 pos, Quaternion rot) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_41() { }

	[CompilerGenerated]
	private void <Init>b__35_42(Vector3 value) { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_43() { }

	[CompilerGenerated]
	private void <Init>b__35_44(Quaternion value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_45() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_46() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_47() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_48(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_49(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_5() { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_50(Vector3 value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_51(Vector3 value) { }

	[CompilerGenerated]
	private void <Init>b__35_52(Vector3 v1, Vector3 v2) { }

	[CompilerGenerated]
	private void <Init>b__35_6(Vector3 value) { }

	[CompilerGenerated]
	private Quaternion <Init>b__35_7() { }

	[CompilerGenerated]
	private void <Init>b__35_8(Quaternion value) { }

	[CompilerGenerated]
	private Vector3 <Init>b__35_9() { }

	public void BotOnlySetCollidersState(bool state) { }

	protected void ChangePose() { }

	private void CreateCharacterController(Mode characterControllerMode) { }

	protected PlayerSpiritFootprint CreateFootprint() { }

	public void Die() { }

	protected void EnableBoneImitation(bool useImitation) { }

	protected void FixedUpdate() { }

	public override IAnimator get_BodyAnimatorWrapper() { }

	public ICharacterController get_CharacterController() { }

	public Mode get_CharacterControllerMode() { }

	public bool get_IsActive() { }

	public TriggerColliderSearcher get_TriggerColliderSearcher() { }

	public Transform GetActiveTransform() { }

	public override void Init(Player player, Vector3 position, bool isBodyAnimatorUpdating, Mode characterControllerMode, Mode disconnectedCharacterControllerMode) { }

	public override void InitAfterPlayerInit() { }

	public void InitArmsAnimator(IAnimator animator, RuntimeAnimatorController animatorController, IAnimator animatorRoleModel, bool isAnimatorEnabled) { }

	public void InitBodyAnimator(AnimatorUpdateMode updateMode, bool useFastAnimator) { }

	protected Vector3 NotImplementedPosition() { }

	protected Quaternion NotImplementedRotation() { }

	protected void OnCharacterControllerHeightChanged(float value) { }

	protected virtual void OnDestroy() { }

	private void OnStepChanged(int before, int after) { }

	public void OnTiltChanged(float value) { }

	protected void PlayerArmsSync(PlayerSpiritFootprint footprint, bool updateAnimator = true) { }

	protected void PlayerBodySync(PlayerSpiritFootprint footprint, bool updateAnimator = true) { }

	public void PlayerSync(PlayerSpiritFootprint footprint, bool updateAnimator = true) { }

	public abstract void PlayerSync() { }

	public void SetActive(bool active) { }

	private void SetSpiritAnimatorController() { }

	public void SwitchToDisconnectedMode() { }

	public void SwitchToNormalMode() { }

	protected void SyncAnimators(IAnimator animatorRecipient, AnimatorFootprint footprint) { }

	protected override void TranslateAnimatorState(IAnimator animatorRecipient, IAnimator animatorDonor) { }

	protected void Update() { }

}

