namespace UnityEngine;

[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup : IDisposable
{
	internal sealed class StateChanged : MulticastDelegate
	{

		public StateChanged(object object, IntPtr method) { }

		public override void Invoke(CullingGroupEvent sphere) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	private StateChanged m_OnStateChanged; //Field offset: 0x18

	public bool enabled
	{
		 set { } //Length: 93
	}

	public Camera targetCamera
	{
		 set { } //Length: 93
	}

	public CullingGroup() { }

	public override void Dispose() { }

	[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = True)]
	private void DisposeInternal() { }

	protected virtual void Finalize() { }

	[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = True, IsThreadSafe = True)]
	private void FinalizerFailure() { }

	[FreeFunction("CullingGroup_Bindings::GetDistance", HasExplicitThis = True)]
	[NativeThrows]
	public int GetDistance(int index) { }

	[FreeFunction("CullingGroup_Bindings::Init")]
	private static IntPtr Init(object scripting) { }

	[FreeFunction("CullingGroup_Bindings::IsVisible", HasExplicitThis = True)]
	[NativeThrows]
	public bool IsVisible(int index) { }

	[RequiredByNativeCode]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	public void set_enabled(bool value) { }

	public void set_targetCamera(Camera value) { }

	public void SetBoundingSphereCount(int count) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

}

