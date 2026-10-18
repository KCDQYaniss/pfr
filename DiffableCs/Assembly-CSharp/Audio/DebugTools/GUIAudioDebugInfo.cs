namespace Audio.DebugTools;

public class GUIAudioDebugInfo
{
	public readonly GUIStyle Style; //Field offset: 0x10
	public readonly AudioSourceContainer Container; //Field offset: 0x18
	public bool Show; //Field offset: 0x20
	public bool DrawPropagationPath; //Field offset: 0x21
	public string Info; //Field offset: 0x28

	public GUIAudioDebugInfo(AudioSourceContainer container, GUIStyle style, bool drawPropagationPath = false, string info = "") { }

}

