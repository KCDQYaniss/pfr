namespace System;

internal static class SR
{
	private static readonly bool s_usingResourceKeys; //Field offset: 0x0
	private static ResourceManager s_resourceManager; //Field offset: 0x8

	internal static string ChannelClosedException_DefaultMessage
	{
		internal get { } //Length: 93
	}

	internal static string InvalidOperation_IncompleteAsyncOperation
	{
		internal get { } //Length: 93
	}

	internal static string InvalidOperation_IncorrectToken
	{
		internal get { } //Length: 93
	}

	internal static string InvalidOperation_MultipleContinuations
	{
		internal get { } //Length: 93
	}

	internal static ResourceManager ResourceManager
	{
		internal get { } //Length: 366
	}

	private static SR() { }

	internal static string get_ChannelClosedException_DefaultMessage() { }

	internal static string get_InvalidOperation_IncompleteAsyncOperation() { }

	internal static string get_InvalidOperation_IncorrectToken() { }

	internal static string get_InvalidOperation_MultipleContinuations() { }

	internal static ResourceManager get_ResourceManager() { }

	private static string GetResourceString(string resourceKey) { }

	internal static bool UsingResourceKeys() { }

}

