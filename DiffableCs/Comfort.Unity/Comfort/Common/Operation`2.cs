namespace Comfort.Common;

public class Operation`2 : AbstractOperation, IOperation, IOperation, IEnumerator
{
	private Result ; //Field offset: 0x0

	public virtual bool Completed
	{
		 get { } //Length: 24
	}

	public virtual string Error
	{
		 get { } //Length: 5
		 set { } //Length: 376
	}

	public virtual bool Failed
	{
		 get { } //Length: 56
	}

	public override Result Result
	{
		 get { } //Length: 19
		 set { } //Length: 285
	}

	public virtual bool Succeed
	{
		 get { } //Length: 24
		 set { } //Length: 101
	}

	public Operation`2() { }

	public Operation`2(T0 result0, T1 result1) { }

	public Operation`2(ref Result result) { }

	public virtual bool get_Completed() { }

	public virtual string get_Error() { }

	public virtual bool get_Failed() { }

	public override Result get_Result() { }

	public virtual bool get_Succeed() { }

	public static Result op_Implicit(Operation operation) { }

	protected virtual void set_Error(string value) { }

	protected void set_Result(Result value) { }

	protected virtual void set_Succeed(bool value) { }

}

