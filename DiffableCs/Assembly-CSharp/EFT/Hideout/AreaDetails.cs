namespace EFT.Hideout;

public class AreaDetails : UIElement
{
	internal class DetailsDisplaySettings
	{
		public Sprite Icon; //Field offset: 0x10
		public Color BackgroundColor; //Field offset: 0x18

		public DetailsDisplaySettings() { }

	}

	[SerializeField]
	private DetailsPanel _importantDetailsPanel; //Field offset: 0x70
	[SerializeField]
	private DetailsPanel _regularDetailsPanelTemplate; //Field offset: 0x78
	[SerializeField]
	private Transform _detailsContainer; //Field offset: 0x80
	[SerializeField]
	private Dictionary _detailsSettings; //Field offset: 0x88
	private AreaDetailsData _importantDetails; //Field offset: 0x90
	private AreaDetailsGroup _regularDetails; //Field offset: 0x98
	private bool _showFuelDetails; //Field offset: 0xA0
	private bool _showOutOfFuel; //Field offset: 0xA1
	private AreaData _data; //Field offset: 0xA8
	private Action _levelUpdatedDisposable; //Field offset: 0xB0
	private readonly Dictionary _views; //Field offset: 0xB8

	private bool ImportantActiveness
	{
		private get { } //Length: 79
	}

	public AreaDetails() { }

	[CompilerGenerated]
	private void <SetImportantDetails>b__15_0(bool silent) { }

	private void AddSingleDetailsPanel(AreaDetailsData detailsData) { }

	private void AreaLevelUpdated() { }

	private void CheckShowImportantDetails() { }

	public virtual void Close() { }

	private bool get_ImportantActiveness() { }

	private void ImportantDetailsChangedHandler(AreaDetailsData datails, AreaDetailsCache oldData) { }

	private void RegularDetailsChangedHandler(AreaDetailsGroup group, AreaDetailsData detailsData, AreaDetailsCache oldData, EDetailsChangeType changeType) { }

	private void SetActiveness(DetailsPanel view, bool value) { }

	private void SetData(DetailsPanel detailsPanel, AreaDetailsData detailsData, AreaDetailsCache oldData, bool force) { }

	private void SetImportantDetails() { }

	private void SetRegularDetails() { }

	private void SetRegularDetailsData(DetailsPanel view, AreaDetailsData datails, AreaDetailsCache oldData, bool force) { }

	public void Show(AreaData data) { }

}

