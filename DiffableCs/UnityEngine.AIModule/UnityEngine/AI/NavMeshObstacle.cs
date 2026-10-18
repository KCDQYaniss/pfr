namespace UnityEngine.AI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshObstacle.html")]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
public sealed class NavMeshObstacle : Behaviour
{

	public bool carving
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Vector3 size
	{
		[FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = True)]
		 set { } //Length: 93
	}

	public bool get_carving() { }

	public void set_carving(bool value) { }

	[FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = True)]
	public void set_size(Vector3 value) { }

	private void set_size_Injected(ref Vector3 value) { }

}

