namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA1Managed : SHA1
{
	private byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private uint[] _stateSHA1; //Field offset: 0x38
	private uint[] _expandedBuffer; //Field offset: 0x40

	private byte[] _EndHash() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	public SHA1Managed() { }

	protected virtual void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected virtual byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static void SHAExpand(uint* x) { }

	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

}

