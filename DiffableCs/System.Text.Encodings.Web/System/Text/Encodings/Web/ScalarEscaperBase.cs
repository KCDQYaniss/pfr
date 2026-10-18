namespace System.Text.Encodings.Web;

internal abstract class ScalarEscaperBase
{

	protected ScalarEscaperBase() { }

	internal abstract int EncodeUtf16(Rune value, Span destination) { }

	internal abstract int EncodeUtf8(Rune value, Span destination) { }

}

