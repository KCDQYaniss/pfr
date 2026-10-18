namespace System;

[DefaultMember("Chars")]
public sealed class string : IComparable, IEnumerable, IEnumerable, IComparable, IEquatable, IConvertible, ICloneable
{
	private struct ProbabilisticMap
	{

	}

	private enum TrimType
	{
		Head = 0,
		Tail = 1,
		Both = 2,
	}

	private const int StackallocIntBufferSizeLimit = 128; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7; //Field offset: 0x0
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3; //Field offset: 0x0
	private const int PROBABILISTICMAP_SIZE = 8; //Field offset: 0x0
	public static readonly string Empty; //Field offset: 0x0
	private int _stringLength; //Field offset: 0x10
	private char _firstChar; //Field offset: 0x14

	public char Chars
	{
		[Intrinsic]
		 get { } //Length: 35
	}

	public int Length
	{
		 get { } //Length: 164
	}

	public string(char[] value, int startIndex, int length) { }

	public string(ReadOnlySpan value) { }

	public string(char c, int count) { }

	[CLSCompliant(False)]
	public string(sbyte* value, int startIndex, int length, Encoding enc) { }

	[CLSCompliant(False)]
	public string(sbyte* value, int startIndex, int length) { }

	[CLSCompliant(False)]
	public string(char* value, int startIndex, int length) { }

	[CLSCompliant(False)]
	public string(char* value) { }

	public string(char[] value) { }

	private static bool ArrayContains(char searchChar, char[] anyOf) { }

	internal static void bzero(byte* dest, int len) { }

	internal static void bzero_aligned_1(byte* dest, int len) { }

	internal static void bzero_aligned_2(byte* dest, int len) { }

	internal static void bzero_aligned_4(byte* dest, int len) { }

	internal static void bzero_aligned_8(byte* dest, int len) { }

	internal static void CheckStringComparison(StringComparison comparisonType) { }

