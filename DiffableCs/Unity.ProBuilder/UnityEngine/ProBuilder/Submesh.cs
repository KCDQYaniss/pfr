namespace UnityEngine.ProBuilder;

public sealed class Submesh
{
	[SerializeField]
	internal int[] m_Indexes; //Field offset: 0x10
	[SerializeField]
	internal MeshTopology m_Topology; //Field offset: 0x18
	[SerializeField]
	internal int m_SubmeshIndex; //Field offset: 0x1C

	public IEnumerable indexes
	{
		 get { } //Length: 182
		 set { } //Length: 274
	}

	public int submeshIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public MeshTopology topology
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Submesh(int submeshIndex, MeshTopology topology, IEnumerable indexes) { }

	public Submesh(Mesh mesh, int subMeshIndex) { }

	public IEnumerable get_indexes() { }

	public int get_submeshIndex() { }

	public MeshTopology get_topology() { }

	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	public static Submesh[] GetSubmeshes(IEnumerable faces, int submeshCount, MeshTopology preferredTopology = 0) { }

	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }

	public void set_indexes(IEnumerable value) { }

	public void set_submeshIndex(int value) { }

	public void set_topology(MeshTopology value) { }

	public virtual string ToString() { }

}

