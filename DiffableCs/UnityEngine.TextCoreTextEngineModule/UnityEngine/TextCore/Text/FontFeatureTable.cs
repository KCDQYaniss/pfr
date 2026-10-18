namespace UnityEngine.TextCore.Text;

public class FontFeatureTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8
		public static Func <>9__25_1; //Field offset: 0x10
		public static Func <>9__26_0; //Field offset: 0x18
		public static Func <>9__26_1; //Field offset: 0x20
		public static Func <>9__27_0; //Field offset: 0x28
		public static Func <>9__27_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

		internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

		internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

		internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

		internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

		internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }

	}

	[SerializeField]
	internal List m_MultipleSubstitutionRecords; //Field offset: 0x10
	[SerializeField]
	internal List m_LigatureSubstitutionRecords; //Field offset: 0x18
	[SerializeField]
	internal List m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[SerializeField]
	internal List m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[SerializeField]
	internal List m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	internal Dictionary m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	internal Dictionary m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	internal Dictionary m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	internal Dictionary m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	internal FontFeatureTable() { }

	public void SortGlyphPairAdjustmentRecords() { }

	public void SortMarkToBaseAdjustmentRecords() { }

	public void SortMarkToMarkAdjustmentRecords() { }

}

