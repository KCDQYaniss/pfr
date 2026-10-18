namespace Steamworks;

public struct TimelineEventHandle_t : IEquatable, IComparable
{
	public ulong m_TimelineEventHandle; //Field offset: 0x0

	public TimelineEventHandle_t(ulong value) { }

	public override int CompareTo(TimelineEventHandle_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(TimelineEventHandle_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TimelineEventHandle_t x, TimelineEventHandle_t y) { }

	public static TimelineEventHandle_t op_Explicit(ulong value) { }

	public static ulong op_Explicit(TimelineEventHandle_t that) { }

	public static bool op_Inequality(TimelineEventHandle_t x, TimelineEventHandle_t y) { }

	public virtual string ToString() { }

}

