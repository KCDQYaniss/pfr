namespace System.Security.Policy;

[ComVisible(True)]
public sealed class PolicyStatement : ISecurityEncodable
{
	private PermissionSet perms; //Field offset: 0x10
	private PolicyStatementAttribute attrs; //Field offset: 0x18

	public PermissionSet PermissionSet
	{
		 get { } //Length: 189
	}

	public PolicyStatement(PermissionSet permSet) { }

	public PolicyStatement(PermissionSet permSet, PolicyStatementAttribute attributes) { }

	internal static PolicyStatement Empty() { }

	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	public PermissionSet get_PermissionSet() { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public override SecurityElement ToXml() { }

	public override SecurityElement ToXml(PolicyLevel level) { }

}

