namespace EFT.Communications;

public sealed class ProfileChangeEvent
{
	private enum EAuxiliaryTypes
	{
		ProfileUnlock = 0,
		LockTrader = 1,
		AssortmentLockRule = 2,
		ForgetItems = 3,
	}

	[CompilerGenerated]
	private Action OnUpdate; //Field offset: 0x10
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x18
	public string MessageId; //Field offset: 0x20
	public ENotificationType Type; //Field offset: 0x28
	public string Entity; //Field offset: 0x30
	public Nullable Value; //Field offset: 0x38
	public bool Redeemed; //Field offset: 0x48

	public event Action OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public string Description
	{
		 get { } //Length: 400
	}

	public string EntityName
	{
		 get { } //Length: 272
	}

	public ProfileChangeEvent() { }

	[CompilerGenerated]
	public void add_OnUpdate(Action value) { }

	public string get_Description() { }

	public string get_EntityName() { }

	public void Redeem() { }

	[CompilerGenerated]
	public void remove_OnUpdate(Action value) { }

	public void Restore() { }

}

