namespace EFT.Vehicle;

public class PathDestination : PathPartBase
{
	internal sealed class DeselectedPathDestinationEventHandler : MulticastDelegate
	{

		public DeselectedPathDestinationEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathDestination part, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathDestination part) { }

	}

	internal sealed class SelectedPathDestinationEventHandler : MulticastDelegate
	{

		public SelectedPathDestinationEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathDestination part, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathDestination part) { }

	}

	public List connectedPaths; //Field offset: 0x28
	public PathReverseData frontReverseData; //Field offset: 0x30
	public PathReverseData backReverseData; //Field offset: 0x38
	public bool useReverse; //Field offset: 0x40
	public SelectedPathDestinationEventHandler SelectedPathDestinationEvent; //Field offset: 0x48
	public DeselectedPathDestinationEventHandler DeselectedPathDestinationEvent; //Field offset: 0x50

	public PathDestination() { }

	public void ConnectPathSplines() { }

	public void DisconnectPathSplines() { }

	public void FindPaths() { }

}

