namespace EFT.Utilities;

public static class FastRndom
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Vector3 <.cctor>b__11_0() { }

		internal Vector3 <.cctor>b__11_1() { }

		internal Vector3 <.cctor>b__11_2() { }

		internal Vector3 <.cctor>b__11_3() { }

	}

	internal class OwnSeedRnd
	{
		public int Seed; //Field offset: 0x10

		public OwnSeedRnd() { }

		public float Float() { }

		public int Int(int max) { }

		public int Range(int start, int max) { }

		public float Range(float start, float max) { }

		public float Value01() { }

		public Vector3 VectorNormalized() { }

	}

	internal class Unrepeated
	{
		private int _lastRandom; //Field offset: 0x10
		private int _maxRandom; //Field offset: 0x14

		public Unrepeated(int maxRandom) { }

		public int Get() { }

	}

	private static int _rnd1; //Field offset: 0x0
	private const int Count = 1024; //Field offset: 0x0
	private const float IntToFloat = 4.656613E-10; //Field offset: 0x0
	private static uint _rnd2; //Field offset: 0x4
	private static int _rndI; //Field offset: 0x8
	private static float[] _floats; //Field offset: 0x10
	private static Vector3[] _vectors; //Field offset: 0x18
	private static Vector3[] _hemisphereVectors; //Field offset: 0x20
	private static Vector3[] _circleVectors; //Field offset: 0x28
	private static Vector3[] _Cone60Vectors; //Field offset: 0x30
	private static float[] _fRotations; //Field offset: 0x38

	private static FastRndom() { }

	public static Vector3 Cone60() { }

	public static float Float(int input) { }

	public static float Float() { }

	public static float FloatRotation() { }

	public static int Int() { }

	public static int Int(int max) { }

	public static int Int(int input, int start, int diapazone) { }

	public static int Int(int start, int diapazone) { }

	public static int RandomizeInt(int input) { }

	private static float[] RandomsF(int length, float mult = 1) { }

	private static Vector3[] RandomsV(int length, Func func) { }

	public static float Range(int input, float start, float max) { }

	public static uint Uint() { }

	public static Vector3 VectorCircle() { }

	public static Vector3 VectorHemisphere() { }

	public static Vector3 VectorNormalized() { }

}

