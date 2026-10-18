namespace Dissonance;

internal class PlayerCollection
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly Dictionary _playersLookup; //Field offset: 0x10
	private readonly List _players; //Field offset: 0x18
	private readonly ReadOnlyCollection _playersReadOnly; //Field offset: 0x20
	[CompilerGenerated]
	private LocalVoicePlayerState <Local>k__BackingField; //Field offset: 0x28

	public private LocalVoicePlayerState Local
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[NotNull]
	public ReadOnlyCollection Readonly
	{
		 get { } //Length: 5
	}

	private static PlayerCollection() { }

	public PlayerCollection() { }

	public void Add(VoicePlayerState state) { }

	[CompilerGenerated]
	public LocalVoicePlayerState get_Local() { }

	public ReadOnlyCollection get_Readonly() { }

	[CanBeNull]
	public VoicePlayerState Remove(string playerId) { }

	[CompilerGenerated]
	private void set_Local(LocalVoicePlayerState value) { }

	public void Start(string name, IAmplitudeProvider micAmplitude, Rooms rooms, RoomChannels roomChannels, PlayerChannels playerChannels, ILossEstimator loss, ICommsNetwork net) { }

	public bool TryGet(string playerId, out VoicePlayerState state) { }

	public void Update() { }

}

