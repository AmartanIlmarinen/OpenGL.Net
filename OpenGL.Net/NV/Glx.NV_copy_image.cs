
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Binding for glXCopyImageSubDataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="srcCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="srcName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_copy_image")]
		public static void CopyImageSubDataNV(IntPtr dpy, IntPtr srcCtx, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr dstCtx, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglXCopyImageSubDataNV != null, "pglXCopyImageSubDataNV not implemented");
			Delegates.pglXCopyImageSubDataNV(dpy, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			LogCommand("glXCopyImageSubDataNV", null, dpy, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopyImageSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXCopyImageSubDataNV(IntPtr dpy, IntPtr srcCtx, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr dstCtx, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_copy_image")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopyImageSubDataNV(IntPtr dpy, IntPtr srcCtx, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr dstCtx, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[RequiredByFeature("GLX_NV_copy_image")]
			internal static glXCopyImageSubDataNV pglXCopyImageSubDataNV;

		}
	}

}
