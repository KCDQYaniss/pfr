namespace EFT.UI.Map;

public class ExtractionPoint
{
	public string Name; //Field offset: 0x10
	public bool NotGuaranteed; //Field offset: 0x18
	public Vector2 PositionOnMap; //Field offset: 0x1C
	public bool ShowRadius; //Field offset: 0x24
	public float Radius; //Field offset: 0x28

	public ExtractionPoint() { }

}

