//Type is in global namespace

public struct OBB
{
	public readonly Vector3 Center; //Field offset: 0x0
	public readonly Vector3 Right; //Field offset: 0xC
	public readonly Vector3 Up; //Field offset: 0x18
	public readonly Vector3 Forward; //Field offset: 0x24
	public readonly float SizeDistance; //Field offset: 0x30
	private readonly Vector3 _vertices0; //Field offset: 0x34
	private readonly Vector3 _vertices1; //Field offset: 0x40
	private readonly Vector3 _vertices2; //Field offset: 0x4C
	private readonly Vector3 _vertices3; //Field offset: 0x58
	private readonly Vector3 _vertices4; //Field offset: 0x64
	private readonly Vector3 _vertices5; //Field offset: 0x70
	private readonly Vector3 _vertices6; //Field offset: 0x7C
	private readonly Vector3 _vertices7; //Field offset: 0x88

	public OBB(Vector3 center, Vector3 size, Quaternion orientation) { }

	public Vector3 GetVertex(int i) { }

}

