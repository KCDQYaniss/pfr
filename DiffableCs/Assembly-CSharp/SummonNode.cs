//Type is in global namespace

public class SummonNode : BaseNode
{
	private float _updatePointTimer; //Field offset: 0x18
	private bool _animationSet; //Field offset: 0x1C

	private BotHalloweenEvent _botHalloween
	{
		private get { } //Length: 48
	}

	public SummonNode(BotOwner bot) { }

	private BotHalloweenEvent get__botHalloween() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

