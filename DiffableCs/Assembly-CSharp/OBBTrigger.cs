//Type is in global namespace

public class OBBTrigger
{
	public readonly int Id; //Field offset: 0x10
	public readonly int Layer; //Field offset: 0x14
	public readonly bool IsTrigger; //Field offset: 0x18
	public readonly OBB Obb; //Field offset: 0x1C

	public OBBTrigger(int id, int layer, bool isTrigger, Vector3 center, Vector3 size, Quaternion orientation) { }

}

