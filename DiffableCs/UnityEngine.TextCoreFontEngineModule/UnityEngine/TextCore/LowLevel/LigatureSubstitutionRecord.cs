namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct LigatureSubstitutionRecord
{
	[NativeName("componentGlyphs")]
	[SerializeField]
	private uint[] m_ComponentGlyphIDs; //Field offset: 0x0
	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	public uint[] componentGlyphIDs
	{
		 get { } //Length: 6
	}

	public uint ligatureGlyphID
	{
		 get { } //Length: 6
	}

	public uint[] get_componentGlyphIDs() { }

	public uint get_ligatureGlyphID() { }

}

