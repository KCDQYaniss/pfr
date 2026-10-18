namespace UnityEngine.AI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshAgent.html")]
[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
public sealed class NavMeshAgent : Behaviour
{

	public Vector3 destination
	{
		 get { } //Length: 104
	}

	public Vector3 get_destination() { }

	private void get_destination_Injected(out Vector3 ret) { }

}