	public override object Clone() { }

	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, string strB) { }

	public static int Compare(string strA, string strB, bool ignoreCase) { }

	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	public static int CompareOrdinal(string strA, string strB) { }

	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	internal static int CompareOrdinal(ReadOnlySpan strA, ReadOnlySpan strB) { }

	private static int CompareOrdinalHelper(string strA, string strB) { }

	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	public override int CompareTo(string strB) { }

	public override int CompareTo(object value) { }

	public static string Concat(IEnumerable values) { }

	public static string Concat(object arg0, object arg1, object arg2) { }

	public static string Concat(string str0, string str1, string str2, string str3) { }

	public static string Concat(object[] args) { }

	public static string Concat(IEnumerable values) { }

	public static string Concat(object arg0, object arg1) { }

	public static string Concat(string[] values) { }

	[CLSCompliant(False)]
	public static string Concat(object arg0, object arg1, object arg2, object arg3) { }

	public static string Concat(string str0, string str1) { }

	public static string Concat(object arg0) { }

	public static string Concat(string str0, string str1, string str2) { }

	public bool Contains(char value, StringComparison comparisonType) { }

	public bool Contains(char value) { }

	public bool Contains(string value, StringComparison comparisonType) { }

	public bool Contains(string value) { }

	public static string Copy(string str) { }

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	public static string Create(int length, TState state, SpanAction action) { }

	internal static string CreateFromChar(char c) { }

	private string CreateString(sbyte* value, int startIndex, int length) { }

	private string CreateString(char* value) { }

	private string CreateString(char* value, int startIndex, int length) { }

	private string CreateString(char[] val, int startIndex, int length) { }

	private string CreateString(char[] val) { }

	private string CreateString(char c, int count) { }

	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

	private string CreateString(ReadOnlySpan value) { }

	private static string CreateStringForSByteConstructor(byte* pb, int numBytes) { }

	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	private string CreateTrimmedString(int start, int end) { }

	private static string Ctor(char c, int count) { }

	private static string Ctor(char[] value) { }

	private static string Ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	private static string Ctor(char* ptr) { }

	private static string Ctor(char[] value, int startIndex, int length) { }

	private static string Ctor(sbyte* value, int startIndex, int length) { }

	private static string Ctor(ReadOnlySpan value) { }

	private static string Ctor(char* ptr, int startIndex, int length) { }

	public bool EndsWith(char value) { }

	public bool EndsWith(string value, bool ignoreCase, CultureInfo culture) { }

	public bool EndsWith(string value, StringComparison comparisonType) { }

	public bool EndsWith(string value) { }

	public bool Equals(string value, StringComparison comparisonType) { }

	public static bool Equals(string a, string b) { }

	public override bool Equals(string value) { }

	public virtual bool Equals(object obj) { }

	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	private static bool EqualsHelper(string strA, string strB) { }

	internal static string FastAllocateString(int length) { }

	private static void FillStringChecked(string dest, int destPos, string src) { }

	public static string Format(IFormatProvider provider, string format, object[] args) { }

	public static string Format(string format, object[] args) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	public static string Format(IFormatProvider provider, string format, object arg0) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	public static string Format(string format, object arg0, object arg1, object arg2) { }

	public static string Format(string format, object arg0) { }

	public static string Format(string format, object arg0, object arg1) { }

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[Intrinsic]
	public char get_Chars(int index) { }

	public int get_Length() { }

	public CharEnumerator GetEnumerator() { }

	public int GetHashCode(StringComparison comparisonType) { }

	public virtual int GetHashCode() { }

	internal int GetLegacyNonRandomizedHashCode() { }

	internal char GetRawStringData() { }

	public override TypeCode GetTypeCode() { }

	public int IndexOf(char value, int startIndex, int count) { }

	public int IndexOf(char value, StringComparison comparisonType) { }

	public int IndexOf(char value, int startIndex) { }

	public int IndexOf(char value) { }

	public int IndexOf(string value) { }

	public int IndexOf(string value, int startIndex) { }

	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	public int IndexOf(string value, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex, int count) { }

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	public int IndexOfAny(char[] anyOf, int startIndex) { }

	public int IndexOfAny(char[] anyOf) { }

	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	private int IndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	private static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan anyOf) { }

	public string Insert(int startIndex, string value) { }

	public static string Intern(string str) { }

	private static string InternalIntern(string str) { }

	private static string InternalIsInterned(string str) { }

	private string InternalSubString(int startIndex, int length) { }

	private static bool IsCharBitSet(uint* charMap, byte value) { }

	public static string IsInterned(string str) { }

	public bool IsNormalized(NormalizationForm normalizationForm) { }

	public bool IsNormalized() { }

	[NonVersionable]
	public static bool IsNullOrEmpty(string value) { }

	public static bool IsNullOrWhiteSpace(string value) { }

	public static string Join(char separator, string[] value) { }

	public static string Join(char separator, object[] values) { }

	public static string Join(char separator, IEnumerable values) { }

	public static string Join(char separator, string[] value, int startIndex, int count) { }

	public static string Join(string separator, string[] value) { }

	public static string Join(string separator, object[] values) { }

	public static string Join(string separator, IEnumerable values) { }

	public static string Join(string separator, IEnumerable values) { }

	public static string Join(string separator, string[] value, int startIndex, int count) { }

	private static string JoinCore(char* separator, int separatorLength, IEnumerable values) { }

	private static string JoinCore(char* separator, int separatorLength, object[] values) { }

	private static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count) { }

	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType) { }

	public int LastIndexOf(char value) { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LastIndexOf(char value, int startIndex, int count) { }

	public int LastIndexOf(string value) { }

	public int LastIndexOf(string value, int startIndex) { }

	public int LastIndexOf(string value, int startIndex, int count) { }

	public int LastIndexOf(string value, StringComparison comparisonType) { }

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int LastIndexOfAny(char[] anyOf) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	private void MakeSeparatorList(string separator, ref ValueListBuilder sepListBuilder) { }

	private void MakeSeparatorList(string[] separators, ref ValueListBuilder sepListBuilder, ref ValueListBuilder lengthListBuilder) { }

	private void MakeSeparatorList(ReadOnlySpan separators, ref ValueListBuilder sepListBuilder) { }

	private static void memcpy(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	private static void memset(byte* dest, int val, int len) { }

	public string Normalize() { }

	public string Normalize(NormalizationForm normalizationForm) { }

	public static bool op_Equality(string a, string b) { }

	public static ReadOnlySpan op_Implicit(string value) { }

	public static bool op_Inequality(string a, string b) { }

	public string PadLeft(int totalWidth, char paddingChar) { }

	public string PadLeft(int totalWidth) { }

	public string PadRight(int totalWidth) { }

	public string PadRight(int totalWidth, char paddingChar) { }

	public string Remove(int startIndex, int count) { }

	public string Remove(int startIndex) { }

	public string Replace(string oldValue, string newValue) { }

	public string Replace(string oldValue, string newValue, StringComparison comparisonType) { }

	public string Replace(string oldValue, string newValue, bool ignoreCase, CultureInfo culture) { }

	public string Replace(char oldChar, char newChar) { }

	private string ReplaceCore(string oldValue, string newValue, CultureInfo culture, CompareOptions options) { }

	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan indices) { }

	private static void SetCharBit(uint* charMap, byte value) { }

	public string[] Split(string separator, StringSplitOptions options = 0) { }

	public string[] Split(char[] separator, int count, StringSplitOptions options) { }

	public string[] Split(string separator, int count, StringSplitOptions options = 0) { }

	public string[] Split(string[] separator, StringSplitOptions options) { }

	public string[] Split(char separator, StringSplitOptions options = 0) { }

	public string[] Split(char separator, int count, StringSplitOptions options = 0) { }

	public string[] Split(char[] separator) { }

	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	public string[] Split(char[] separator, StringSplitOptions options) { }

	public string[] Split(char[] separator, int count) { }

	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options) { }

	private string[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	private string[] SplitInternal(ReadOnlySpan separators, int count, StringSplitOptions options) { }

	private string[] SplitKeepEmptyEntries(ReadOnlySpan sepList, ReadOnlySpan lengthList, int defaultLength, int count) { }

	private string[] SplitOmitEmptyEntries(ReadOnlySpan sepList, ReadOnlySpan lengthList, int defaultLength, int count) { }

	public bool StartsWith(string value) { }

	public bool StartsWith(char value) { }

	public bool StartsWith(string value, bool ignoreCase, CultureInfo culture) { }

	public bool StartsWith(string value, StringComparison comparisonType) { }

	internal bool StartsWithOrdinalUnchecked(string value) { }

	public string Substring(int startIndex, int length) { }

	public string Substring(int startIndex) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	public char[] ToCharArray(int startIndex, int length) { }

	public char[] ToCharArray() { }

	public string ToLower() { }

	public string ToLower(CultureInfo culture) { }

	public string ToLowerInvariant() { }

	public virtual string ToString() { }

	public override string ToString(IFormatProvider provider) { }

	public string ToUpper() { }

	public string ToUpper(CultureInfo culture) { }

	public string ToUpperInvariant() { }

	public string Trim() { }

	public string Trim(char[] trimChars) { }

	public string Trim(char trimChar) { }

	public string TrimEnd() { }

	public string TrimEnd(char trimChar) { }

	public string TrimEnd(char[] trimChars) { }

	private string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType) { }

	public string TrimStart() { }

	public string TrimStart(char[] trimChars) { }

	public string TrimStart(char trimChar) { }

	private string TrimWhiteSpaceHelper(TrimType trimType) { }

	internal static int wcslen(char* ptr) { }

	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

}

