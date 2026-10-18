namespace EFT.NextObservedPlayer;

public class ObservedPlayerView : MonoBehaviour, IPlayer
{
	private const float FBB_IK_COOLDOWN = 0.6; //Field offset: 0x0
	private static readonly List _activeViews; //Field offset: 0x0
	private static int _lastBatchLateUpdateFrame; //Field offset: 0x8
	private static bool _isBatchLateUpdateRunning; //Field offset: 0xC
	[CompilerGenerated]
	private int <RaidId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ObservedPlayerController <ObservedPlayerController>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly IPlayerSearchController <SearchController>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly PlayerRecorderController <RecorderController>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <Voice>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private IAnimator <BodyAnimator>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private PlayerAnimator <PlayerAnimator>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Collider[] <Colliders>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Transform <SpectatorTransform>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private ECameraType <VisibleToCameraType>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsVisibleToCamera>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private float <WorldTime>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private IAIData <AIData>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private EPlayerBtrState <BtrState>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private BTRSide <BtrInteractionSide>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <GroupId>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private string <TeamId>k__BackingField; //Field offset: 0xA0
	public float RibcageScaleCurrent; //Field offset: 0xA8
	public float RibcageScaleCurrentTarget; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <UsedSimplifiedSkeleton>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <UnlootedCorpseOnDeath>k__BackingField; //Field offset: 0xB1
	[CompilerGenerated]
	private EPlayerSide <Side>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private PlayerLoyaltyData <Loyalty>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <IsAI>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private string <ProfileId>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private string <VoipID>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private string <NickName>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private string <AccountId>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly Dictionary <MainParts>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private PlayerBones <PlayerBones>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private PlayerBody <PlayerBody>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ICharacterController <CharacterController>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private bool <IsSpectateTarget>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private FirearmsAnimator <FirearmsAnimator>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Action OnIPlayerDeadOrUnspawn; //Field offset: 0x118
	[CompilerGenerated]
	private bool <IsInBufferZone>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private readonly bool <StateIsSuitableForHandInput>k__BackingField; //Field offset: 0x121
	private Transform _playerLookRaycastTransform; //Field offset: 0x128
	private byte _channelIndex; //Field offset: 0x130
	private IAnimator[] _animators; //Field offset: 0x138
	private readonly List _preAllocatedRenderersList; //Field offset: 0x140
	private HitReaction _hitReaction; //Field offset: 0x148
	private FullBodyBipedIK _fbbik; //Field offset: 0x150
	private float _turnOffFbbikAt; //Field offset: 0x158
	private readonly ObservedPlayerBatchTorsoReaction _batchTorsoReaction; //Field offset: 0x160
	private ObservedPlayerBodyReactionFrameInput _torsoReactionFrameInput; //Field offset: 0x168
	private bool _torsoReactionFrameReady; //Field offset: 0x1F8
	private BundleAnimationBones _bundleAnimationBones; //Field offset: 0x200
	private bool _isCapsuleVisible; //Field offset: 0x208
	private bool _isInventoryOpened; //Field offset: 0x209
	private bool _isInventoryOperation; //Field offset: 0x20A
	public PhysicalBase Physical; //Field offset: 0x210
	private bool _lateUpdateSkipped; //Field offset: 0x218
	private bool _lateUpdateNeedsBundlePreStep; //Field offset: 0x219
	private bool _lateUpdateNeedsIkPostStep; //Field offset: 0x21A
	private float _lateUpdateDistance; //Field offset: 0x21C
	private FollowerCullingObject _cullingObject; //Field offset: 0x220
	private List _enteredCullingZones; //Field offset: 0x228

	public override event Action OnIPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private override string AccountId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IAIData AIData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public IAnimator ArmsAnimatorCommon
	{
		 get { } //Length: 42
	}

	public override EUpdateMode ArmsUpdateMode
	{
		 get { } //Length: 3
	}

	public override EUpdateQueue ArmsUpdateQueue
	{
		 get { } //Length: 3
	}

	public private IAnimator BodyAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IAnimator BodyAnimatorCommon
	{
		 get { } //Length: 42
	}

	public BTRSide BtrInteractionSide
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EPlayerBtrState BtrState
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public BundleAnimationBones BundleAnimationBones
	{
		 get { } //Length: 8
	}

	public byte ChannelIndex
	{
		 get { } //Length: 8
	}

