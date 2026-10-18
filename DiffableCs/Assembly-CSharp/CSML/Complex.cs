namespace CSML;

public class Complex
{
	private double re; //Field offset: 0x10
	private double im; //Field offset: 0x18

	public static Complex I
	{
		 get { } //Length: 76
	}

	public double Im
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public static Complex One
	{
		 get { } //Length: 76
	}

	public double Re
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public static Complex Zero
	{
		 get { } //Length: 64
	}

	public Complex(string s) { }

	public Complex(double real_part, double imaginary_part) { }

	public Complex(double real_part) { }

	public Complex() { }

	public static double Abs(Complex a) { }

	public static double Arg(Complex a) { }

	public static Complex Conj(Complex a) { }

	public static Complex Cos(Complex a) { }

	public static Complex Cosh(Complex a) { }

	public static Complex Cot(Complex a) { }

	public static Complex Coth(Complex a) { }

	public static Complex Csch(Complex a) { }

	public virtual bool Equals(object obj) { }

	public static Complex Exp(Complex a) { }

	public static Complex get_I() { }

	public double get_Im() { }

	public static Complex get_One() { }

	public double get_Re() { }

	public static Complex get_Zero() { }

	public virtual int GetHashCode() { }

	public static Complex Inv(Complex a) { }

	public bool IsImaginary() { }

	public bool IsReal() { }

	public static Complex Log(Complex a) { }

	public static Complex op_Addition(Complex a, Complex b) { }

	public static Complex op_Addition(Complex a, double b) { }

	public static Complex op_Addition(double a, Complex b) { }

	public static Complex op_Division(Complex a, Complex b) { }

	public static Complex op_Division(Complex a, double b) { }

	public static Complex op_Division(double a, Complex b) { }

	public static bool op_Equality(Complex a, Complex b) { }

	public static bool op_Equality(Complex a, double b) { }

	public static bool op_Equality(double a, Complex b) { }

	public static bool op_Inequality(Complex a, Complex b) { }

	public static bool op_Inequality(double a, Complex b) { }

	public static bool op_Inequality(Complex a, double b) { }

	public static Complex op_Multiply(Complex a, double d) { }

	public static Complex op_Multiply(Complex a, Complex b) { }

	public static Complex op_Multiply(double d, Complex a) { }

	public static Complex op_Subtraction(Complex a, Complex b) { }

	public static Complex op_Subtraction(Complex a, double b) { }

	public static Complex op_Subtraction(double a, Complex b) { }

	public static Complex op_UnaryNegation(Complex a) { }

	public static Complex Pow(double a, Complex b) { }

	public static Complex Pow(Complex a, double b) { }

	public static Complex Pow(Complex a, Complex b) { }

	public static Complex Sech(Complex a) { }

	public void set_Im(double value) { }

	public void set_Re(double value) { }

	public static Complex Sin(Complex a) { }

	public static Complex Sinh(Complex a) { }

	public static Complex Sqrt(Complex a) { }

	public static Complex Sqrt(double d) { }

	public static Complex Tan(Complex a) { }

	public static Complex Tanh(Complex a) { }

	public static Match Test(string s) { }

	public virtual string ToString() { }

	public string ToString(string format) { }

}

