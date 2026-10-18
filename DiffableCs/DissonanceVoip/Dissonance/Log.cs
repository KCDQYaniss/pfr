namespace Dissonance;

public class Log
{
	private readonly string _traceFormat; //Field offset: 0x10
	private readonly string _debugFormat; //Field offset: 0x18
	private readonly string _basicFormat; //Field offset: 0x20
	private readonly int _category; //Field offset: 0x28

	public bool IsDebug
	{
		 get { } //Length: 13
	}

	public bool IsError
	{
		 get { } //Length: 13
	}

	public bool IsInfo
	{
		 get { } //Length: 13
	}

	public bool IsTrace
	{
		 get { } //Length: 10
	}

	public bool IsWarn
	{
		 get { } //Length: 13
	}

	internal Log(int category, string name) { }

	[ContractAnnotation("assertion:true => false; assertion:false => true")]
	public bool AssertAndLogError(bool assertion, string guid, string format, TA arg0, TB arg1) { }

	[ContractAnnotation("assertion:true => false; assertion:false => true")]
	public bool AssertAndLogError(bool assertion, string guid, string format, TA arg0) { }

	[ContractAnnotation("assertion:true => false; assertion:false => true")]
	public bool AssertAndLogError(bool assertion, string guid, string msg) { }

	[ContractAnnotation("assertion:true => false; assertion:false => true")]
	public bool AssertAndLogWarn(bool assertion, string format, TA arg0) { }

	[ContractAnnotation("assertion:true => false; assertion:false => true")]
	public bool AssertAndLogWarn(bool assertion, string msg) { }

	[ContractAnnotation("assertion:false => halt")]
	public void AssertAndThrowPossibleBug(bool assertion, string guid, string format, TA arg0) { }

	[ContractAnnotation("assertion:false => halt")]
	public void AssertAndThrowPossibleBug(bool assertion, string guid, string msg) { }

	[ContractAnnotation("assertion:false => halt")]
	public void AssertAndThrowPossibleBug(bool assertion, string guid, string format, TA arg0, TB arg1) { }

	[ContractAnnotation("assertion:false => halt")]
	public void AssertAndThrowPossibleBug(bool assertion, string guid, string format, TA arg0, TB arg1, TC arg2) { }

	[DebuggerHidden]
	[NotNull]
	public Exception CreatePossibleBugException(Func factory, string problem, string guid) { }

	[DebuggerHidden]
	[NotNull]
	public DissonanceException CreatePossibleBugException(string problem, string guid) { }

	[DebuggerHidden]
	[NotNull]
	public DissonanceException CreateUserErrorException(string problem, string likelyCause, string documentationLink, string guid) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5, TG p6, TH p7) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5, TG p6) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string message) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2, TD p3, TE p4) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Debug(string format, TA p0, TB p1, TC p2, TD p3) { }

	[DebuggerHidden]
	public void Error(string format, TA p0, TB p1) { }

	[DebuggerHidden]
	public void Error(string format, TA p0, TB p1, TC p2) { }

	[DebuggerHidden]
	public void Error(string message) { }

	[DebuggerHidden]
	public void Error(string format, TA p0) { }

	public bool get_IsDebug() { }

	public bool get_IsError() { }

	public bool get_IsInfo() { }

	public bool get_IsTrace() { }

	public bool get_IsWarn() { }

	[DebuggerHidden]
	public void Info(string format, TA p0, TB p1, TC p2, TD p3, TE p4) { }

	[DebuggerHidden]
	public void Info(string message) { }

	[DebuggerHidden]
	public void Info(string format, TA p0) { }

	[DebuggerHidden]
	public void Info(string format, TA p0, TB p1, TC p2, TD p3) { }

	[DebuggerHidden]
	public void Info(string format, TA p0, TB p1, TC p2) { }

	[DebuggerHidden]
	public void Info(string format, TA p0, TB p1) { }

	[DebuggerHidden]
	[NotNull]
	public string PossibleBugMessage(string problem, string guid) { }

	[DebuggerHidden]
	private bool ShouldLog(LogLevel level) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Trace(string message) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Trace(string format, TA p0) { }

	[Conditional("DEBUG")]
	[DebuggerHidden]
	public void Trace(string format, TA p0, TB p1) { }

	[DebuggerHidden]
	[NotNull]
	public string UserErrorMessage(string problem, string likelyCause, string documentationLink, string guid) { }

	[DebuggerHidden]
	public void Warn(string format, TA p0, TB p1, TC p2, TD p3, TE p4) { }

	[DebuggerHidden]
	public void Warn(string format, TA p0, TB p1, TC p2, TD p3) { }

	[DebuggerHidden]
	public void Warn(string format, TA p0, TB p1, TC p2) { }

	[DebuggerHidden]
	public void Warn(string format, TA p0, TB p1) { }

	[DebuggerHidden]
	public void Warn(string format, TA p0) { }

	[DebuggerHidden]
	public void Warn(string message) { }

	[DebuggerHidden]
	private void WriteLog(LogLevel level, string message) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2, TD p3) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2, TD p3, TE p4) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5, TG p6, TH p7) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2, TD p3, TE p4, TF p5, TG p6) { }

	[DebuggerHidden]
	private void WriteLogFormat(LogLevel level, string format, TA p0, TB p1, TC p2) { }

}

