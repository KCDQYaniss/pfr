namespace EFT.Network.Tools;

[Extension]
public static class ArrayPoolExtensions
{

	[Extension]
	public static DisposableArrayPool Rent(ArrayPool pool, int count, out T[] polledArray) { }

}

