namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheetFactory
{
	private readonly Dictionary m_Sheets; //Field offset: 0x10

	public PropertySheetFactory() { }

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	public PropertySheet Get(string shaderName) { }

	public PropertySheet Get(Shader shader) { }

	public void Release() { }

}

