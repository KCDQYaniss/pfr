namespace EFT.UI;

public class UITutorialHintAnchor : UIElement
{
	public Vector2Int Pivot; //Field offset: 0x70
	public bool IsHorizontal; //Field offset: 0x78
	public float TextBlockOffset; //Field offset: 0x7C
	public GameObject[] ObjectsToHighlight; //Field offset: 0x80

	public UITutorialHintAnchor() { }

}

