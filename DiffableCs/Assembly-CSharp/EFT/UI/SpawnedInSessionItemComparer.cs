namespace EFT.UI;

public sealed class SpawnedInSessionItemComparer : IComparer
{
	private readonly int _direction; //Field offset: 0x10

	public SpawnedInSessionItemComparer(int direction = 0) { }

	public override int Compare(Item x, Item y) { }

}

