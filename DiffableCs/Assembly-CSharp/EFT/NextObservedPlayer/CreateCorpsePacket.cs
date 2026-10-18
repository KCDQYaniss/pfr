namespace EFT.NextObservedPlayer;

public sealed class CreateCorpsePacket
{
	public int PlayeRaidId; //Field offset: 0x10
	public CorpseImpulse CorpseImpulse; //Field offset: 0x14
	public EBodyPart LastDamagedBodyPart; //Field offset: 0x40
	public EDamageType LastDamageType; //Field offset: 0x44
	public ItemDescriptor Equipment; //Field offset: 0x48

	public CreateCorpsePacket() { }

	public static CreateCorpsePacket Deserialize(byte[] data) { }

	public byte[] Serialize() { }

}

