namespace EFT.Interactive;

public sealed class WorldInteractiveObjectInteract : MulticastDelegate
{

	public WorldInteractiveObjectInteract(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

}

