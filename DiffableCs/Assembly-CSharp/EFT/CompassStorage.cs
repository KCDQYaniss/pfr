namespace EFT;

public sealed class CompassStorage
{
	private Dictionary _arrows; //Field offset: 0x10

	public CompassStorage() { }

	public bool TryGetCompassArrow(GameObject root, out CompassArrow arrow) { }

}

