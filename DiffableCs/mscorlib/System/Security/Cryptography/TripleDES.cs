namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	public virtual byte[] Key
	{
		 get { } //Length: 216
		 set { } //Length: 547
	}

	private static TripleDES() { }

	protected TripleDES() { }

	public static TripleDES Create() { }

	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	public virtual byte[] get_Key() { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	public virtual void set_Key(byte[] value) { }

}

