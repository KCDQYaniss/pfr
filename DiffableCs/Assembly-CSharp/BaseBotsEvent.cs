//Type is in global namespace

public abstract class BaseBotsEvent
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public BaseBotsEvent <>4__this; //Field offset: 0x10
		public BotOwner bot; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <TryActivateBotEventLayers>g__OnSetStrategy|0(BaseBrain state) { }

	}

	public const int FORCE_ATTACK_EVENT = 501; //Field offset: 0x0
	public const int PURSUIT_LAYER = 502; //Field offset: 0x0
	public const int KHOROVOD_CHRISTMAS_EVENT_LAYER = 503; //Field offset: 0x0
	public const int FOLLOW_PLAYER_LAYER = 504; //Field offset: 0x0
	public const int HALLOWEEN_HIDE_LAYER = 506; //Field offset: 0x0
	public const int GO_TO_GENERATOR_EVENT_LAYER = 507; //Field offset: 0x0
	public const int GOTO_POINT_OF_INTERST = 509; //Field offset: 0x0
	protected bool _isStarted; //Field offset: 0x10
	protected readonly BotsList _botsList; //Field offset: 0x18

	public abstract List LayersToActivate
	{
		 get { } //Length: 0
	}

	public abstract List LayersToDeActivate
	{
		 get { } //Length: 0
	}

	protected BaseBotsEvent(BotsList botsList) { }

	public override void Activate() { }

	protected override void BotEventActive(BotOwner bot) { }

	protected abstract bool CanActivate(BotOwner bot) { }

	public override void Dispose() { }

	public abstract List get_LayersToActivate() { }

	public abstract List get_LayersToDeActivate() { }

	protected override bool Start(string cause) { }

	protected void TryActivateBotEventLayers(BotOwner bot) { }

}

