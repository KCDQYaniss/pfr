namespace EFT.UI;

public interface ISetNicknameScreenController
{

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

	public string ReservedNickname
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnNicknameError(Action value) { }

	[CompilerGenerated]
	public void add_OnNickNameSubmitted(Action value) { }

	public string get_ReservedNickname() { }

	[CompilerGenerated]
	public void remove_OnNicknameError(Action value) { }

	[CompilerGenerated]
	public void remove_OnNickNameSubmitted(Action value) { }

	public void ShowNicknameError(ENicknameError error) { }

	public void ShowScreen(EScreenState state) { }

	public void SubmitNickname(string reservedNickname) { }

}

