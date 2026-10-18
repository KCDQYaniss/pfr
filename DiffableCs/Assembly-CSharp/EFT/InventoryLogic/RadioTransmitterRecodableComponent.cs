namespace EFT.InventoryLogic;

public sealed class RadioTransmitterRecodableComponent : RecodableComponent
{
	private const string BLOCKED = "RadioTransmitter/AttributeValues/Blocked"; //Field offset: 0x0
	private RadioTransmitterStatus _status; //Field offset: 0x30
	private RadioTransmitterHandler _handler; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnRadioTransmitterStateChanged; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnRadioTransmitterStatusChanged; //Field offset: 0x48

	public event Action OnRadioTransmitterStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRadioTransmitterStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RadioTransmitterHandler Handler
	{
		 get { } //Length: 5
	}

	public RadioTransmitterStatus Status
	{
		 get { } //Length: 4
	}

	public RadioTransmitterRecodableComponent(Item item, IRecodableItemTemplate template) { }

	[CompilerGenerated]
	public void add_OnRadioTransmitterStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnRadioTransmitterStatusChanged(Action value) { }

	public RadioTransmitterHandler get_Handler() { }

	public RadioTransmitterStatus get_Status() { }

	protected virtual string GetAttributeValue() { }

	public void InitializeHandler(Player player) { }

	[CompilerGenerated]
	public void remove_OnRadioTransmitterStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnRadioTransmitterStatusChanged(Action value) { }

	public virtual void SetEncoded(bool value) { }

	public void SetStatus(RadioTransmitterStatus status) { }

}

