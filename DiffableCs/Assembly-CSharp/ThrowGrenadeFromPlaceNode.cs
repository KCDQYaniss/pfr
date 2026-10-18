//Type is in global namespace

public class ThrowGrenadeFromPlaceNode : BaseNode
{
	private float _nextUpdTimer; //Field offset: 0x18
	private Vector3 targetPoint; //Field offset: 0x1C
	private bool lastFrameCanShootTotrg; //Field offset: 0x28
	private bool _throwStarted; //Field offset: 0x29

	private ThrowGrenadePlaceRequest Request
	{
		private get { } //Length: 145
	}

	public ThrowGrenadeFromPlaceNode(BotOwner bot) { }

	protected DoorInteractionStatus DoorOpen() { }

	private ThrowGrenadePlaceRequest get_Request() { }

	private void InPoint() { }

	private void RestartFind() { }

	private void SearchAround() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

