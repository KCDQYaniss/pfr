namespace Steamworks;

public struct AccountID_t : IEquatable, IComparable
{
	public static readonly AccountID_t Invalid; //Field offset: 0x0
	public uint m_AccountID; //Field offset: 0x0

	private static AccountID_t() { }

	public AccountID_t(uint value) { }

	public override int CompareTo(AccountID_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(AccountID_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AccountID_t x, AccountID_t y) { }

	public static AccountID_t op_Explicit(uint value) { }

	public static uint op_Explicit(AccountID_t that) { }

	public static bool op_Inequality(AccountID_t x, AccountID_t y) { }

	public virtual string ToString() { }

}

