namespace Audio.RadioSystem;

public interface IBroadcastDataProvider
{

	public bool TryGetClipAndBroadcastTime(ERadioStation station, out AudioClip clip, out double broadcastTime) { }

}

