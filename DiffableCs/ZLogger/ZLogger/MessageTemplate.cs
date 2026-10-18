namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct MessageTemplate
{
	private readonly MessageTemplateHolder template; //Field offset: 0x0
	private readonly IBufferWriter writer; //Field offset: 0x8

	internal MessageTemplate(MessageTemplateHolder template, IBufferWriter writer) { }

	private static void AppendFormatted(ref Utf8StringWriter writer, ref T value, ref MessageTemplateChunk chunk) { }

	private static void AppendLogCategory(ref Utf8StringWriter writer, ref LogCategory value, ref MessageTemplateChunk chunk) { }

	private static void AppendLogLevel(ref Utf8StringWriter writer, ref LogLevel value, ref MessageTemplateChunk chunk) { }

	private static void AppendTimestamp(ref Utf8StringWriter writer, ref Timestamp value, ref MessageTemplateChunk chunk) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	public void Format() { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2) { }

	public void Format(T0 arg0, T1 arg1) { }

	public void Format(T0 arg0) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	public void Format(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

}

