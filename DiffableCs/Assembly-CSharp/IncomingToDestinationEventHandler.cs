//Type is in global namespace

public sealed class IncomingToDestinationEventHandler : MulticastDelegate
{

	public IncomingToDestinationEventHandler(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(PathDestination destinationPoint, bool isFirst, bool isFinal, bool isLastRotePoint, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(PathDestination destinationPoint, bool isFirst, bool isFinal, bool isLastRotePoint) { }

}

