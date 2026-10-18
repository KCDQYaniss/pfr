//Type is in global namespace

public abstract class ThrowGrenadeRequest : BotRequest
{
	[CompilerGenerated]
	private Nullable <ThrowFromPos>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private AIGreanageThrowData <ThrowData>k__BackingField; //Field offset: 0x80

	public abstract Vector3 PlaceToThrow
	{
		 get { } //Length: 0
	}

	public virtual EBotRequestMode RequestMode
	{
		 get { } //Length: 3
	}

	public AIGreanageThrowData ThrowData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Nullable ThrowFromPos
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected ThrowGrenadeRequest(IPlayer requester) { }

	public virtual bool CanProceed() { }

	public virtual bool CanRequest(BotOwner requester) { }

	public virtual bool CanStartExecute(BotOwner executer) { }

	public override bool CanThrow() { }

	public virtual void Dispose() { }

	public abstract Vector3 get_PlaceToThrow() { }

	public virtual EBotRequestMode get_RequestMode() { }

	[CompilerGenerated]
	public AIGreanageThrowData get_ThrowData() { }

	[CompilerGenerated]
	public Nullable get_ThrowFromPos() { }

	public override bool IsComeToPlace() { }

	protected void OnGrenadeThrowComplete(ThrowWeap throwWeap) { }

	public virtual void PlayerDestroy(Player player) { }

	[CompilerGenerated]
	protected void set_ThrowData(AIGreanageThrowData value) { }

	[CompilerGenerated]
	protected void set_ThrowFromPos(Nullable value) { }

}

