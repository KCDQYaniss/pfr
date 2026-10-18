namespace System;

internal static class SR
{
	private static readonly bool s_usingResourceKeys; //Field offset: 0x0
	private static ResourceManager s_resourceManager; //Field offset: 0x8

	internal static string KeyedServicesNotSupported
	{
		internal get { } //Length: 93
	}

	internal static string NonKeyedDescriptorMisuse
	{
		internal get { } //Length: 93
	}

	internal static string NoServiceRegistered
	{
		internal get { } //Length: 93
	}

	internal static ResourceManager ResourceManager
	{
		internal get { } //Length: 366
	}

	internal static string ServiceCollectionReadOnly
	{
		internal get { } //Length: 93
	}

	internal static string TryAddIndistinguishableTypeToEnumerable
	{
		internal get { } //Length: 93
	}

	private static SR() { }

	[NullableContext(1)]
	internal static string Format(string resourceFormat, object p1) { }

	[NullableContext(1)]
	internal static string Format(string resourceFormat, object p1, object p2) { }

	internal static string get_KeyedServicesNotSupported() { }

	internal static string get_NonKeyedDescriptorMisuse() { }

	internal static string get_NoServiceRegistered() { }

	internal static ResourceManager get_ResourceManager() { }

	internal static string get_ServiceCollectionReadOnly() { }

	internal static string get_TryAddIndistinguishableTypeToEnumerable() { }

	private static string GetResourceString(string resourceKey) { }

	private static bool GetUsingResourceKeysSwitchValue() { }

	internal static bool UsingResourceKeys() { }

}

