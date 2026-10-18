namespace ChatShared;

public class UpdatableFriendsInvitation : IUpdatable
{
	public string _id; //Field offset: 0x10
	public UpdatableChatMember From; //Field offset: 0x18
	public UpdatableChatMember To; //Field offset: 0x20
	public double Date; //Field offset: 0x28
	public UpdatableChatMember Profile; //Field offset: 0x30
	public bool InputInvitation; //Field offset: 0x38

	public UpdatableFriendsInvitation() { }

	public UpdatableFriendsInvitation(FriendsInvitation invitation, bool input) { }

	public override bool Compare(UpdatableFriendsInvitation other) { }

	public override void UpdateFromAnotherItem(UpdatableFriendsInvitation other) { }

}

