namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael
{

	public RijndaelManaged() { }

	public virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

