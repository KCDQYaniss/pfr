namespace Mono.Btls;

internal interface IMonoBtlsBioMono
{

	public void Close() { }

	public void Flush() { }

	public int Read(byte[] buffer, int offset, int size, out bool wantMore) { }

	public bool Write(byte[] buffer, int offset, int size) { }

}

