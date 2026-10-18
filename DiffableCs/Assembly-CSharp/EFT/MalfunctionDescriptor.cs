namespace EFT;

[GenerateBinarySerialization]
public sealed class MalfunctionDescriptor
{
	public byte Malfunction; //Field offset: 0x10
	public float LastShotOverheat; //Field offset: 0x14
	public float LastShotTime; //Field offset: 0x18
	public bool SlideOnOverheatReached; //Field offset: 0x1C
	public List PlayersWhoKnowAboutMalfunction; //Field offset: 0x20
	public List PlayersWhoKnowMalfType; //Field offset: 0x28
	public Dictionary PlayersReducedMalfChances; //Field offset: 0x30
	public Nullable AmmoToFireTemplateId; //Field offset: 0x38
	public Nullable AmmoWillBeLoadedToChamberTemplateId; //Field offset: 0x58
	public Nullable AmmoMalfunctionedTemplateId; //Field offset: 0x78

	public MalfunctionDescriptor() { }

}

