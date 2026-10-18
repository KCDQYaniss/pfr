namespace FilesChecker;

internal class ResourceInjector
{
	private readonly byte[] _resourceSignature; //Field offset: 0x10

	public ResourceInjector() { }

	private long FindSignatureOffset(Stream stream, byte[] signature) { }

	private static byte[] GetHash(string value) { }

	public void Read(Stream resourceOutStream, string filePath, string cipherKey) { }

	public void Write(Stream resourceStream, string filePath, string cipherKey) { }

}

