namespace EFT.InputSystem;

public sealed class InputSource
{
	private static readonly KeyCode[] ValidKeyCodes; //Field offset: 0x0
	private static readonly string[] ValidAxes; //Field offset: 0x8
	private static readonly Dictionary ForbiddenForAxisWithDefaultKey; //Field offset: 0x10
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public bool isAxis; //Field offset: 0x10
	public List keyCode; //Field offset: 0x18
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public string axisName; //Field offset: 0x20
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public bool positiveAxis; //Field offset: 0x28
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public float deadZone; //Field offset: 0x2C
	[DefaultValue(1)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public float sensitivity; //Field offset: 0x30

	[JsonIgnore]
	public bool IsEmpty
	{
		 get { } //Length: 93
	}

	private static InputSource() { }

	public InputSource() { }

	public void AddKey(KeyCode key) { }

	public bool Check(EGameKey gameKey) { }

	public InputSource Clone() { }

	public virtual bool Equals(object obj) { }

	public bool get_IsEmpty() { }

	public virtual int GetHashCode() { }

	public static EKeyPress Listen(ref InputSource inputSource, EGameKey gameKey) { }

	public void MoveControlButtonsToStart() { }

	public static InputSource NewKeyInputSource(KeyCode[] keys) { }

	public string ToShortString() { }

	public virtual string ToString() { }

}

