namespace Audio.Extensions;

[Extension]
public static class AudioExtensions
{

	[Extension]
	public static bool Contains(EAudioRoomTypeMask mask, EAudioRoomTypeMask target) { }

	[Extension]
	public static bool Is(EAudioRoomTypeMask mask, EAudioRoomTypeMask target) { }

	[Extension]
	public static bool IsIndoor(EAudioRoomTypeMask mask) { }

	[Extension]
	public static bool IsIndoorIsolated(EAudioRoomTypeMask mask) { }

	[Extension]
	public static bool IsOutdoor(EAudioRoomTypeMask mask) { }

}

