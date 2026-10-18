namespace EFT;

public struct HandsChangePacket
{
	internal enum EOperationType
	{
		None = 0,
		Drop = 1,
		FastDrop = 2,
		CreateEmptyHands = 3,
		CreateFirearm = 4,
		CreateGrenade = 5,
		CreateMeds = 6,
		CreateKnife = 7,
		CreateQuickGrenadeThrow = 8,
		CreateQuickKnifeKick = 9,
		CreateQuickUseItem = 10,
		CreateUsableItem = 11,
		CreateRecorderItem = 12,
		DropAndCreateEmptyHands = 13,
		DropAndCreateFirearm = 14,
		DropAndCreateGrenade = 15,
		DropAndCreateMeds = 16,
		DropAndCreateKnife = 17,
		DropAndCreateQuickGrenadeThrow = 18,
		DropAndCreateQuickKnifeKick = 19,
		DropAndCreateQuickUseItem = 20,
		DropAndCreateUsableItem = 21,
	}

	private const int MAX_CALLBACK_ID = 2047; //Field offset: 0x0
	public EOperationType OperationType; //Field offset: 0x0
	public uint CallbackId; //Field offset: 0x4
	public string ItemId; //Field offset: 0x8
	public OneAndList MedsBodyParts; //Field offset: 0x10
	public float MedsAmount; //Field offset: 0x20
	public int AnimationVariant; //Field offset: 0x24

	public bool Equals(HandsChangePacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static void Serialize(IBitStream stream, ref HandsChangePacket handsChangePacket, HandsChangePacket prevFrame) { }

}

