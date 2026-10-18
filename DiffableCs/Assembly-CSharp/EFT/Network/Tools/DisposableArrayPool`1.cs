namespace EFT.Network.Tools;

public struct DisposableArrayPool`1 : IDisposable
{
	public ArrayPool pool; //Field offset: 0x0
	public T[] polledArray; //Field offset: 0x0

	public DisposableArrayPool`1(ArrayPool pool, T[] polledArray) { }

	public override void Dispose() { }

}

