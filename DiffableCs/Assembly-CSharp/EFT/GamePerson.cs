namespace EFT;

public sealed class GamePerson : MonoBehaviour, IPlayer
{
	[SerializeField]
	private int _raidId; //Field offset: 0x20
	[SerializeField]
	private int _id; //Field offset: 0x24
	[SerializeField]
	private string _profileId; //Field offset: 0x28
	[SerializeField]
	private ESpawnCategory _category; //Field offset: 0x30
	[SerializeField]
	private EPlayerSide _side; //Field offset: 0x34
	[SerializeField]
	private string _groupId; //Field offset: 0x38
	[SerializeField]
	private string _teamId; //Field offset: 0x40
	[SerializeField]
	private string _infiltration; //Field offset: 0x48
	[SerializeField]
	private string _botZoneName; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnIPlayerDeadOrUnspawn; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsInBufferZone>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private EPlayerBtrState <BtrState>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private readonly Vector2 <Rotation>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly Vector3 <Velocity>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly byte <ChannelIndex>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private readonly ECameraType <VisibleToCameraType>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly bool <IsVisibleToCamera>k__BackingField; //Field offset: 0x84

	public override event Action OnIPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override string AccountId
	{
		 get { } //Length: 3
	}

	public override IAIData AIData
	{
		 get { } //Length: 3
	}

	public override EUpdateMode ArmsUpdateMode
	{
		 get { } //Length: 6
	}

	public override EUpdateQueue ArmsUpdateQueue
	{
		 get { } //Length: 6
	}

	public override EPlayerBtrState BtrState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ESpawnCategory Category
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public byte ChannelIndex
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override ICharacterController CharacterController
	{
		 get { } //Length: 3
	}

	public Player GetPlayer
	{
		 get { } //Length: 3
	}

	public override string GroupId
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override IHealthController HealthController
	{
		 get { } //Length: 3
	}

	public override int Id
	{
		 get { } //Length: 4
	}

	public string Infiltration
	{
		 get { } //Length: 5
	}

	public override InventoryController InventoryController
	{
		 get { } //Length: 3
	}

	public override bool IsAI
	{
		 get { } //Length: 8
	}

	public override bool IsInBufferZone
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsVisibleToCamera
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override bool IsYourPlayer
	{
		 get { } //Length: 3
	}

	public override Vector3 LookDirection
	{
		 get { } //Length: 1025
	}

	public override PlayerLoyaltyData Loyalty
	{
		 get { } //Length: 3
	}

	public override Dictionary MainParts
	{
		 get { } //Length: 3
	}

	public override PlayerBody PlayerBody
	{
		 get { } //Length: 3
	}

	public override PlayerBones PlayerBones
	{
		 get { } //Length: 3
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public override Profile Profile
	{
		 get { } //Length: 3
	}

	public override string ProfileId
	{
		 get { } //Length: 5
	}

	public override int RaidId
	{
		 get { } //Length: 4
	}

	public override PlayerRecorderController RecorderController
	{
		 get { } //Length: 3
	}

	public override Vector2 Rotation
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public override IPlayerSearchController SearchController
	{
		 get { } //Length: 3
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public override bool StateIsSuitableForHandInput
	{
		 get { } //Length: 3
	}

	public override string TeamId
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override BifacialTransform Transform
	{
		 get { } //Length: 3
	}

	public override Vector3 Velocity
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public override ECameraType VisibleToCameraType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public override BifacialTransform WeaponRoot
	{
		 get { } //Length: 3
	}

	public GamePerson() { }

	[CompilerGenerated]
	public override void add_OnIPlayerDeadOrUnspawn(Action value) { }

	public static GamePerson Create(Vector3 position, Quaternion rotation, int id, string profileId, ESpawnCategory category, EPlayerSide side, string name = null, string groupId = null, string infiltration = null, string botZoneName = null) { }

	public static GamePerson Create(GamePersonArgs args) { }

	public void Dispose() { }

	public override CultistAmulet FindCultistAmulet() { }

	public override Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public override RadioTransmitterRecodableComponent FindRadioTransmitter() { }

	public override string get_AccountId() { }

	public override IAIData get_AIData() { }

	public override EUpdateMode get_ArmsUpdateMode() { }

	public override EUpdateQueue get_ArmsUpdateQueue() { }

	[CompilerGenerated]
	public override EPlayerBtrState get_BtrState() { }

	public ESpawnCategory get_Category() { }

	[CompilerGenerated]
	public byte get_ChannelIndex() { }

	public override ICharacterController get_CharacterController() { }

	public Player get_GetPlayer() { }

	public override string get_GroupId() { }

	public override IHealthController get_HealthController() { }

	public override int get_Id() { }

	public string get_Infiltration() { }

	public override InventoryController get_InventoryController() { }

	public override bool get_IsAI() { }

	[CompilerGenerated]
	public override bool get_IsInBufferZone() { }

	[CompilerGenerated]
	public override bool get_IsVisibleToCamera() { }

	public override bool get_IsYourPlayer() { }

	public override Vector3 get_LookDirection() { }

	public override PlayerLoyaltyData get_Loyalty() { }

	public override Dictionary get_MainParts() { }

	public override PlayerBody get_PlayerBody() { }

	public override PlayerBones get_PlayerBones() { }

	public override Vector3 get_Position() { }

	public override Profile get_Profile() { }

	public override string get_ProfileId() { }

	public override int get_RaidId() { }

	public override PlayerRecorderController get_RecorderController() { }

	[CompilerGenerated]
	public override Vector2 get_Rotation() { }

	public override IPlayerSearchController get_SearchController() { }

	public override EPlayerSide get_Side() { }

	public override bool get_StateIsSuitableForHandInput() { }

	public override string get_TeamId() { }

	public override BifacialTransform get_Transform() { }

	[CompilerGenerated]
	public override Vector3 get_Velocity() { }

	[CompilerGenerated]
	public override ECameraType get_VisibleToCameraType() { }

	public override BifacialTransform get_WeaponRoot() { }

	public override IAnimator GetArmsAnimatorCommon() { }

	public override void HandleFlareSuccessEvent(Vector3 position, AmmoTemplate ammoTemplate) { }

	public override bool HasMarkOfUnknown(out MarkOfUnknown markOfUnknown) { }

	public override void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	public void OnDrawGizmos() { }

	public override void PlantItemLocalOnly(Item item, string zone) { }

	public override Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	[CompilerGenerated]
	public override void remove_OnIPlayerDeadOrUnspawn(Action value) { }

	[CompilerGenerated]
	public override void set_BtrState(EPlayerBtrState value) { }

	public void set_Category(ESpawnCategory value) { }

	public void set_GroupId(string value) { }

	[CompilerGenerated]
	public override void set_IsInBufferZone(bool value) { }

	public void set_Side(EPlayerSide value) { }

	public void set_TeamId(string value) { }

	public override void SetArmsAnimatorCommon(IAnimator animator) { }

	public override void SetInteractInHands(EInteraction interaction) { }

	public override void UpdateInteractionCast() { }

}