	public private override ICharacterController CharacterController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Collider[] Colliders
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public FirearmsAnimator FirearmsAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override string GroupId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Quaternion HandsRotation
	{
		 get { } //Length: 195
	}

	public override IHealthController HealthController
	{
		 get { } //Length: 30
	}

	public HitReaction HitReaction
	{
		 get { } //Length: 8
	}

	public private override int Id
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Ray InteractionRay
	{
		 get { } //Length: 367
	}

	public override InventoryController InventoryController
	{
		 get { } //Length: 27
	}

	public private override bool IsAI
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool IsInBufferZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsInventoryOpened
	{
		 get { } //Length: 8
	}

	public bool IsInventoryOperation
	{
		 get { } //Length: 8
	}

	public private bool IsSpectateTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsTorsoReactionPipelineActive
	{
		 get { } //Length: 11
	}

	public bool IsVisible
	{
		 get { } //Length: 250
	}

	private bool IsVisibleByCullingZones
	{
		private get { } //Length: 389
	}

	public override bool IsVisibleToCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsYourPlayer
	{
		 get { } //Length: 3
	}

	public override Vector3 LookDirection
	{
		 get { } //Length: 71
	}

	public override PlayerLoyaltyData Loyalty
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Dictionary MainParts
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private string NickName
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerController ObservedPlayerController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private PlayerAnimator PlayerAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override PlayerBody PlayerBody
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override PlayerBones PlayerBones
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Vector3 PlayerColliderCenter
	{
		 get { } //Length: 188
	}

	public private override Vector3 Position
	{
		 get { } //Length: 74
		private set { } //Length: 68
	}

	public override Profile Profile
	{
		 get { } //Length: 3
	}

	public private override string ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override int RaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override PlayerRecorderController RecorderController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Vector2 Rotation
	{
		 get { } //Length: 65
	}

	public override IPlayerSearchController SearchController
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public private override EPlayerSide Side
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Transform SpectatorTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool StateIsSuitableForHandInput
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override string TeamId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float TorsoReactionPitchDegrees
	{
		 get { } //Length: 57
	}

	public override BifacialTransform Transform
	{
		 get { } //Length: 33
	}

	public bool UnlootedCorpseOnDeath
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool UsedSimplifiedSkeleton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3 Velocity
	{
		 get { } //Length: 71
	}

	public override ECameraType VisibleToCameraType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private string Voice
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string VoipID
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BifacialTransform WeaponRoot
	{
		 get { } //Length: 33
	}

	public float WorldTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	private static ObservedPlayerView() { }

	public ObservedPlayerView() { }

	[CompilerGenerated]
	private Transform <RegisterCulling>b__260_0() { }

	[CompilerGenerated]
	public override void add_OnIPlayerDeadOrUnspawn(Action value) { }

	public void ApplyDeath() { }

	public void ApplyExternalTorsoHitImpulse(Vector3 worldForce, EBodyPart bodyPart) { }

	public void ApplySpectating(bool spectate) { }

	private void ConfirmTorsoReactionApplied() { }

	public static TObservedPlayerView Create(int playerId, ObservedPlayerSpawnMessage message) { }

	private void CreateAnimator(Animator animator, bool isAI, WildSpawnType wildSpawnType) { }

	public void Dispose() { }

	public void Execute(ICommandMessage command) { }

	public override CultistAmulet FindCultistAmulet() { }

	public override Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public override RadioTransmitterRecodableComponent FindRadioTransmitter() { }

	[CompilerGenerated]
	public override string get_AccountId() { }

	[CompilerGenerated]
	public override IAIData get_AIData() { }

	public IAnimator get_ArmsAnimatorCommon() { }

	public override EUpdateMode get_ArmsUpdateMode() { }

	public override EUpdateQueue get_ArmsUpdateQueue() { }

	[CompilerGenerated]
	public IAnimator get_BodyAnimator() { }

	public IAnimator get_BodyAnimatorCommon() { }

	[CompilerGenerated]
	public BTRSide get_BtrInteractionSide() { }

	[CompilerGenerated]
	public override EPlayerBtrState get_BtrState() { }

	public BundleAnimationBones get_BundleAnimationBones() { }

	public byte get_ChannelIndex() { }

	[CompilerGenerated]
	public override ICharacterController get_CharacterController() { }

	[CompilerGenerated]
	public Collider[] get_Colliders() { }

	[CompilerGenerated]
	public FirearmsAnimator get_FirearmsAnimator() { }

