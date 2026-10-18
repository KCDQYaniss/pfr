namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public sealed class BindTypeNameToTypeAttribute : Attribute
{
	internal readonly Type NewType; //Field offset: 0x10
	internal readonly string OldTypeName; //Field offset: 0x18

	public BindTypeNameToTypeAttribute(string oldFullTypeName, Type newType) { }

}

