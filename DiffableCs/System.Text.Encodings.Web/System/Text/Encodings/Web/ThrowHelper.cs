namespace System.Text.Encodings.Web;

internal static class ThrowHelper
{

	private static string GetArgumentName(ExceptionArgument argument) { }

	[DoesNotReturn]
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	[DoesNotReturn]
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

}

