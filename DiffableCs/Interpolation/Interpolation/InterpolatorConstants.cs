namespace Interpolation;

[Extension]
public static class InterpolatorConstants
{
	public const int NOT_VALID_INT = -2147483648; //Field offset: 0x0
	public const float NOT_VALID_FLOAT = NaN; //Field offset: 0x0
	public static readonly TimeBound NOT_VALID_TIME_BOUND; //Field offset: 0x0
	public static readonly SpanBound NOT_VALID_BOUND; //Field offset: 0x8

	private static InterpolatorConstants() { }

	[Extension]
	public static bool IsValid(TimeBound timeBound) { }

	[Extension]
	public static bool IsValid(SpanBound spanBound) { }

	[Extension]
	public static bool IsValid(InterpolatorSpan interpolatorSpan) { }

}

