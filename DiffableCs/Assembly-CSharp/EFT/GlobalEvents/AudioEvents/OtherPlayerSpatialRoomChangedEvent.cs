namespace EFT.GlobalEvents.AudioEvents;

public class OtherPlayerSpatialRoomChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private int <PlayerId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ISpatialAudioRoom <Room>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EPlayerRoomInteractionState <InteractionState>k__BackingField; //Field offset: 0x28

	public private EPlayerRoomInteractionState InteractionState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PlayerId
	{
		[CompilerGenerated]
		 get { } //Length: 4
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

	public OtherPlayerSpatialRoomChangedEvent() { }

	[CompilerGenerated]
	public EPlayerRoomInteractionState get_InteractionState() { }

	[CompilerGenerated]
	public int get_PlayerId() { }

	[CompilerGenerated]
	public ISpatialAudioRoom get_Room() { }

	public void Invoke(int playerId, ISpatialAudioRoom room, EPlayerRoomInteractionState interactionState) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_InteractionState(EPlayerRoomInteractionState value) { }

	[CompilerGenerated]
	private void set_PlayerId(int value) { }

	[CompilerGenerated]
	private void set_Room(ISpatialAudioRoom value) { }

}

