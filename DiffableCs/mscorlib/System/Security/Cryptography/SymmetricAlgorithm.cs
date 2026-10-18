namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable
{
	protected int BlockSizeValue; //Field offset: 0x10
	protected int FeedbackSizeValue; //Field offset: 0x14
	protected byte[] IVValue; //Field offset: 0x18
	protected byte[] KeyValue; //Field offset: 0x20
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x28
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x30
	protected int KeySizeValue; //Field offset: 0x38
	protected CipherMode ModeValue; //Field offset: 0x3C
	protected PaddingMode PaddingValue; //Field offset: 0x40

	public override int BlockSize
	{
		 get { } //Length: 164
		 set { } //Length: 323
	}

	public override int FeedbackSize
	{
		 get { } //Length: 4
	}

	public override byte[] IV
	{
		 get { } //Length: 151
		 set { } //Length: 436
	}

	public override byte[] Key
	{
		 get { } //Length: 151
		 set { } //Length: 450
	}

	public override int KeySize
	{
		 get { } //Length: 4
		 set { } //Length: 200
	}

	public override KeySizes[] LegalKeySizes
	{
		 get { } //Length: 122
	}

	public override CipherMode Mode
	{
		 get { } //Length: 4
		 set { } //Length: 125
	}

	public override PaddingMode Padding
	{
		 get { } //Length: 4
		 set { } //Length: 125
	}

	protected SymmetricAlgorithm() { }

	public void Clear() { }

	public static SymmetricAlgorithm Create(string algName) { }

	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateDecryptor() { }

	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract void GenerateIV() { }

	public abstract void GenerateKey() { }

	public override int get_BlockSize() { }

	public override int get_FeedbackSize() { }

	public override byte[] get_IV() { }

	public override byte[] get_Key() { }

	public override int get_KeySize() { }

	public override KeySizes[] get_LegalKeySizes() { }

	public override CipherMode get_Mode() { }

	public override PaddingMode get_Padding() { }

	public override void set_BlockSize(int value) { }

	public override void set_IV(byte[] value) { }

	public override void set_Key(byte[] value) { }

	public override void set_KeySize(int value) { }

	public override void set_Mode(CipherMode value) { }

	public override void set_Padding(PaddingMode value) { }

	public bool ValidKeySize(int bitLength) { }

}

