namespace EFT.Settings.Graphics;

public struct EftResolution : IEquatable
{
	public sealed class ComplexComparer : DefaultComparer
	{

		public ComplexComparer() { }

		public virtual int Compare(EftResolution r0, EftResolution r1) { }

	}

	public class DefaultComparer : IComparer
	{

		public DefaultComparer() { }

		public override int Compare(EftResolution r0, EftResolution r1) { }

	}

	public int Width; //Field offset: 0x0
	public int Height; //Field offset: 0x4

	public EftResolution(Resolution resolution) { }

	public EftResolution(int width, int height) { }

	public override bool Equals(EftResolution other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(EftResolution left, EftResolution right) { }

	public static bool op_Inequality(EftResolution left, EftResolution right) { }

	public virtual string ToString() { }

}

