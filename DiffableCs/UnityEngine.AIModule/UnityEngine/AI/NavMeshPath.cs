namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
public sealed class NavMeshPath
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal Vector3[] m_Corners; //Field offset: 0x18

	public Vector3[] corners
	{
		 get { } //Length: 161
	}

	public NavMeshPathStatus status
	{
		 get { } //Length: 78
	}

	public NavMeshPath() { }

	private void CalculateCorners() { }

	[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = True)]
	private Vector3[] CalculateCornersInternal() { }

	public void ClearCorners() { }

	[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = True)]
	private void ClearCornersInternal() { }

	[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = True)]
	private static void DestroyNavMeshPath(IntPtr ptr) { }

	protected virtual void Finalize() { }

	public Vector3[] get_corners() { }

	public NavMeshPathStatus get_status() { }

	[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
	private static IntPtr InitializeNavMeshPath() { }

}

