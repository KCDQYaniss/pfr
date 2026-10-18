namespace EFT;

public sealed class DogTagComponentDescriptor : ItemComponentDescriptor
{
	public uint AccountId; //Field offset: 0x10
	public MongoID ProfileId; //Field offset: 0x18
	public string Nickname; //Field offset: 0x30
	public EPlayerSide Side; //Field offset: 0x38
	public byte Level; //Field offset: 0x3C
	public double Time; //Field offset: 0x40
	public EDogtagStatus Status; //Field offset: 0x48
	public Nullable KillerAccountId; //Field offset: 0x4C
	public Nullable KillerProfileId; //Field offset: 0x58
	public string KillerName; //Field offset: 0x78
	public string WeaponName; //Field offset: 0x80
	public bool CarriedByGroupMember; //Field offset: 0x88

	public DogTagComponentDescriptor() { }

}

