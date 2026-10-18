namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct InterpolatedStringParameter
{
	public readonly Type Type; //Field offset: 0x0
	public readonly string Name; //Field offset: 0x8
	public readonly int Alignment; //Field offset: 0x10
	[Nullable(2)]
	public readonly string Format; //Field offset: 0x18
	public readonly int BoxOffset; //Field offset: 0x20
	[Nullable(2)]
	public readonly object BoxedValue; //Field offset: 0x28

	public InterpolatedStringParameter(Type type, string name, int alignment, string format, int boxOffset, object boxedValue) { }

}

