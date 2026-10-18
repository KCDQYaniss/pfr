namespace EFT;

[Extension]
public static class ThousandsSeparatorExtensions
{
	private static readonly NumberFormatInfo _thousandsFormatInfo; //Field offset: 0x0

	private static ThousandsSeparatorExtensions() { }

	[Extension]
	public static string ToThousandsString(double value, int digitsAfterDecimal = 2) { }

	[Extension]
	public static string ToThousandsString(float value, int digitsAfterDecimal = 2) { }

}

