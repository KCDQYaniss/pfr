namespace CommonAssets.Scripts.Audio.RadioSystem;

public interface IRadioStation
{

	public BroadcastItemData CurrentBroadcastItem
	{
		 get { } //Length: 0
	}

	public float CurrentBroadcastTime
	{
		 get { } //Length: 0
	}

	public ERadioStation Station
	{
		 get { } //Length: 0
	}

	public BroadcastItemData get_CurrentBroadcastItem() { }

	public float get_CurrentBroadcastTime() { }

	public ERadioStation get_Station() { }

	public void Pause() { }

	public void StartBroadcast() { }

	public void StopBroadcast() { }

}