	[CompilerGenerated]
	public override string get_GroupId() { }

	public Quaternion get_HandsRotation() { }

	public override IHealthController get_HealthController() { }

	public HitReaction get_HitReaction() { }

	[CompilerGenerated]
	public override int get_Id() { }

	public Ray get_InteractionRay() { }

	public override InventoryController get_InventoryController() { }

	[CompilerGenerated]
	public override bool get_IsAI() { }

	[CompilerGenerated]
	public override bool get_IsInBufferZone() { }

	public bool get_IsInventoryOpened() { }

	public bool get_IsInventoryOperation() { }

	[CompilerGenerated]
	public bool get_IsSpectateTarget() { }

	public bool get_IsTorsoReactionPipelineActive() { }

	public bool get_IsVisible() { }

	private bool get_IsVisibleByCullingZones() { }

	[CompilerGenerated]
	public override bool get_IsVisibleToCamera() { }

	public override bool get_IsYourPlayer() { }

	public override Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public override PlayerLoyaltyData get_Loyalty() { }

	[CompilerGenerated]
	public override Dictionary get_MainParts() { }

	[CompilerGenerated]
	public string get_NickName() { }

	[CompilerGenerated]
	public ObservedPlayerController get_ObservedPlayerController() { }

	[CompilerGenerated]
	public PlayerAnimator get_PlayerAnimator() { }

	[CompilerGenerated]
	public override PlayerBody get_PlayerBody() { }

	[CompilerGenerated]
	public override PlayerBones get_PlayerBones() { }

	public Vector3 get_PlayerColliderCenter() { }

	public override Vector3 get_Position() { }

	public override Profile get_Profile() { }

	[CompilerGenerated]
	public override string get_ProfileId() { }

	[CompilerGenerated]
	public override int get_RaidId() { }

	[CompilerGenerated]
	public override PlayerRecorderController get_RecorderController() { }

	public override Vector2 get_Rotation() { }

	[CompilerGenerated]
	public override IPlayerSearchController get_SearchController() { }

	[CompilerGenerated]
	public override EPlayerSide get_Side() { }

	[CompilerGenerated]
	public Transform get_SpectatorTransform() { }

	[CompilerGenerated]
	public override bool get_StateIsSuitableForHandInput() { }

	[CompilerGenerated]
	public override string get_TeamId() { }

	public float get_TorsoReactionPitchDegrees() { }

	public override BifacialTransform get_Transform() { }

	[CompilerGenerated]
	public bool get_UnlootedCorpseOnDeath() { }

	[CompilerGenerated]
	public bool get_UsedSimplifiedSkeleton() { }

	public override Vector3 get_Velocity() { }

	[CompilerGenerated]
	public override ECameraType get_VisibleToCameraType() { }

	[CompilerGenerated]
	public string get_Voice() { }

	[CompilerGenerated]
	public string get_VoipID() { }

	public override BifacialTransform get_WeaponRoot() { }

	[CompilerGenerated]
	public float get_WorldTime() { }

	public override IAnimator GetArmsAnimatorCommon() { }

	public IAnimator GetBodyAnimatorCommon() { }

	private Transform GetTorsoReactionBodyTransform() { }

	public override void HandleFlareSuccessEvent(Vector3 position, AmmoTemplate ammoTemplate) { }

	public override bool HasMarkOfUnknown(out MarkOfUnknown markOfUnknown) { }

	private bool IsOutToIdleState() { }

	private bool IsTorsoReactionEligible() { }

	private bool IsTorsoReactionVisible(float distance) { }

	private void LateUpdateMidBatch() { }

	private void LateUpdatePostBatch() { }

	private void LateUpdatePreBatch() { }

	public override void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	private void OnDurabilityChanged(ArmorDurabilityChangedCommandMessage command) { }

	private void OnFullChangeArmor(ArmorFullChangeInfoCommandMessage command) { }

	public void OnMakingShot(IWeapon weapon, Vector3 shotPosition, Vector3 shotDirection) { }

	public override void PlantItemLocalOnly(Item item, string zone) { }

	public override Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	private void PrepareAndRegisterTorsoReaction() { }

	public void ReactionOnShot(DamageInfo shot, EBodyPart bodyPart) { }

	private static void RegisterActiveView(ObservedPlayerView playerView) { }

	private void RegisterCulling() { }

	private void RegisterFullBodyBurst(float distance, int updateInterval) { }

