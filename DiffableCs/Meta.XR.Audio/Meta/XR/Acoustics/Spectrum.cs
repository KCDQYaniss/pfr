namespace Meta.XR.Acoustics;

[DefaultMember("Item")]
internal sealed class Spectrum : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <get_Item>b__11_0(Point p) { }

		internal float <get_Item>b__11_1(Point p) { }

	}

	public struct Point : IComparable
	{
		[SerializeField]
		internal float frequency; //Field offset: 0x0
		[SerializeField]
		internal float data; //Field offset: 0x4

		internal Point(float frequency = 0, float data = 0) { }

		public override int CompareTo(Point other) { }

		public static Point op_Implicit(Vector2 v) { }

		public static Vector2 op_Implicit(Point point) { }

		public virtual string ToString() { }

	}

	[SerializeField]
	internal int selection; //Field offset: 0x10
	[SerializeField]
	internal List points; //Field offset: 0x18

	internal float Item
	{
		internal get { } //Length: 1461
	}

	internal Spectrum(Spectrum other = null) { }

	internal void Add(float frequency, float data) { }

	internal void Clone(Spectrum other) { }

	internal float get_Item(float f) { }

	internal void Sort() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<Meta.XR.Acoustics.Spectrum.Point>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

