namespace ChartAndGraph;

[DefaultMember("Item")]
public struct DoubleVector3
{
	public double x; //Field offset: 0x0
	public double y; //Field offset: 0x8
	public double z; //Field offset: 0x10

	public static DoubleVector3 back
	{
		 get { } //Length: 27
	}

	public static DoubleVector3 down
	{
		 get { } //Length: 27
	}

	public static DoubleVector3 forward
	{
		 get { } //Length: 27
	}

	[Obsolete("Use DoubleVector3.forward instead.")]
	public static DoubleVector3 fwd
	{
		 get { } //Length: 27
	}

	public double Item
	{
		 get { } //Length: 129
		 set { } //Length: 129
	}

	public static DoubleVector3 left
	{
		 get { } //Length: 27
	}

	public double magnitude
	{
		 get { } //Length: 219
	}

	public DoubleVector3 normalized
	{
		 get { } //Length: 126
	}

	public static DoubleVector3 one
	{
		 get { } //Length: 25
	}

	public static DoubleVector3 right
	{
		 get { } //Length: 27
	}

	public double sqrMagnitude
	{
		 get { } //Length: 35
	}

	public static DoubleVector3 up
	{
		 get { } //Length: 27
	}

	public static DoubleVector3 zero
	{
		 get { } //Length: 17
	}

	public DoubleVector3(double x, double y, double z) { }

	public DoubleVector3(double x, double y) { }

	public static DoubleVector3 ClampMagnitude(DoubleVector3 vector, double maxLength) { }

	public static DoubleVector3 Cross(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public static double Distance(DoubleVector3 a, DoubleVector3 b) { }

	public static double Dot(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public virtual bool Equals(object other) { }

	public static DoubleVector3 get_back() { }

	public static DoubleVector3 get_down() { }

	public static DoubleVector3 get_forward() { }

	public static DoubleVector3 get_fwd() { }

	public double get_Item(int index) { }

	public static DoubleVector3 get_left() { }

	public double get_magnitude() { }

	public DoubleVector3 get_normalized() { }

	public static DoubleVector3 get_one() { }

	public static DoubleVector3 get_right() { }

	public double get_sqrMagnitude() { }

	public static DoubleVector3 get_up() { }

	public static DoubleVector3 get_zero() { }

	public virtual int GetHashCode() { }

	public static DoubleVector3 Lerp(DoubleVector3 a, DoubleVector3 b, double t) { }

	public static DoubleVector3 LerpUnclamped(DoubleVector3 a, DoubleVector3 b, double t) { }

	public static double Magnitude(DoubleVector3 a) { }

	public static DoubleVector3 Max(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public static DoubleVector3 Min(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public static DoubleVector3 MoveTowards(DoubleVector3 current, DoubleVector3 target, double maxDistanceDelta) { }

	public static DoubleVector3 Normalize(DoubleVector3 value) { }

	public void Normalize() { }

	public static DoubleVector3 op_Addition(DoubleVector3 a, DoubleVector3 b) { }

	public static DoubleVector3 op_Division(DoubleVector3 a, double d) { }

	public static bool op_Equality(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public static bool op_Inequality(DoubleVector3 lhs, DoubleVector3 rhs) { }

	public static DoubleVector3 op_Multiply(DoubleVector3 a, double d) { }

	public static DoubleVector3 op_Multiply(double d, DoubleVector3 a) { }

	public static DoubleVector3 op_Subtraction(DoubleVector3 a, DoubleVector3 b) { }

	public static DoubleVector3 op_UnaryNegation(DoubleVector3 a) { }

	public static DoubleVector3 Reflect(DoubleVector3 inDirection, DoubleVector3 inNormal) { }

	public static DoubleVector3 Scale(DoubleVector3 a, DoubleVector3 b) { }

	public void Scale(DoubleVector3 scale) { }

	public void Set(double new_x, double new_y, double new_z) { }

	public void set_Item(int index, double value) { }

	public static double SqrMagnitude(DoubleVector3 a) { }

	public DoubleVector2 ToDoubleVector2() { }

	public DoubleVector4 ToDoubleVector4() { }

	public virtual string ToString() { }

	public string ToString(string format) { }

	public Vector2 ToVector2() { }

	public Vector3 ToVector3() { }

}

