namespace Microsoft.Extensions.Logging;

[NullableContext(1)]
public interface ISupportExternalScope
{

	public void SetScopeProvider(IExternalScopeProvider scopeProvider) { }

}

