namespace EFT.RocketLauncher.Explosion;

public struct OptimizedVector3 : IEquatable
{
	public readonly float X; //Field offset: 0x0
	public readonly float Y; //Field offset: 0x4
	public readonly float Z; //Field offset: 0x8
	private readonly int _hashCode; //Field offset: 0xC

	public OptimizedVector3(float x, float y, float z) { }

	public override bool Equals(OptimizedVector3 other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static OptimizedVector3 op_Addition(OptimizedVector3 v1, OptimizedVector3 v2) { }

	public static OptimizedVector3 op_Addition(OptimizedVector3 v1, Vector3 v2) { }

	public static bool op_Equality(OptimizedVector3 v1, OptimizedVector3 v2) { }

	public static bool op_Inequality(OptimizedVector3 v1, OptimizedVector3 v2) { }

	public static OptimizedVector3 op_Multiply(float val, OptimizedVector3 vec) { }

	public static OptimizedVector3 op_Subtraction(OptimizedVector3 v1, OptimizedVector3 v2) { }

}

