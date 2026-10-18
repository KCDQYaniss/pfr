//Type is in global namespace

public class EllipseCalculator
{
	internal struct Ellipse
	{
		public double Width; //Field offset: 0x0
		public double Height; //Field offset: 0x8
		public double PowTwoWidth; //Field offset: 0x10
		public double PowTwoHeight; //Field offset: 0x18
		public double PowTwoEccentricity; //Field offset: 0x20
		public int CalcAccuracy; //Field offset: 0x28
		public double Length; //Field offset: 0x30
		public double[] CachedLengths; //Field offset: 0x38

		public Ellipse(double width, double height, int calcAccuracy) { }

		public void CalculateLengthCash() { }

		public float GetAngle(float length) { }

		public double GetCashLength(int angle) { }

		public double GetCurveLength(double startAngle, double angle) { }

		private float GetNearestAngle(float length) { }

	}

	private List _cachedEllipses; //Field offset: 0x10

	public EllipseCalculator() { }

	public float AngleFromLength(float widthHalf, float heightHalf, float length) { }

	private Ellipse GetEllipse(double widthHalf, double heightHalf) { }

	public float GetLength(double widthHalf, double heightHalf) { }

	public float LengthFromAngle(double widthHalf, double heightHalf, float angle) { }

}

