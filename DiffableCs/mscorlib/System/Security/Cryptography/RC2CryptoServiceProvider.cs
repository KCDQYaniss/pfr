namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2
{
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x0
	private bool m_use40bitSalt; //Field offset: 0x50

	public virtual int EffectiveKeySize
	{
		 get { } //Length: 4
	}

	private static RC2CryptoServiceProvider() { }

	public RC2CryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	public virtual int get_EffectiveKeySize() { }

}

