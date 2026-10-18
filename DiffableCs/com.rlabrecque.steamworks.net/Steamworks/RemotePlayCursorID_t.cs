namespace Steamworks;

public struct RemotePlayCursorID_t : IEquatable, IComparable
{
	public uint m_RemotePlayCursorID; //Field offset: 0x0

	public RemotePlayCursorID_t(uint value) { }

	public override int CompareTo(RemotePlayCursorID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(RemotePlayCursorID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RemotePlayCursorID_t x, RemotePlayCursorID_t y) { }

	public static RemotePlayCursorID_t op_Explicit(uint value) { }

	public static uint op_Explicit(RemotePlayCursorID_t that) { }

	public static bool op_Inequality(RemotePlayCursorID_t x, RemotePlayCursorID_t y) { }

	public virtual string ToString() { }

}

