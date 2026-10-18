namespace System;

internal interface ISpanFormattable
{

	public bool TryFormat(Span destination, out int charsWritten, ReadOnlySpan format, IFormatProvider provider) { }

}

