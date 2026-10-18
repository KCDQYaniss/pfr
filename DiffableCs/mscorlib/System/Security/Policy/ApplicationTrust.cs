namespace System.Security.Policy;

[ComVisible(True)]
public sealed class ApplicationTrust : EvidenceBase, ISecurityEncodable
{
	private ApplicationIdentity _appid; //Field offset: 0x10
	private PolicyStatement _defaultPolicy; //Field offset: 0x18
	private object _xtranfo; //Field offset: 0x20
	private bool _trustrun; //Field offset: 0x28
	private bool _persist; //Field offset: 0x29
	private IList fullTrustAssemblies; //Field offset: 0x30

	public PolicyStatement DefaultGrantSet
	{
		 get { } //Length: 376
	}

	public ApplicationTrust() { }

	public PolicyStatement get_DefaultGrantSet() { }

	private PolicyStatement GetDefaultGrantSet() { }

	public override SecurityElement ToXml() { }

}

