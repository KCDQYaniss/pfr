namespace EFT.UI.Map;

public class EntryPoint
{
	public int Index; //Field offset: 0x10
	public string Name; //Field offset: 0x18
	public Vector2 PositionOnMap; //Field offset: 0x20
	public bool IsActive; //Field offset: 0x28
	public bool Locked; //Field offset: 0x29
	public string[] OpenExtractionPoints; //Field offset: 0x30
	public bool ShowRadius; //Field offset: 0x38
	public float Radius; //Field offset: 0x3C
	public Color32 MainColor; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnDisable; //Field offset: 0x48

	public event Action OnDisable
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public EntryPoint() { }

	[CompilerGenerated]
	public void add_OnDisable(Action value) { }

	public void Disable() { }

	[CompilerGenerated]
	public void remove_OnDisable(Action value) { }

}

