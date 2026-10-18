//Type is in global namespace

public struct AICoreActionEnd
{
	public bool Value; //Field offset: 0x0
	public string Reason; //Field offset: 0x8

	public AICoreActionEnd(bool val = false) { }

	public AICoreActionEnd(string reason, bool val = true) { }

}

