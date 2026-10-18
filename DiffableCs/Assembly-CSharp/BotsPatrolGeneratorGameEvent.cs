//Type is in global namespace

public class BotsPatrolGeneratorGameEvent : BaseBotsEvent
{
	public EventObject GeneratorData; //Field offset: 0x20
	public bool IsActive; //Field offset: 0x28
	private AICoversData _coversData; //Field offset: 0x30
	[CompilerGenerated]
	private int <ConnectionGroupId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly List <LayersToDeActivate>k__BackingField; //Field offset: 0x40

	public private int ConnectionGroupId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool EventObjectCompleteSuccess
	{
		 get { } //Length: 247
	}

	public virtual List LayersToActivate
	{
		 get { } //Length: 212
	}

	public virtual List LayersToDeActivate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BotsPatrolGeneratorGameEvent(BotsList botsList, AICoversData controller) { }

	public virtual void Activate() { }

	protected virtual bool CanActivate(BotOwner bot) { }

	private void DisableStandBy() { }

	public virtual void Dispose() { }

	private void EnableStandBy() { }

	[CompilerGenerated]
	public int get_ConnectionGroupId() { }

	public bool get_EventObjectCompleteSuccess() { }

	public virtual List get_LayersToActivate() { }

	[CompilerGenerated]
	public virtual List get_LayersToDeActivate() { }

	private void OnBotAddHandler(BotOwner botOwner) { }

	private void OnGeneratorFinishWork() { }

	[CompilerGenerated]
	private void set_ConnectionGroupId(int value) { }

}

