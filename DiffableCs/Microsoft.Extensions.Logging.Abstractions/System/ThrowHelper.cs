namespace System;

internal static class ThrowHelper
{

	private static void Throw(string paramName) { }

	[NullableContext(2)]
	internal static void ThrowIfNull(object argument, string paramName = null) { }

}

