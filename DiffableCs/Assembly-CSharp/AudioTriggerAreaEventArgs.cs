//Type is in global namespace

public sealed class AudioTriggerAreaEventArgs : EventArgs
{
	internal enum ETriggerEventType
	{
		TriggerEnter = 0,
		TriggerExit = 1,
	}

	public ETriggerEventType TriggerEventType; //Field offset: 0x10
	public IPlayer Player; //Field offset: 0x18

	public AudioTriggerAreaEventArgs() { }

}

