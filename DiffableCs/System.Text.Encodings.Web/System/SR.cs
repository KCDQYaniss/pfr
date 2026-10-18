namespace System;

internal static class SR
{
	private static readonly bool s_usingResourceKeys; //Field offset: 0x0
	private static ResourceManager s_resourceManager; //Field offset: 0x8

	internal static ResourceManager ResourceManager
	{
		internal get { } //Length: 366
	}

	internal static string TextEncoderDoesNotImplementMaxOutputCharsPerInputChar
	{
		internal get { } //Length: 93
	}

	private static SR() { }

	internal static ResourceManager get_ResourceManager() { }

	internal static string get_TextEncoderDoesNotImplementMaxOutputCharsPerInputChar() { }

	private static string GetResourceString(string resourceKey) { }

	internal static bool UsingResourceKeys() { }

}

