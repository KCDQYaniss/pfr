namespace UnityEngine;

[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[RequiredByNativeCode]
public class MeshCollider : Collider
{

	public bool convex
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool get_convex() { }

	public Mesh get_sharedMesh() { }

	public void set_convex(bool value) { }

	public void set_sharedMesh(Mesh value) { }

}

