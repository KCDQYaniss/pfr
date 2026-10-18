namespace EFT.NetworkPackets;

public struct DetailedHitInfo
{
	public EDamageType DamageType; //Field offset: 0x0
	public int Damage; //Field offset: 0x4
	public int Absorbed; //Field offset: 0x8
	public EBodyPart Part; //Field offset: 0xC
	public EHitSpecial Special; //Field offset: 0x10
	public int StaminaLoss; //Field offset: 0x14

}

