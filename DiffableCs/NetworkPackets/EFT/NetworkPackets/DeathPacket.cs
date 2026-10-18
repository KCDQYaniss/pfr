namespace EFT.NetworkPackets;

public struct DeathPacket
{
	public static readonly DeathPacket ALIVE_PACKET; //Field offset: 0x0
	public const string KILLED_STATUS = "Killed by"; //Field offset: 0x0
	public const string DIED_STATUS = "Died"; //Field offset: 0x0
	public bool IsAlive; //Field offset: 0x0
	public int InventoryHashSum; //Field offset: 0x4
	public double Time; //Field offset: 0x8
	public string AccountId; //Field offset: 0x10
	public string ProfileId; //Field offset: 0x18
	public string Nickname; //Field offset: 0x20
	public int Side; //Field offset: 0x28
	public string Status; //Field offset: 0x30
	public string KillerAccountId; //Field offset: 0x38
	public string KillerProfileId; //Field offset: 0x40
	public string KillerName; //Field offset: 0x48
	public int Level; //Field offset: 0x50
	public string WeaponName; //Field offset: 0x58
	public CorpseImpulse CorpseImpulse; //Field offset: 0x60
	public int Role; //Field offset: 0x8C

	private static DeathPacket() { }

	public DeathPacket(int inventoryHashSum, double time, string accountId, string profileId, string nickname, int side, string status, string killerAccountId, string killerProfileId, string killerName, int level, string weaponName, int role) { }

	public virtual string ToString() { }

}

