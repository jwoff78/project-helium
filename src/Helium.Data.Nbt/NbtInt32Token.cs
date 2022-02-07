﻿namespace Helium.Data.Nbt;

using System;
using System.Runtime.Versioning;

using Helium.Data.Abstraction;

/// <summary>
/// Represents a signed int32 token.
/// </summary>
[RequiresPreviewFeatures]
public record struct NbtInt32Token : IValueToken<Int32>
{
	/// <summary>
	/// Stores the binary marker for this token type.
	/// </summary>
	public static Byte Declarator => 0x03;

	/// <summary>
	/// Stores the value of this token.
	/// </summary>
	public Int32 Value { get; set; }

	/// <summary>
	/// Provides an instance access field for this token type.
	/// </summary>
	public Byte RefDeclarator => Declarator;

	/// <summary>
	/// The name of this nbt token.
	/// </summary>
	public String Name { get; set; }

	/// <summary>
	/// The root token of this tree.
	/// </summary>
	public IRootToken? RootToken { get; set; }

	/// <summary>
	/// The immediate parent for this token.
	/// </summary>
	public IDataToken? ParentToken { get; set; }
}