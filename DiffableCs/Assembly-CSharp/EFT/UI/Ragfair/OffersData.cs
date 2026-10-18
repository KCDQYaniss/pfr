namespace EFT.UI.Ragfair;

[IsReadOnly]
public struct OffersData
{
	public readonly int Count; //Field offset: 0x0
	public readonly string SelectedCategory; //Field offset: 0x8
	public readonly EUpdatePagesStatus UpdatePagesStatus; //Field offset: 0x10

	public OffersData(EUpdatePagesStatus updatePagesStatus) { }

	public OffersData(EUpdatePagesStatus updatePagesStatus, string category) { }

	public OffersData(int count, string category) { }

}

