//Type is in global namespace

public class SpawnPointDebugStruct
{
	public Nullable ProfileDataSide; //Field offset: 0x10
	public ISpawnPoint SpawnPoint; //Field offset: 0x18
	public float Time; //Field offset: 0x20
	public bool IsValid; //Field offset: 0x24

	public SpawnPointDebugStruct(ISpawnPoint sp) { }

	public string DebugInfo() { }

}

