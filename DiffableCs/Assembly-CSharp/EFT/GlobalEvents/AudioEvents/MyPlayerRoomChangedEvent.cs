namespace EFT.GlobalEvents.AudioEvents;

public class MyPlayerRoomChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private ISpatialAudioRoom <Room>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CurrentRoomID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EAudioRoomTypeMask <CurrentRoomType>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <CurrentOutdoorRoomID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private EPlayerRoomInteractionState <InteractionState>k__BackingField; //Field offset: 0x2C

	public private int CurrentOutdoorRoomID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int CurrentRoomID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EAudioRoomTypeMask CurrentRoomType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EPlayerRoomInteractionState InteractionState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ISpatialAudioRoom Room
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MyPlayerRoomChangedEvent() { }

	[CompilerGenerated]
	public int get_CurrentOutdoorRoomID() { }

	[CompilerGenerated]
	public int get_CurrentRoomID() { }

	[CompilerGenerated]
	public EAudioRoomTypeMask get_CurrentRoomType() { }

	[CompilerGenerated]
	public EPlayerRoomInteractionState get_InteractionState() { }

	[CompilerGenerated]
	public ISpatialAudioRoom get_Room() { }

	public void Invoke(ISpatialAudioRoom room, int roomID, EAudioRoomTypeMask roomTypeMask, int currentOutdoorRoomID, EPlayerRoomInteractionState roomInteractionState) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_CurrentOutdoorRoomID(int value) { }

	[CompilerGenerated]
	private void set_CurrentRoomID(int value) { }

	[CompilerGenerated]
	private void set_CurrentRoomType(EAudioRoomTypeMask value) { }

	[CompilerGenerated]
	private void set_InteractionState(EPlayerRoomInteractionState value) { }

	[CompilerGenerated]
	private void set_Room(ISpatialAudioRoom value) { }

}

