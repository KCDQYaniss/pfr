namespace UnityEngine;

[NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
[NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
[NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
[StaticAccessor("GetLODGroupManager()", StaticAccessorType::Dot (0))]
public class LODGroup : Component
{

	public bool animateCrossFading
	{
		 set { } //Length: 93
	}

	public bool enabled
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public LODFadeMode fadeMode
	{
		 set { } //Length: 91
	}

	public Vector3 localReferencePoint
	{
		 get { } //Length: 104
	}

	public float size
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool get_enabled() { }

	public Vector3 get_localReferencePoint() { }

	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	public float get_size() { }

	[FreeFunction("GetLODs_Binding", HasExplicitThis = True)]
	public LOD[] GetLODs() { }

	[FreeFunction("UpdateLODGroupBoundingBox", HasExplicitThis = True)]
	public void RecalculateBounds() { }

	public void set_animateCrossFading(bool value) { }

	public void set_enabled(bool value) { }

	public void set_fadeMode(LODFadeMode value) { }

	public void set_size(float value) { }

	[FreeFunction("SetLODs_Binding", HasExplicitThis = True)]
	public void SetLODs(LOD[] lods) { }

}

