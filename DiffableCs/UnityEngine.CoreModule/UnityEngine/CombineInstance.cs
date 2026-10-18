namespace UnityEngine;

public struct CombineInstance
{
	private int m_MeshInstanceID; //Field offset: 0x0
	private int m_SubMeshIndex; //Field offset: 0x4
	private Matrix4x4 m_Transform; //Field offset: 0x8
	private Vector4 m_LightmapScaleOffset; //Field offset: 0x48
	private Vector4 m_RealtimeLightmapScaleOffset; //Field offset: 0x58

	public Mesh mesh
	{
		 set { } //Length: 230
	}

	public int subMeshIndex
	{
		 set { } //Length: 4
	}

	public Matrix4x4 transform
	{
		 set { } //Length: 32
	}

	public void set_mesh(Mesh value) { }

	public void set_subMeshIndex(int value) { }

	public void set_transform(Matrix4x4 value) { }

}

