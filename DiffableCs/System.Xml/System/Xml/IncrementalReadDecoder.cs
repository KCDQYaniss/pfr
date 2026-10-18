namespace System.Xml;

internal abstract class IncrementalReadDecoder
{

	internal abstract bool IsFull
	{
		internal get { } //Length: 0
	}

	protected IncrementalReadDecoder() { }

	internal abstract int Decode(char[] chars, int startPos, int len) { }

	internal abstract bool get_IsFull() { }

}

