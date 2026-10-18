namespace TMPro;

public class TMP_FontFeatureTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

		internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

	}

	[SerializeField]
	internal List m_GlyphPairAdjustmentRecords; //Field offset: 0x10
	internal Dictionary m_GlyphPairAdjustmentRecordLookupDictionary; //Field offset: 0x18

	public List glyphPairAdjustmentRecords
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public TMP_FontFeatureTable() { }

	public List get_glyphPairAdjustmentRecords() { }

	public void set_glyphPairAdjustmentRecords(List value) { }

	public void SortGlyphPairAdjustmentRecords() { }

}

