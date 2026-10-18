namespace System;

internal class TermInfoReader
{
	private int boolSize; //Field offset: 0x10
	private int numSize; //Field offset: 0x14
	private int strOffsets; //Field offset: 0x18
	private byte[] buffer; //Field offset: 0x20
	private int booleansOffset; //Field offset: 0x28
	private int intOffset; //Field offset: 0x2C

	public TermInfoReader(string term, string filename) { }

	public TermInfoReader(string term, byte[] buffer) { }

	private void DetermineVersion(short magic) { }

	public int Get(TermInfoNumbers number) { }

	public string Get(TermInfoStrings tstr) { }

	private short GetInt16(byte[] buffer, int offset) { }

	private string GetString(byte[] buffer, int offset) { }

	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	private byte[] GetStringBytes(byte[] buffer, int offset) { }

	private void ReadHeader(byte[] buffer, ref int position) { }

	private void ReadNames(byte[] buffer, ref int position) { }

}

