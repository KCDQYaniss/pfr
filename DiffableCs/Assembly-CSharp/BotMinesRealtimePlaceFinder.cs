//Type is in global namespace

public class BotMinesRealtimePlaceFinder : BotData
{
	private const float SDIST_TOO_CLOSE_TO_PREV = 4; //Field offset: 0x0
	private const float SDIST__BY_POINT_ON_WAY = 9; //Field offset: 0x0
	private float _nextPossibleFind; //Field offset: 0x18
	private Vector3 _lastPlaced; //Field offset: 0x1C

	public BotMinesRealtimePlaceFinder(BotOwner owner) { }

	public void TryFindAndPlant() { }

}

