namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer
{

	public Transform[] bones
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public SkinQuality quality
	{
		 get { } //Length: 78
	}

	public Transform rootBone
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("Mesh")]
	public Mesh sharedMesh
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public void BakeMesh(Mesh mesh) { }

	public void BakeMesh(Mesh mesh, bool useScale) { }

	public Transform[] get_bones() { }

	public SkinQuality get_quality() { }

	public Transform get_rootBone() { }

	public Mesh get_sharedMesh() { }

	public float GetBlendShapeWeight(int index) { }

	public void set_bones(Transform[] value) { }

	public void set_rootBone(Transform value) { }

	public void set_sharedMesh(Mesh value) { }

	public void SetBlendShapeWeight(int index, float value) { }

}

