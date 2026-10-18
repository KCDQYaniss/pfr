namespace JBooth.MicroSplat;

public class MicroSplatKeywords : ScriptableObject
{
	public List keywords; //Field offset: 0x18

	public MicroSplatKeywords() { }

	public void DisableKeyword(string k) { }

	public void EnableKeyword(string k) { }

	public bool IsKeywordEnabled(string k) { }

}

