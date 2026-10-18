namespace EFT.UI;

public interface ISideSelectionScreenController
{

	public event Action Closed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnBackRequested
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnNicknameError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnNickNameSubmitted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnShowNextScreen
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Profile BearProfile
	{
		 get { } //Length: 0
	}

	public bool CanCancel
	{
		 get { } //Length: 0
	}

	public PreliminaryProfileData ProfileData
	{
		 get { } //Length: 0
	}

	public string ReservedNickname
	{
		 get { } //Length: 0
	}

	public IClientSession Session
	{
		 get { } //Length: 0
	}

	public Profile UsecProfile
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Closed(Action value) { }

	[CompilerGenerated]
	public void add_OnBackRequested(Action value) { }

	[CompilerGenerated]
	public void add_OnNicknameError(Action value) { }

	[CompilerGenerated]
	public void add_OnNickNameSubmitted(Action value) { }

	[CompilerGenerated]
	public void add_OnShowNextScreen(Action value) { }

	public void BackRequested() { }

	public Profile get_BearProfile() { }

	public bool get_CanCancel() { }

	public PreliminaryProfileData get_ProfileData() { }

	public string get_ReservedNickname() { }

	public IClientSession get_Session() { }

	public Profile get_UsecProfile() { }

	[CompilerGenerated]
	public void remove_Closed(Action value) { }

	[CompilerGenerated]
	public void remove_OnBackRequested(Action value) { }

	[CompilerGenerated]
	public void remove_OnNicknameError(Action value) { }

	[CompilerGenerated]
	public void remove_OnNickNameSubmitted(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowNextScreen(Action value) { }

	public void ShowNextScreen() { }

	public void ShowNicknameError(ENicknameError error) { }

	public void ShowScreen(EScreenState state) { }

	public void SubmitNickname(string reservedNickname) { }

}

