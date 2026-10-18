namespace EFT;

public class PlayerHitInfo
{
	public bool Penetrated; //Field offset: 0x10
	public Nullable HitArmorID; //Field offset: 0x18
	public EPointOfView PoV; //Field offset: 0x38
	public MaterialType Material; //Field offset: 0x3C
	public bool Silent; //Field offset: 0x40

	public PlayerHitInfo() { }

}

