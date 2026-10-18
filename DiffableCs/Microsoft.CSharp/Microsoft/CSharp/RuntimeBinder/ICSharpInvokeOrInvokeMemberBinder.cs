namespace Microsoft.CSharp.RuntimeBinder;

internal interface ICSharpInvokeOrInvokeMemberBinder : ICSharpBinder
{

	public CSharpCallFlags Flags
	{
		 get { } //Length: 0
	}

	public bool ResultDiscarded
	{
		 get { } //Length: 0
	}

	public bool StaticCall
	{
		 get { } //Length: 0
	}

	public Type[] TypeArguments
	{
		 get { } //Length: 0
	}

	public CSharpCallFlags get_Flags() { }

	public bool get_ResultDiscarded() { }

	public bool get_StaticCall() { }

	public Type[] get_TypeArguments() { }

}

