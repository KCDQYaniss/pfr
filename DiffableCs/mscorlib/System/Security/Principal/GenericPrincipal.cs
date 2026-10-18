namespace System.Security.Principal;

[ComVisible(True)]
public class GenericPrincipal : ClaimsPrincipal
{
	private IIdentity m_identity; //Field offset: 0x28
	private string[] m_roles; //Field offset: 0x30

	public virtual IIdentity Identity
	{
		 get { } //Length: 5
	}

	public GenericPrincipal(IIdentity identity, string[] roles) { }

	public virtual IIdentity get_Identity() { }

}

