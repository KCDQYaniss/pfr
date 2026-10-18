namespace EFT.UI;

public class CompoundTooltip : Tooltip
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__5_0; //Field offset: 0x8
		public static Action <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <CreateBlocks>b__5_0(CompoundTooltipHeader s) { }

		internal void <CreateBlocks>b__5_1(CompoundTooltipText s) { }

	}

	[SerializeField]
	private CompoundTooltipHeader _header; //Field offset: 0xA8
	[SerializeField]
	private CompoundTooltipText _bodyText; //Field offset: 0xB0
	private readonly List _headersList; //Field offset: 0xB8
	private readonly List _bodyTextList; //Field offset: 0xC0

	public CompoundTooltip() { }

	private void CreateBlocks(int blocksNeeded) { }

	private void FillRows(List textInfos) { }

	public void Show(List textInfos, float delay = 0, Nullable maxWidth = null) { }

}

