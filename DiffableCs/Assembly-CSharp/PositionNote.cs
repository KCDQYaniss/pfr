//Type is in global namespace

public class PositionNote
{
	public Vector3 position; //Field offset: 0x10
	public bool alreadyUsedToSpawn; //Field offset: 0x1C
	public int CorePointId; //Field offset: 0x20

	public PositionNote(Vector3 pos, int corePointId, bool isUsed) { }

}

