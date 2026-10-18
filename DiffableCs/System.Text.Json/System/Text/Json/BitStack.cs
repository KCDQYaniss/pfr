namespace System.Text.Json;

internal struct BitStack
{
	private int[] _array; //Field offset: 0x0
	private ulong _allocationFreeContainer; //Field offset: 0x8
	private int _currentDepth; //Field offset: 0x10

	public int CurrentDepth
	{
		 get { } //Length: 164
	}

	private static int Div32Rem(int number, out int remainder) { }

	private void DoubleArray(int minSize) { }

	public int get_CurrentDepth() { }

	public bool Pop() { }

	private bool PopFromArray() { }

	public void PushFalse() { }

	private void PushToArray(bool value) { }

	public void PushTrue() { }

}

