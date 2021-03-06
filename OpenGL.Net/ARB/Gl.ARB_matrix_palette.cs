
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_MATRIX_PALETTE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_PALETTE_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_PALETTE_ARB = 0x8840;

		/// <summary>
		/// [GL] Value of GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;

		/// <summary>
		/// [GL] Value of GL_MAX_PALETTE_MATRICES_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_PALETTE_MATRICES_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MAX_PALETTE_MATRICES_ARB = 0x8842;

		/// <summary>
		/// [GL] Value of GL_CURRENT_PALETTE_MATRIX_ARB symbol.
		/// </summary>
		[AliasOf("GL_CURRENT_PALETTE_MATRIX_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int CURRENT_PALETTE_MATRIX_ARB = 0x8843;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_INDEX_ARRAY_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_ARB = 0x8844;

		/// <summary>
		/// [GL] Value of GL_CURRENT_MATRIX_INDEX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int CURRENT_MATRIX_INDEX_ARB = 0x8845;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_INDEX_ARRAY_SIZE_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_INDEX_ARRAY_TYPE_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_INDEX_ARRAY_STRIDE_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[AliasOf("GL_MATRIX_INDEX_ARRAY_POINTER_OES")]
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;

		/// <summary>
		/// [GL] Binding for glCurrentPaletteMatrixARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void CurrentPaletteMatrixARB(Int32 index)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixARB != null, "pglCurrentPaletteMatrixARB not implemented");
			Delegates.pglCurrentPaletteMatrixARB(index);
			LogCommand("glCurrentPaletteMatrixARB", null, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMatrixIndexubvARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(byte[] indices)
		{
			unsafe {
				fixed (byte* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexubvARB != null, "pglMatrixIndexubvARB not implemented");
					Delegates.pglMatrixIndexubvARB((Int32)indices.Length, p_indices);
					LogCommand("glMatrixIndexubvARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMatrixIndexusvARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(UInt16[] indices)
		{
			unsafe {
				fixed (UInt16* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexusvARB != null, "pglMatrixIndexusvARB not implemented");
					Delegates.pglMatrixIndexusvARB((Int32)indices.Length, p_indices);
					LogCommand("glMatrixIndexusvARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMatrixIndexuivARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(UInt32[] indices)
		{
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexuivARB != null, "pglMatrixIndexuivARB not implemented");
					Delegates.pglMatrixIndexuivARB((Int32)indices.Length, p_indices);
					LogCommand("glMatrixIndexuivARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMatrixIndexPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerARB != null, "pglMatrixIndexPointerARB not implemented");
			Delegates.pglMatrixIndexPointerARB(size, type, stride, pointer);
			LogCommand("glMatrixIndexPointerARB", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMatrixIndexPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerARB(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCurrentPaletteMatrixARB", ExactSpelling = true)]
			internal extern static void glCurrentPaletteMatrixARB(Int32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixIndexubvARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexubvARB(Int32 size, byte* indices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixIndexusvARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexusvARB(Int32 size, UInt16* indices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixIndexuivARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexuivARB(Int32 size, UInt32* indices);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixIndexPointerARB", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_matrix_palette")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCurrentPaletteMatrixARB(Int32 index);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glCurrentPaletteMatrixARB pglCurrentPaletteMatrixARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexubvARB(Int32 size, byte* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexubvARB pglMatrixIndexubvARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexusvARB(Int32 size, UInt16* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexusvARB pglMatrixIndexusvARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexuivARB(Int32 size, UInt32* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexuivARB pglMatrixIndexuivARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexPointerARB pglMatrixIndexPointerARB;

		}
	}

}
