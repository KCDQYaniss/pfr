namespace System;

internal static class SR
{
	private static readonly bool s_usingResourceKeys; //Field offset: 0x0
	private static ResourceManager s_resourceManager; //Field offset: 0x8

	internal static string InvalidActivityTrackingOptions
	{
		internal get { } //Length: 93
	}

	internal static string MoreThanOneWildcard
	{
		internal get { } //Length: 93
	}

	internal static ResourceManager ResourceManager
	{
		internal get { } //Length: 366
	}

	private static SR() { }

	internal static string Format(string resourceFormat, object p1) { }

	internal static string get_InvalidActivityTrackingOptions() { }

	internal static string get_MoreThanOneWildcard() { }

	internal static ResourceManager get_ResourceManager() { }

	private static string GetResourceString(string resourceKey) { }

	private static bool GetUsingResourceKeysSwitchValue() { }

	internal static bool UsingResourceKeys() { }

}

