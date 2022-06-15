namespace Helium.Network.Api.Vanilla;
using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Helium.Api.Mojang;

/*
 * I am pushing what I got, sorry this task was a bit to hard for me ;-;
 * 
 * 
 */
public ref struct PacketReader
{
	public ReadOnlySequence<Byte> Buffer { get; set; } = ReadOnlySequence<byte>.Empty;

	public Int32 Offest { get; set; } = 0;

	private PipeReader Reader { get; set; }

	public PacketReader(PipeReader reader)
	{
		Reader = reader;
	}

	public Double ReadDouble(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadDoubleBigEndian(source);
	}

	public ValueTask<Double> ReadDoubleAsync(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadDouble(source));
	}

	public Half ReadHalf(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadHalfBigEndian(source);
	}

	public ValueTask<Half> ReadHalfAsync(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadHalf(source));
	}

	public Int16 ReadInt16(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadInt16BigEndian(source);
	}

	public ValueTask<Int16> ReadInt16Aysnc(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadInt16(source));
	}

	public Int32 ReadInt32(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadInt32BigEndian(source);
	}

	public ValueTask<Int32> ReadInt32Async(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadInt32(source));
	}

	public Int64 ReadInt64(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadInt64BigEndian(source);
	}

	public ValueTask<Int64> ReadInt64Async(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadInt64(source));
	}

	public Single ReadSingle(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadSingleBigEndian(source);
	}

	public ValueTask<Single> ReadSingleAsync(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadSingle(source));
	}

	public UInt16 ReadUInt16(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadUInt16BigEndian(source);
	}

	public ValueTask<UInt16> ReadUInt16Async(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadUInt16(source));
	}

	public UInt32 ReadUInt32(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadUInt32BigEndian(source);
	}

	public ValueTask<UInt32> ReadUInt32Async(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadUInt32(source));
	}

	public UInt64 ReadUInt64(ReadOnlySpan<Byte> source)
	{
		return BinaryPrimitives.ReadUInt64BigEndian(source);
	}

	public ValueTask<UInt64> ReadUInt64Async(ReadOnlySpan<Byte> source)
	{
		return ValueTask.FromResult(this.ReadUInt64(source));
	}

	public Position ReadPosition()
	{
		ReadOnlySequence<Byte> val = this.Buffer.Slice(Offest, 8);

		return MemoryMarshal.Cast<Byte, Position>(val.FirstSpan)[0];
	}

}
