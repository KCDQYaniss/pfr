namespace Comfort.Common;

public class Operation`5 : AbstractOperation, IOperation, IOperation, IEnumerator
{
	private Result ; //Field offset: 0x0

	public virtual bool Completed
	{
		 get { } //Length: 83
	}

	public virtual string Error
	{
		 get { } //Length: 89
		 set { } //Length: 937
	}

	public virtual bool Failed
	{
		 get { } //Length: 89
	}

	public override Result Result
	{
		 get { } //Length: 172
		 set { } //Length: 510
	}

	public virtual bool Succeed
	{
		 get { } //Length: 83
		 set { } //Length: 101
	}

	public Operation`5() { }

	public Operation`5(T0 value0, T1 value1, T2 value2, T3 value3, T4 value4) { }

	public Operation`5(ref Result result) { }

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

