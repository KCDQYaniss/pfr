namespace EFT.WeaponMounting.Debug.View.Pages;

public sealed class MountingPageViewer
{
	private readonly Player _player; //Field offset: 0x10
	private readonly IWeaponMountingComponent _debugMountingComponent; //Field offset: 0x18
	[CompilerGenerated]
	private IMountingPage <StartPage>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private IMountingPage <GridOptionsPage>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IMountingPage <RecoilAndStaminaPage>k__BackingField; //Field offset: 0x30
	private IMountingPage _currentPage; //Field offset: 0x38

	public private IMountingPage GridOptionsPage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IMountingPage RecoilAndStaminaPage
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IMountingPage StartPage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MountingPageViewer(Player player) { }

	[CompilerGenerated]
	public IMountingPage get_GridOptionsPage() { }

	[CompilerGenerated]
	public IMountingPage get_RecoilAndStaminaPage() { }

	[CompilerGenerated]
	public IMountingPage get_StartPage() { }

	private void InitializePages() { }

	[CompilerGenerated]
	private void set_GridOptionsPage(IMountingPage value) { }

	[CompilerGenerated]
	private void set_RecoilAndStaminaPage(IMountingPage value) { }

	[CompilerGenerated]
	private void set_StartPage(IMountingPage value) { }

	public void SetAsCurrent(IMountingPage page) { }

	public void Update() { }

}

