namespace EFT;

public interface IPlayer
{

	public event Action OnIPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string AccountId
	{
		 get { } //Length: 0
	}

	public IAIData AIData
	{
		 get { } //Length: 0
	}

	public EUpdateMode ArmsUpdateMode
	{
		 get { } //Length: 0
	}

	public EUpdateQueue ArmsUpdateQueue
	{
		 get { } //Length: 0
	}

	public EPlayerBtrState BtrState
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ICharacterController CharacterController
	{
		 get { } //Length: 0
	}

	public string GroupId
	{
		 get { } //Length: 0
	}

	public IHealthController HealthController
	{
		 get { } //Length: 0
	}

	public int Id
	{
		 get { } //Length: 0
	}

	public InventoryController InventoryController
	{
		 get { } //Length: 0
	}

	public bool IsAI
	{
		 get { } //Length: 0
	}

	public bool IsInBufferZone
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsVisibleToCamera
	{
		 get { } //Length: 0
	}

	public bool IsYourPlayer
	{
		 get { } //Length: 0
	}

	public Vector3 LookDirection
	{
		 get { } //Length: 0
	}

	public PlayerLoyaltyData Loyalty
	{
		 get { } //Length: 0
	}

	public Dictionary MainParts
	{
		 get { } //Length: 0
	}

	public PlayerBody PlayerBody
	{
		 get { } //Length: 0
	}

	public PlayerBones PlayerBones
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Profile Profile
	{
		 get { } //Length: 0
	}

	public string ProfileId
	{
		 get { } //Length: 0
	}

	public int RaidId
	{
		 get { } //Length: 0
	}

	public PlayerRecorderController RecorderController
	{
		 get { } //Length: 0
	}

	public Vector2 Rotation
	{
		 get { } //Length: 0
	}

	public IPlayerSearchController SearchController
	{
		 get { } //Length: 0
	}

	public EPlayerSide Side
	{
		 get { } //Length: 0
	}

	public bool StateIsSuitableForHandInput
	{
		 get { } //Length: 0
	}

	public string TeamId
	{
		 get { } //Length: 0
	}

	public BifacialTransform Transform
	{
		 get { } //Length: 0
	}

	public Vector3 Velocity
	{
		 get { } //Length: 0
	}

	public ECameraType VisibleToCameraType
	{
		 get { } //Length: 0
	}

	public BifacialTransform WeaponRoot
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnIPlayerDeadOrUnspawn(Action value) { }

	public CultistAmulet FindCultistAmulet() { }

	public Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public RadioTransmitterRecodableComponent FindRadioTransmitter() { }

	public string get_AccountId() { }

	public IAIData get_AIData() { }

	public EUpdateMode get_ArmsUpdateMode() { }

	public EUpdateQueue get_ArmsUpdateQueue() { }

	public EPlayerBtrState get_BtrState() { }

	public ICharacterController get_CharacterController() { }

	public string get_GroupId() { }

	public IHealthController get_HealthController() { }

	public int get_Id() { }

	public InventoryController get_InventoryController() { }

	public bool get_IsAI() { }

	public bool get_IsInBufferZone() { }

	public bool get_IsVisibleToCamera() { }

	public bool get_IsYourPlayer() { }

	public Vector3 get_LookDirection() { }

	public PlayerLoyaltyData get_Loyalty() { }

	public Dictionary get_MainParts() { }

	public PlayerBody get_PlayerBody() { }

	public PlayerBones get_PlayerBones() { }

	public Vector3 get_Position() { }

	public Profile get_Profile() { }

	public string get_ProfileId() { }

	public int get_RaidId() { }

	public PlayerRecorderController get_RecorderController() { }

	public Vector2 get_Rotation() { }

	public IPlayerSearchController get_SearchController() { }

	public EPlayerSide get_Side() { }

	public bool get_StateIsSuitableForHandInput() { }

	public string get_TeamId() { }

	public BifacialTransform get_Transform() { }

	public Vector3 get_Velocity() { }

	public ECameraType get_VisibleToCameraType() { }

	public BifacialTransform get_WeaponRoot() { }

	public IAnimator GetArmsAnimatorCommon() { }

	public void HandleFlareSuccessEvent(Vector3 position, AmmoTemplate ammoTemplate) { }

	public bool HasMarkOfUnknown(out MarkOfUnknown markOfUnknown) { }

	public void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	public void PlantItemLocalOnly(Item item, string zone) { }

	public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	[CompilerGenerated]
	public void remove_OnIPlayerDeadOrUnspawn(Action value) { }

	public void set_BtrState(EPlayerBtrState value) { }

	public void set_IsInBufferZone(bool value) { }

	public void SetArmsAnimatorCommon(IAnimator animator) { }

	public void SetInteractInHands(EInteraction interaction) { }

	public void UpdateInteractionCast() { }

}

