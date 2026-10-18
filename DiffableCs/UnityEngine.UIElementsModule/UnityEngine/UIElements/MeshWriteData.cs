namespace UnityEngine.UIElements;

public class MeshWriteData
{
	internal NativeSlice m_Vertices; //Field offset: 0x10
	internal NativeSlice m_Indices; //Field offset: 0x20
	internal Rect m_UVRegion; //Field offset: 0x30
	internal int currentIndex; //Field offset: 0x40
	internal int currentVertex; //Field offset: 0x44

	public int indexCount
	{
		 get { } //Length: 60
	}

	public Rect uvRegion
	{
		 get { } //Length: 11
	}

	public int vertexCount
	{
		 get { } //Length: 60
	}

	internal MeshWriteData() { }

	public int get_indexCount() { }

	public Rect get_uvRegion() { }

	public int get_vertexCount() { }

	internal void Reset(NativeSlice vertices, NativeSlice indices) { }

	internal void Reset(NativeSlice vertices, NativeSlice indices, Rect uvRegion) { }

	public void SetAllIndices(ushort[] indices) { }

	public void SetAllVertices(Vertex[] vertices) { }

	public void SetNextIndex(ushort index) { }

	public void SetNextVertex(Vertex vertex) { }

}

