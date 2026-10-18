namespace Audio.Extensions;

[Extension]
public static class SoundBankExtensions
{

	[Extension]
	public static float GetRamSizeMB(SoundBank soundBank) { }

	[Extension]
	public static float PickFirstPersonClipsByEnvironment(SoundBank bank, out AudioClip indoorClip, out AudioClip outdoorClip) { }

}

