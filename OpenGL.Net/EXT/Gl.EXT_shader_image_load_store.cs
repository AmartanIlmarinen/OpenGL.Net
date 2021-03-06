
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
		/// [GL] Binding for glBindImageTextureEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layered">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:BufferAccess"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public static void BindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, BufferAccess access, InternalFormat format)
		{
			Debug.Assert(Delegates.pglBindImageTextureEXT != null, "pglBindImageTextureEXT not implemented");
			Delegates.pglBindImageTextureEXT(index, texture, level, layered, layer, (Int32)access, (Int32)format);
			LogCommand("glBindImageTextureEXT", null, index, texture, level, layered, layer, access, format			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindImageTextureEXT", ExactSpelling = true)]
			internal extern static void glBindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			[ThreadStatic]
			internal static glBindImageTextureEXT pglBindImageTextureEXT;

		}
	}

}
