namespace System.Security.Claims;

[ComVisible(True)]
public class ClaimsPrincipal : IPrincipal
{
	private static Func s_identitySelector; //Field offset: 0x0
	private static Func s_principalSelector; //Field offset: 0x8
	[OptionalField(VersionAdded = 2)]
	private string m_version; //Field offset: 0x10
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaimsIdentities; //Field offset: 0x18
	private List m_identities; //Field offset: 0x20

	public static Func ClaimsPrincipalSelector
	{
		 get { } //Length: 84
	}

	public override IIdentity Identity
	{
		 get { } //Length: 181
	}

	private static ClaimsPrincipal() { }

	public ClaimsPrincipal() { }

	protected ClaimsPrincipal(SerializationInfo info, StreamingContext context) { }

	private void Deserialize(SerializationInfo info, StreamingContext context) { }

	private void DeserializeIdentities(string identities) { }

	public static Func get_ClaimsPrincipalSelector() { }

	public override IIdentity get_Identity() { }

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnSerializing]
	private void OnSerializingMethod(StreamingContext context) { }

	private static ClaimsIdentity SelectPrimaryIdentity(IEnumerable identities) { }

	private string SerializeIdentities() { }

}

