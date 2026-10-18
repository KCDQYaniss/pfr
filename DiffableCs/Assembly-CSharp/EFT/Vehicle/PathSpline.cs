namespace EFT.Vehicle;

public class PathSpline : PathPartBase
{
	internal sealed class SelectedSplineEvent : MulticastDelegate
	{

		public SelectedSplineEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathSpline pathSpline, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathSpline pathSpline) { }

	}

	public SelectedSplineEvent SplineSelectedEvent; //Field offset: 0x28
	public BezierSpline spline; //Field offset: 0x30
	private Vector3 _disconnectFirstCachedPoint; //Field offset: 0x38
	private Vector3 _disconnectLastCachedPoint; //Field offset: 0x44

	public PathSpline() { }

	public void Connect(Vector3 destinationPos) { }

	public void Connect2(Vector3 destinationPos) { }

	public void Disconnect() { }

}

