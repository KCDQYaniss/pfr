namespace Dissonance.Networking;

public interface ICommsNetworkState
{

	public CodecSettings CodecSettings
	{
		 get { } //Length: 0
	}

	public PlayerChannels PlayerChannels
	{
		 get { } //Length: 0
	}

	public string PlayerName
	{
		 get { } //Length: 0
	}

	public RoomChannels RoomChannels
	{
		 get { } //Length: 0
	}

	public Rooms Rooms
	{
		 get { } //Length: 0
	}

	public CodecSettings get_CodecSettings() { }

	public PlayerChannels get_PlayerChannels() { }

	public string get_PlayerName() { }

	public RoomChannels get_RoomChannels() { }

	public Rooms get_Rooms() { }

}

