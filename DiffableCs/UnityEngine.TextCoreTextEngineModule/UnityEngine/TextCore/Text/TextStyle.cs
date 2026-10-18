namespace UnityEngine.TextCore.Text;

public class TextStyle
{
	internal static TextStyle k_NormalStyle; //Field offset: 0x0
	[SerializeField]
	private string m_Name; //Field offset: 0x10
	[SerializeField]
	private int m_HashCode; //Field offset: 0x18
	[SerializeField]
	private string m_OpeningDefinition; //Field offset: 0x20
	[SerializeField]
	private string m_ClosingDefinition; //Field offset: 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; //Field offset: 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; //Field offset: 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; //Field offset: 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; //Field offset: 0x48

	public int hashCode
	{
		 get { } //Length: 6
	}

	public uint[] styleClosingTagArray
	{
		 get { } //Length: 7
	}

	public uint[] styleOpeningTagArray
	{
		 get { } //Length: 7
	}

	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	public int get_hashCode() { }

	public uint[] get_styleClosingTagArray() { }

	public uint[] get_styleOpeningTagArray() { }

	public void RefreshStyle() { }

}

