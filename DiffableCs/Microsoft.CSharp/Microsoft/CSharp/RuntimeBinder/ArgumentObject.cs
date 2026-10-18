namespace Microsoft.CSharp.RuntimeBinder;

[IsReadOnly]
internal struct ArgumentObject
{
	internal readonly object Value; //Field offset: 0x0
	internal readonly CSharpArgumentInfo Info; //Field offset: 0x8
	internal readonly Type Type; //Field offset: 0x10

	public ArgumentObject(object value, CSharpArgumentInfo info, Type type) { }

}

