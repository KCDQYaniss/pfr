namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	protected byte[] KeyValue; //Field offset: 0x28

	public override byte[] Key
	{
		 get { } //Length: 122
		 set { } //Length: 353
	}

	protected KeyedHashAlgorithm() { }

	protected virtual void Dispose(bool disposing) { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

}

