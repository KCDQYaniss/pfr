namespace EFT.BinarySerialization;

[AttributeUsage(28)]
public sealed class BinaryReaderCompatibleAttribute : Attribute
{
	public readonly string ExtensionReadMethodName; //Field offset: 0x10
	public readonly string ExtensionWriteMethodName; //Field offset: 0x18

	public BinaryReaderCompatibleAttribute(string extensionReadMethodName, string extensionWriteMethodName) { }

}

