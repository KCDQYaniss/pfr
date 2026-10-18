namespace EFT.Hideout;

public sealed class AreaTemplate : SerializedScriptableObject
{
	public string Id; //Field offset: 0x58
	public bool Enabled; //Field offset: 0x60
	public bool NeedsFuel; //Field offset: 0x61
	public bool CraftGivesExp; //Field offset: 0x62
	public bool TakeFromSlotLocked; //Field offset: 0x63
	public EAreaType Type; //Field offset: 0x64
	public bool DisplayLevel; //Field offset: 0x68
	public string ParentAreaId; //Field offset: 0x70
	public float stashGridStep; //Field offset: 0x78
	[JsonIgnore]
	public AreaBehaviour AreaBehaviour; //Field offset: 0x80
	[JsonIgnore]
	public Sprite AreaIcon; //Field offset: 0x88
	[JsonIgnore]
	public int CameraTimePosition; //Field offset: 0x90
	[JsonIgnore]
	public bool IsElite; //Field offset: 0x94
	[JsonIgnore]
	public readonly Dictionary PowerDelays; //Field offset: 0x98
	[JsonIgnore]
	public Dictionary DefaultSounds; //Field offset: 0xA0
	[HideInInspector]
	public RelatedRequirements Requirements; //Field offset: 0xA8
	public Dictionary Stages; //Field offset: 0xB0

	public int MaxLevel
	{
		 get { } //Length: 91
	}

	public string Name
	{
		 get { } //Length: 10
	}

	public AreaTemplate() { }

	public int get_MaxLevel() { }

	public string get_Name() { }

	public void Init() { }

	public void UpdateData(AreaTemplate template) { }

}

