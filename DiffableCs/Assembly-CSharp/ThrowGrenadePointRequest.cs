//Type is in global namespace

public class ThrowGrenadePointRequest : ThrowGrenadeRequest
{
	private static List angsToTestStub; //Field offset: 0x0
	private readonly Vector3 _placeToThrow; //Field offset: 0x88
	private readonly Nullable _throwType; //Field offset: 0x94

	public virtual Vector3 PlaceToThrow
	{
		 get { } //Length: 44
	}

	private static ThrowGrenadePointRequest() { }

	public ThrowGrenadePointRequest(IPlayer requester, Vector3 placeToThrow, Nullable throwType = null) { }

	public ThrowGrenadePointRequest(IPlayer requester, AIGreanageThrowData throwData) { }

	public virtual Vector3 get_PlaceToThrow() { }

	public static AIGreanageThrowData GetThrowTraectory(Vector3 placeToThrow, BotOwner executor, Nullable throwType, Nullable fromThrowPlace, List angsToTest = null) { }

	public virtual void Take(BotOwner executor) { }

}

