namespace WindowsManagerUtilities;

[CreateAssetMenu(menuName = "Windows Manager/Geometry Buffers")]
internal class GeometryBuffers : ScriptableObject
{
	internal struct UInt2
	{
		public uint u0; //Field offset: 0x0
		public uint u1; //Field offset: 0x4

		public UInt2(uint arg0, uint arg1) { }

	}

	public List _allVertices; //Field offset: 0x18
	public List _allTriangles; //Field offset: 0x20

	public GeometryBuffers() { }

	public void Clear() { }

}

