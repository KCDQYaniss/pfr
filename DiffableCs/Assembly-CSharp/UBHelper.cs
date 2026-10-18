//Type is in global namespace

public class UBHelper : MonoBehaviour
{
	private class Styles
	{
		public GUIStyle header; //Field offset: 0x10
		public GUIStyle headerArrow; //Field offset: 0x18
		private RectOffset m_Border; //Field offset: 0x20
		private float m_FixedHeight; //Field offset: 0x28
		private Vector2 m_ContentOffset; //Field offset: 0x2C
		private TextAnchor m_TextAlign; //Field offset: 0x34
		private FontStyle m_TextStyle; //Field offset: 0x38
		private int m_FontSize; //Field offset: 0x3C

		internal Styles() { }

		public void Apply() { }

		public void Backup() { }

		public void Revert() { }

	}

	private static Styles s_Styles; //Field offset: 0x0

	private static UBHelper() { }

	public UBHelper() { }

	public static bool GroupHeader(string text, bool isExpanded) { }

}

