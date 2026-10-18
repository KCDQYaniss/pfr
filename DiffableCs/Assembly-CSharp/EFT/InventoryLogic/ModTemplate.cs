namespace EFT.InventoryLogic;

public class ModTemplate : CompoundItemTemplate
{
	public int EffectiveDistance; //Field offset: 0x170
	public int Loudness; //Field offset: 0x174
	public int Accuracy; //Field offset: 0x178
	public float DoubleActionAccuracyPenaltyMult; //Field offset: 0x17C
	public float Recoil; //Field offset: 0x180
	public float Ergonomics; //Field offset: 0x184
	public float Velocity; //Field offset: 0x188
	public bool RaidModdable; //Field offset: 0x18C
	public bool ToolModdable; //Field offset: 0x18D
	public bool BlocksFolding; //Field offset: 0x18E
	public bool IsAnimated; //Field offset: 0x18F
	public float SightingRange; //Field offset: 0x190
	public int UniqueAnimationModID; //Field offset: 0x194
	public int CategoryAnimationModId; //Field offset: 0x198
	public bool HasShoulderContact; //Field offset: 0x19C

	public ModTemplate() { }

}