	[CompilerGenerated]
	public override void remove_OnIPlayerDeadOrUnspawn(Action value) { }

	public void ResetGestureInHands() { }

	public static void RunBatchLateUpdate() { }

	[CompilerGenerated]
	private void set_AccountId(string value) { }

	[CompilerGenerated]
	protected void set_AIData(IAIData value) { }

	[CompilerGenerated]
	private void set_BodyAnimator(IAnimator value) { }

	[CompilerGenerated]
	public void set_BtrInteractionSide(BTRSide value) { }

	[CompilerGenerated]
	public override void set_BtrState(EPlayerBtrState value) { }

	[CompilerGenerated]
	private void set_CharacterController(ICharacterController value) { }

	[CompilerGenerated]
	private void set_Colliders(Collider[] value) { }

	[CompilerGenerated]
	public void set_FirearmsAnimator(FirearmsAnimator value) { }

	[CompilerGenerated]
	private void set_GroupId(string value) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	private void set_IsAI(bool value) { }

	[CompilerGenerated]
	public override void set_IsInBufferZone(bool value) { }

	[CompilerGenerated]
	private void set_IsSpectateTarget(bool value) { }

	[CompilerGenerated]
	public void set_IsVisibleToCamera(bool value) { }

	[CompilerGenerated]
	protected void set_Loyalty(PlayerLoyaltyData value) { }

	[CompilerGenerated]
	private void set_NickName(string value) { }

	[CompilerGenerated]
	private void set_ObservedPlayerController(ObservedPlayerController value) { }

	[CompilerGenerated]
	private void set_PlayerAnimator(PlayerAnimator value) { }

	[CompilerGenerated]
	public void set_PlayerBody(PlayerBody value) { }

	[CompilerGenerated]
	private void set_PlayerBones(PlayerBones value) { }

	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	private void set_ProfileId(string value) { }

	[CompilerGenerated]
	private void set_RaidId(int value) { }

	[CompilerGenerated]
	private void set_Side(EPlayerSide value) { }

	[CompilerGenerated]
	private void set_SpectatorTransform(Transform value) { }

	[CompilerGenerated]
	private void set_TeamId(string value) { }

	[CompilerGenerated]
	protected void set_UnlootedCorpseOnDeath(bool value) { }

	[CompilerGenerated]
	protected void set_UsedSimplifiedSkeleton(bool value) { }

	[CompilerGenerated]
	public void set_VisibleToCameraType(ECameraType value) { }

	[CompilerGenerated]
	private void set_Voice(string value) { }

	[CompilerGenerated]
	private void set_VoipID(string value) { }

	[CompilerGenerated]
	public void set_WorldTime(float value) { }

	public override void SetArmsAnimatorCommon(IAnimator animator) { }

	public void SetAutocullVisibility(bool value) { }

	public void SetController(ObservedPlayerController controller) { }

	public override void SetInteractInHands(EInteraction interaction) { }

	private void SetInteraction(InteractionCommandMessage message) { }

	private void SetInventoryInteraction(InventoryInteractionCommandMessage message) { }

	public void SetLefthandInfo(LeftHandCommandMessage message) { }

	private void SetLeftStance(SetLeftStanceCommandMessage setLeftStanceCommandMessage) { }

	public void SetMounting(MountingCommandMessage message) { }

	private void SetOutToIdleEndStateForce() { }

	private void SetStationaryWeapon(SetStationaryWeaponCommandMessage setStationaryWeaponCommandMessage) { }

	private void SetupBodyPartCollider(BodyPartCollider bodyPartCollider, bool includeChild) { }

	private void SetupHitColliders() { }

	private void SetVaulting(VaultingCommandMessage vaultingCommandMessage) { }

	public void SetWeaponRoot(Transform targetTransform) { }

	private void SetZombieAlert(ZombieAlertUpdateCommandMessage command) { }

	private void SetZombieLost() { }

	private void SetZombieTurnDeltaAngle(ZombieSetTurnDeltaAngleMessage command) { }

	private bool ShouldApplyTorsoReactionImpulse() { }

	public bool TryGetTorsoWeaponCounterRootRotation(out Quaternion counterRotation) { }

	private void TryToSetOverrideAnimatorController(bool isAI, WildSpawnType role) { }

	private static void UnregisterActiveView(ObservedPlayerView playerView) { }

	private void UnregisterCulling() { }

	public override void UpdateInteractionCast() { }

	public void UpdateWeaponRoot() { }

}

