//Type is in global namespace

public class TakeInPlaceForChecking : BaseNode
{
	private BifacialTransform _ownerRoot; //Field offset: 0x18
	private readonly Vector3 _up; //Field offset: 0x20
	private bool _goingToPlace; //Field offset: 0x2C

	public TakeInPlaceForChecking(BotOwner bot) { }

	public virtual void Awake() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

