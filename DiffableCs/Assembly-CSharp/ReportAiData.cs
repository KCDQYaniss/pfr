//Type is in global namespace

public class ReportAiData
{
	public IPlayer Witness; //Field offset: 0x10
	public IPlayer Enemy; //Field offset: 0x18
	public Vector3 PartPos; //Field offset: 0x20
	public EEnemyPartVisibleType VisibleOnlyBySence; //Field offset: 0x2C

	public ReportAiData(IPlayer witness, IPlayer enemy, Vector3 partPos, EEnemyPartVisibleType visibleOnlyBySence) { }

}

