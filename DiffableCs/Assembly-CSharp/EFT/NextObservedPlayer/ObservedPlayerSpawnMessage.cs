namespace EFT.NextObservedPlayer;

public struct ObservedPlayerSpawnMessage
{
	public byte[] ResourcesForLoad; //Field offset: 0x0
	public byte[] CustomizationForLoad; //Field offset: 0x8
	public float RemoteTime; //Field offset: 0x10
	public Vector3 BodyPosition; //Field offset: 0x14
	public Dictionary Customization; //Field offset: 0x20
	public EPlayerSide Side; //Field offset: 0x28
	public WildSpawnType WildSpawnType; //Field offset: 0x2C
	public string GroupID; //Field offset: 0x30
	public string TeamID; //Field offset: 0x38
	public bool IsAI; //Field offset: 0x40
	public int RaidId; //Field offset: 0x44
	public string ProfileID; //Field offset: 0x48
	public EVoipState VoIPState; //Field offset: 0x50
	public string NickName; //Field offset: 0x58
	public string AccountId; //Field offset: 0x60
	public EArmorPlateCollider ArmorPlateColliderMask; //Field offset: 0x68
	public bool UseSimplifiedSkeleton; //Field offset: 0x6A
	public Inventory Inventory; //Field offset: 0x70
	public SetHandsCommandMessage HandsController; //Field offset: 0x78
	public MountingCommandMessage MountingMessage; //Field offset: 0x80
	public SkillsParamsCommandMessage SkillsParamsMessage; //Field offset: 0x88
	public PerksParamsCommandMessage PerksParamsMessage; //Field offset: 0x90
	public List ArmorsInfo; //Field offset: 0x98
	public ArenaObservedPlayerSpawnMessage ArenaObservedPlayerSpawnMessage; //Field offset: 0xA0

	public void Deserialize(NetworkReader reader) { }

	public void DeserializeArmorsInfo(NetworkReader reader) { }

	public void DeserializeCustomization(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

	public void SerializeArmorsInfo(NetworkWriter writer) { }

	public void SerializeCustomization(NetworkWriter writer) { }

}

