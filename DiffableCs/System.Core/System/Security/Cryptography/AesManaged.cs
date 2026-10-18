namespace System.Security.Cryptography;

public sealed class AesManaged : Aes
{
	private RijndaelManaged m_rijndael; //Field offset: 0x48

	public virtual int FeedbackSize
	{
		 get { } //Length: 42
	}

	public virtual byte[] IV
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual byte[] Key
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual int KeySize
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual CipherMode Mode
	{
		 get { } //Length: 42
		 set { } //Length: 161
	}

	public virtual PaddingMode Padding
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public AesManaged() { }

	public virtual ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	public virtual ICryptoTransform CreateDecryptor() { }

	public virtual ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	public virtual ICryptoTransform CreateEncryptor() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	public virtual int get_FeedbackSize() { }

	public virtual byte[] get_IV() { }

	public virtual byte[] get_Key() { }

	public virtual int get_KeySize() { }

	public virtual CipherMode get_Mode() { }

	public virtual PaddingMode get_Padding() { }

	public virtual void set_IV(byte[] value) { }

	public virtual void set_Key(byte[] value) { }

	public virtual void set_KeySize(int value) { }

	public virtual void set_Mode(CipherMode value) { }

	public virtual void set_Padding(PaddingMode value) { }

}

