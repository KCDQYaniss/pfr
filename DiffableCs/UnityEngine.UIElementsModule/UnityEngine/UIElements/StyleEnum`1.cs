namespace UnityEngine.UIElements;

public struct StyleEnum`1 : IStyleValue, IEquatable
{
	private T m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x0

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
	}

	public override T value
	{
		 get { } //Length: 12
	}

	public StyleEnum`1(T v) { }

	public StyleEnum`1(StyleKeyword keyword) { }

	internal StyleEnum`1(T v, StyleKeyword keyword) { }

	public override bool Equals(StyleEnum other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override T get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleEnum lhs, StyleEnum rhs) { }

	public static StyleEnum op_Implicit(StyleKeyword keyword) { }

	public static StyleEnum op_Implicit(T v) { }

	public static bool op_Inequality(StyleEnum lhs, StyleEnum rhs) { }

	public virtual string ToString() { }

}

