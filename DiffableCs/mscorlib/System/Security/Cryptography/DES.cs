namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	public virtual byte[] Key
	{
		 get { } //Length: 255
		 set { } //Length: 687
	}

	private static DES() { }

	protected DES() { }

	public static DES Create() { }

	public virtual byte[] get_Key() { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	private static ulong QuadWordFromBigEndian(byte[] block) { }

	public virtual void set_Key(byte[] value) { }

}

