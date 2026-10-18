namespace EFT;

public interface ISocial : IProfileSession
{

	public ChatServerState[] ChatServers
	{
		 get { } //Length: 0
	}

	public ELinkedPlatform[] LinkedPlatforms
	{
		 get { } //Length: 0
	}

	public bool ReportAvailable
	{
		 get { } //Length: 0
	}

	public SocialNetwork SocialNetwork
	{
		 get { } //Length: 0
	}

	public Task AcceptAllFriendRequests() { }

	public void AcceptFriendRequest(string profileId, Callback callback) { }

	public void AllAttachmentsFromDialog(string dialogId, Callback callback) { }

	public Task CancelFriendRequest(string profileId) { }

	public void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback) { }

	public Task ChatDeleteAllMessages(string dialogId) { }

	public void ChatDeleteMessage(string dialogId, string messageId, Callback callback) { }

	public Task ChatGetDialogList(int limit, int offset) { }

	public void ChatGetDialogMessages(string id, int type, int limit, double time, Callback callback) { }

	public void ChatReadDialogues(string[] dialogs, Callback callback) { }

	public void ChatSendMessage(string id, int type, string text, string replyTo, Callback callback) { }

	public void DeclineFriendRequest(string profileId, Callback callback) { }

	public Task DeleteDialog(string dialogId) { }

	public void FindAccountByNickname(string nickname, Callback callback) { }

	public ChatServerState[] get_ChatServers() { }

	public ELinkedPlatform[] get_LinkedPlatforms() { }

	public bool get_ReportAvailable() { }

	public SocialNetwork get_SocialNetwork() { }

	public void GetChatServers(string versionId, Callback callback) { }

	public void GetDialogInformation(string dialogId, Callback callback) { }

	public Task GetFriendsList() { }

	public Task GetOtherPlayerProfile(string accountId) { }

	public void InviteToDialogue(string dialogId, string[] uid, Callback callback) { }

	public void LeaveChatDialogue(string dialogId, Callback callback) { }

	public void MutePlayer(string uid, Callback callback) { }

	public void PinDialog(string dialogId, Callback callback) { }

	public void PinFriend(string friendId, Callback callback) { }

	public bool PlayerAlreadyReported(string accountId, EReportType reportType) { }

	public Task RedeemProfileRewards(ChatMessageProfileEvent[] rewards) { }

	public void RemoveFromDialogue(string dialogId, string uid, Callback callback) { }

	public void RemoveFromFriendsList(string id, Callback callback) { }

	public void ReportNickname(string aId, Callback callback) { }

	public void SendFriendRequest(string id, Callback callback) { }

	public Task SyncPlatformFriends(ELinkedPlatform platform) { }

	public void TransferChatLeadership(string dialogId, string uid, Callback callback) { }

	public void UnmutePlayer(string uid, Callback callback) { }

	public void UnpinDialog(string dialogId, Callback callback) { }

	public void UnpinFriend(string friendId, Callback callback) { }

}

