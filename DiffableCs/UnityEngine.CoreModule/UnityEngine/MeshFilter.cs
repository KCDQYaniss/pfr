namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
{

	public Mesh mesh
	{
		[NativeName("GetInstantiatedMeshFromScript")]
		 get { } //Length: 78
		[NativeName("SetInstantiatedMesh")]
		 set { } //Length: 93
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

	[NativeName("GetInstantiatedMeshFromScript")]
	public Mesh get_mesh() { }

	public Mesh get_sharedMesh() { }

	[NativeName("SetInstantiatedMesh")]
	public void set_mesh(Mesh value) { }

	public void set_sharedMesh(Mesh value) { }

}

