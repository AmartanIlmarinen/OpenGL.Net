
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
		/// [GL] Value of GL_VERTEX_ELEMENT_SWIZZLE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ID_SWIZZLE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int VERTEX_ID_SWIZZLE_AMD = 0x91A5;

		/// <summary>
		/// [GL] Binding for glVertexAttribParameteriAMD.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public static void VertexAttribParameterAMD(UInt32 index, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglVertexAttribParameteriAMD != null, "pglVertexAttribParameteriAMD not implemented");
			Delegates.pglVertexAttribParameteriAMD(index, pname, param);
			LogCommand("glVertexAttribParameteriAMD", null, index, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribParameteriAMD", ExactSpelling = true)]
			internal extern static void glVertexAttribParameteriAMD(UInt32 index, Int32 pname, Int32 param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_interleaved_elements")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribParameteriAMD(UInt32 index, Int32 pname, Int32 param);

			[RequiredByFeature("GL_AMD_interleaved_elements")]
			[ThreadStatic]
			internal static glVertexAttribParameteriAMD pglVertexAttribParameteriAMD;

		}
	}

}
