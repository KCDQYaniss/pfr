namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5
{
	private static readonly uint[] K; //Field offset: 0x0
	private uint[] _H; //Field offset: 0x28
	private uint[] buff; //Field offset: 0x30
	private ulong count; //Field offset: 0x38
	private byte[] _ProcessingBuffer; //Field offset: 0x40
	private int _ProcessingBufferCount; //Field offset: 0x48

	private static MD5CryptoServiceProvider() { }

	public MD5CryptoServiceProvider() { }

	internal void AddLength(ulong length, byte[] buffer, int position) { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	protected virtual void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected virtual byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

