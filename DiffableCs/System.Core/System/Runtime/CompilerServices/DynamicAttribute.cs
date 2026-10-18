namespace System.Runtime.CompilerServices;

[AttributeUsage(10636)]
public sealed class DynamicAttribute : Attribute
{
	private readonly bool[] _transformFlags; //Field offset: 0x10

	public IList TransformFlags
	{
		 get { } //Length: 267
	}

	public IList get_TransformFlags() { }

}

