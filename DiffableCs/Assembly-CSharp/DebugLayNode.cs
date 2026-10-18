//Type is in global namespace

public class DebugLayNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18
	private AIPeriodAction _changeShoot; //Field offset: 0x20
	private bool _doShoot; //Field offset: 0x28
	private readonly Aiming _aiming; //Field offset: 0x30

	public DebugLayNode(BotOwner bot) { }

	private void OnChnage() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

