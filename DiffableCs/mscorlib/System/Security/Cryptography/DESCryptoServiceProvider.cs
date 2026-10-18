namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES
{

	public DESCryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

}

