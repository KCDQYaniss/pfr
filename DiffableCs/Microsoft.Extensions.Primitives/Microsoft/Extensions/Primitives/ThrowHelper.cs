namespace Microsoft.Extensions.Primitives;

internal static class ThrowHelper
{

	private static string GetArgumentName(ExceptionArgument argument) { }

	[DoesNotReturn]
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

}

