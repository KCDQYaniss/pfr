namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
internal class CompositeExpression : QueryExpression
{
	[CompilerGenerated]
	private List <Expressions>k__BackingField; //Field offset: 0x18

	public List Expressions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CompositeExpression(QueryOperator operator) { }

	[CompilerGenerated]
	public List get_Expressions() { }

	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	[CompilerGenerated]
	public void set_Expressions(List value) { }

}

