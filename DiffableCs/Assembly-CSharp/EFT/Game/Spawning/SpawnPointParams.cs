namespace EFT.Game.Spawning;

[Obfuscation(Exclude = True)]
public struct SpawnPointParams
{
	public string Id; //Field offset: 0x0
	public ClassVector3 Position; //Field offset: 0x8
	public float Rotation; //Field offset: 0x10
	public EPlayerSideMask Sides; //Field offset: 0x14
	public ESpawnCategoryMask Categories; //Field offset: 0x18
	public string Infiltration; //Field offset: 0x20
	public string BotZoneName; //Field offset: 0x28
	public float DelayToCanSpawnSec; //Field offset: 0x30
	public ISpawnColliderParams ColliderParams; //Field offset: 0x38
	public int CorePointId; //Field offset: 0x40

}

