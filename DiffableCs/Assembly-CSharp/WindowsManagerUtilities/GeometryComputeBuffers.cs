namespace WindowsManagerUtilities;

internal class GeometryComputeBuffers
{
	internal struct IntPair
	{
		public int first; //Field offset: 0x0
		public int second; //Field offset: 0x4

	}

	public ComputeBuffer _texturesOffsetsBuffer; //Field offset: 0x10
	public ComputeBuffer _allVerticesBuffer; //Field offset: 0x18
	public ComputeBuffer _verticesIDsForeground; //Field offset: 0x20
	public ComputeBuffer _verticesIDsBackground; //Field offset: 0x28
	public ComputeBuffer _allTransformsBuffer; //Field offset: 0x30
	public ComputeBuffer _allBoundsBuffer; //Field offset: 0x38
	public ComputeBuffer _allTrianglesBuffer; //Field offset: 0x40
	public ComputeBuffer _argsBuffer; //Field offset: 0x48
	public ComputeBuffer _verticesInstances; //Field offset: 0x50
	public ComputeBuffer _verticesLocalOffsets; //Field offset: 0x58
	public ComputeBuffer _instancesMeshesIndices; //Field offset: 0x60
	public ComputeBuffer _instanceIdToStartVertexId; //Field offset: 0x68
	public ComputeBuffer _meshesOffsets; //Field offset: 0x70
	public ComputeBuffer _meshesVerticesCounts; //Field offset: 0x78
	public ComputeBuffer _lightsProperties; //Field offset: 0x80
	public ComputeBuffer _materialsProperties; //Field offset: 0x88
	public ComputeBuffer _instancesEnable; //Field offset: 0x90

	public GeometryComputeBuffers() { }

	public void Release() { }

	private void ReleaseComputeBuffer(ref ComputeBuffer buf) { }

}

