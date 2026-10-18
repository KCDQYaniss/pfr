namespace EFT.InventoryLogic;

public class Stash : CompoundItem
{
	private sealed class StashGrid : Grid
	{
		private readonly Stash _stash; //Field offset: 0x78
		private readonly bool _verticalStretchBackup; //Field offset: 0x80
		private bool _canStretchVertically; //Field offset: 0x81

		public virtual bool CanStretchVertically
		{
			 get { } //Length: 8
		}

		public StashGrid(Grid grid, Stash parentItem) { }

		protected virtual OperationResult AddInternal(Item item, LocationInGrid location, bool simulate, bool ignoreRestrictions) { }

		public void Expand(int newHeight) { }

		public virtual bool get_CanStretchVertically() { }

	}

	public const string STASH_ITEM_ID = "hideout"; //Field offset: 0x0
	public const string STASH_TEMPLATE_ID = "566abbc34bdc2d92178b4576"; //Field offset: 0x0
	private StashTemplate _stashTemplate; //Field offset: 0x90
	private readonly StashGrid _grid; //Field offset: 0x98
	private bool _finalized; //Field offset: 0xA0

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public Grid Grid
	{
		 get { } //Length: 39
	}

	public virtual bool IsContainer
	{
		 get { } //Length: 3
	}

	public virtual ItemTemplate Template
	{
		 get { } //Length: 17
	}

	public Stash(string id, StashTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

	public Grid get_Grid() { }

	public virtual bool get_IsContainer() { }

	public virtual ItemTemplate get_Template() { }

	public void OnDeserialized() { }

	public void UpdateBonuses(BonusController bonusController) { }

}

