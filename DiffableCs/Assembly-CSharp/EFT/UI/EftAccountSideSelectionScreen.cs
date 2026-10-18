namespace EFT.UI;

public sealed class EftAccountSideSelectionScreen : AccountSideSelectionScreen
{
	internal sealed class EftAccountSideSelectionScreenController : EftSequenceScreenController, ISideSelectionScreenController
	{
		[CompilerGenerated]
		private Action OnBackRequested; //Field offset: 0x60
		[CompilerGenerated]
		private Action OnNickNameSubmitted; //Field offset: 0x68
		[CompilerGenerated]
		private Action OnNicknameError; //Field offset: 0x70
		[CompilerGenerated]
		private readonly Profile <BearProfile>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private readonly Profile <UsecProfile>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private readonly IClientSession <Session>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private readonly bool <CanCancel>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private readonly string <ReservedNickname>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		private readonly PreliminaryProfileData <ProfileData>k__BackingField; //Field offset: 0xA0

		public override event Action Closed
		{
			 add { } //Length: 77
			 remove { } //Length: 77
		}

		public override event Action OnBackRequested
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override event Action OnNicknameError
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnNickNameSubmitted
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override Profile BearProfile
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override bool CanCancel
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public override PreliminaryProfileData ProfileData
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override string ReservedNickname
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public override IClientSession Session
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override Profile UsecProfile
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public EftAccountSideSelectionScreenController(Profile bearProfile, Profile usecProfile, PreliminaryProfileData profileData, IClientSession session, bool canCancel, string reservedNickname) { }

		public override void add_Closed(Action value) { }

		[CompilerGenerated]
		public override void add_OnBackRequested(Action value) { }

		[CompilerGenerated]
		public override void add_OnNicknameError(Action value) { }

		[CompilerGenerated]
		public override void add_OnNickNameSubmitted(Action value) { }

		public override void BackRequested() { }

		[CompilerGenerated]
		public override Profile get_BearProfile() { }

		[CompilerGenerated]
		public override bool get_CanCancel() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public override PreliminaryProfileData get_ProfileData() { }

		[CompilerGenerated]
		public override string get_ReservedNickname() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public override IClientSession get_Session() { }

		[CompilerGenerated]
		public override Profile get_UsecProfile() { }

		public override void remove_Closed(Action value) { }

		[CompilerGenerated]
		public override void remove_OnBackRequested(Action value) { }

		[CompilerGenerated]
		public override void remove_OnNicknameError(Action value) { }

		[CompilerGenerated]
		public override void remove_OnNickNameSubmitted(Action value) { }

		public override void ShowNicknameError(ENicknameError error) { }

		public override void SubmitNickname(string nickname) { }

	}


	public EftAccountSideSelectionScreen() { }

}

