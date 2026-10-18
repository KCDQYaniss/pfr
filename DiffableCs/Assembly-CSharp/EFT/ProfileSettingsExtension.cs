namespace EFT;

[Extension]
public static class ProfileSettingsExtension
{

	[Extension]
	public static bool IsBoss(ProfileSettings settings) { }

	[Extension]
	public static bool IsBossOrFollower(ProfileSettings settings) { }

	[Extension]
	public static bool IsFollower(ProfileSettings settings) { }

}

