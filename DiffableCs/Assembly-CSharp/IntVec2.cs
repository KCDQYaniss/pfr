//Type is in global namespace

public struct IntVec2
{
	public int X; //Field offset: 0x0
	public int Y; //Field offset: 0x4

	public float Length
	{
		 get { } //Length: 154
	}

	public IntVec2(int x, int y) { }

	public static float Distance(IntVec2 a, IntVec2 b) { }

	public virtual bool Equals(object other) { }

	public float get_Length() { }

	public virtual int GetHashCode() { }

	public static IntVec2 op_Addition(IntVec2 a, IntVec2 b) { }

	public static IntVec2 op_Division(IntVec2 a, int d) { }

	public static IntVec2 op_Division(IntVec2 a, float d) { }

	public static bool op_Equality(IntVec2 lhs, IntVec2 rhs) { }

	public static Vector2 op_Implicit(IntVec2 intVec2) { }

	public static bool op_Inequality(IntVec2 lhs, IntVec2 rhs) { }

	public static IntVec2 op_Multiply(IntVec2 a, IntVec2 b) { }

	public static IntVec2 op_Multiply(float d, IntVec2 a) { }

	public static IntVec2 op_Multiply(IntVec2 a, int d) { }

	public static IntVec2 op_Multiply(IntVec2 a, float d) { }

	public static IntVec2 op_Multiply(int d, IntVec2 a) { }

	public static IntVec2 op_Subtraction(IntVec2 a, IntVec2 b) { }

	public static IntVec2 op_UnaryNegation(IntVec2 a) { }

	public string ToString(string format) { }

	public virtual string ToString() { }

}

