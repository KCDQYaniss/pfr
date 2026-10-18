namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES
{

	public TripleDESCryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

}

