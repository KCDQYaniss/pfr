namespace EFT.Quests;

public sealed class HideoutCustomizationOffersBook : ConditionalBook, IDisposable
{
	private IEnumerable _offers; //Field offset: 0x88

	public HideoutCustomizationOffersBook(IEnumerable offers, string profileId, EPlayerSide profileGroup) { }

	public virtual void Dispose() { }

	public virtual void LoadAll() { }

	public virtual void RemoveConditionalsWithoutTemplate() { }

}

