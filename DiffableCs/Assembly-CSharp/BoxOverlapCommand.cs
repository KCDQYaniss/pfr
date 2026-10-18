//Type is in global namespace

public struct BoxOverlapCommand
{
	public int Mask; //Field offset: 0x0
	public QueryTriggerInteraction QueryTriggerInteraction; //Field offset: 0x4
	public Vector3 Center; //Field offset: 0x8
	public Vector3 Size; //Field offset: 0x14
	public Quaternion Orientation; //Field offset: 0x20

	public BoxOverlapCommand(int mask, QueryTriggerInteraction queryTriggerInteraction, Vector3 center, Vector3 size, Quaternion orientation) { }

}

