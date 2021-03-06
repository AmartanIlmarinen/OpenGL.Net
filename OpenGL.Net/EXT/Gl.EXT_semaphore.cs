
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
		/// [GL] Value of GL_NUM_DEVICE_UUIDS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int NUM_DEVICE_UUIDS_EXT = 0x9596;

		/// <summary>
		/// [GL] Value of GL_DEVICE_UUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int DEVICE_UUID_EXT = 0x9597;

		/// <summary>
		/// [GL] Value of GL_DRIVER_UUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int DRIVER_UUID_EXT = 0x9598;

		/// <summary>
		/// [GL] Value of GL_UUID_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int UUID_SIZE_EXT = 16;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_GENERAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_GENERAL_EXT = 0x958D;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_COLOR_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_SHADER_READ_ONLY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_TRANSFER_SRC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_TRANSFER_SRC_EXT = 0x9592;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_TRANSFER_DST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_TRANSFER_DST_EXT = 0x9593;

		/// <summary>
		/// [GL] Binding for glGetUnsignedBytevEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:GetPName"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetUnsignedBytevEXT(GetPName pname, [Out] byte[] data)
		{
			unsafe {
				fixed (byte* p_data = data)
				{
					Debug.Assert(Delegates.pglGetUnsignedBytevEXT != null, "pglGetUnsignedBytevEXT not implemented");
					Delegates.pglGetUnsignedBytevEXT((Int32)pname, p_data);
					LogCommand("glGetUnsignedBytevEXT", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetUnsignedBytei_vEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetUnsignedBytei_vEXT(Int32 target, UInt32 index, [Out] byte[] data)
		{
			unsafe {
				fixed (byte* p_data = data)
				{
					Debug.Assert(Delegates.pglGetUnsignedBytei_vEXT != null, "pglGetUnsignedBytei_vEXT not implemented");
					Delegates.pglGetUnsignedBytei_vEXT(target, index, p_data);
					LogCommand("glGetUnsignedBytei_vEXT", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenSemaphoresEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="semaphores">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GenSemaphoreEXT(Int32 n, UInt32[] semaphores)
		{
			unsafe {
				fixed (UInt32* p_semaphores = semaphores)
				{
					Debug.Assert(Delegates.pglGenSemaphoresEXT != null, "pglGenSemaphoresEXT not implemented");
					Delegates.pglGenSemaphoresEXT(n, p_semaphores);
					LogCommand("glGenSemaphoresEXT", null, n, semaphores					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDeleteSemaphoresEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="semaphores">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void DeleteSemaphoreEXT(Int32 n, UInt32[] semaphores)
		{
			unsafe {
				fixed (UInt32* p_semaphores = semaphores)
				{
					Debug.Assert(Delegates.pglDeleteSemaphoresEXT != null, "pglDeleteSemaphoresEXT not implemented");
					Delegates.pglDeleteSemaphoresEXT(n, p_semaphores);
					LogCommand("glDeleteSemaphoresEXT", null, n, semaphores					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIsSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static bool IsSemaphoreEXT(UInt32 semaphore)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSemaphoreEXT != null, "pglIsSemaphoreEXT not implemented");
			retValue = Delegates.pglIsSemaphoreEXT(semaphore);
			LogCommand("glIsSemaphoreEXT", retValue, semaphore			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glSemaphoreParameterui64vEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:SemaphoreParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void SemaphoreParameterEXT(UInt32 semaphore, SemaphoreParameterName pname, UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglSemaphoreParameterui64vEXT != null, "pglSemaphoreParameterui64vEXT not implemented");
					Delegates.pglSemaphoreParameterui64vEXT(semaphore, (Int32)pname, p_params);
					LogCommand("glSemaphoreParameterui64vEXT", null, semaphore, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetSemaphoreParameterui64vEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:SemaphoreParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetSemaphoreParameterEXT(UInt32 semaphore, SemaphoreParameterName pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSemaphoreParameterui64vEXT != null, "pglGetSemaphoreParameterui64vEXT not implemented");
					Delegates.pglGetSemaphoreParameterui64vEXT(semaphore, (Int32)pname, p_params);
					LogCommand("glGetSemaphoreParameterui64vEXT", null, semaphore, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glWaitSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numBufferBarriers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numTextureBarriers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="srcLayouts">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void WaitSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32[] buffers, UInt32 numTextureBarriers, UInt32[] textures, Int32[] srcLayouts)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (UInt32* p_textures = textures)
				fixed (Int32* p_srcLayouts = srcLayouts)
				{
					Debug.Assert(Delegates.pglWaitSemaphoreEXT != null, "pglWaitSemaphoreEXT not implemented");
					Delegates.pglWaitSemaphoreEXT(semaphore, numBufferBarriers, p_buffers, numTextureBarriers, p_textures, p_srcLayouts);
					LogCommand("glWaitSemaphoreEXT", null, semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSignalSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numBufferBarriers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numTextureBarriers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="dstLayouts">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void SignalSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32[] buffers, UInt32 numTextureBarriers, UInt32[] textures, Int32[] dstLayouts)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (UInt32* p_textures = textures)
				fixed (Int32* p_dstLayouts = dstLayouts)
				{
					Debug.Assert(Delegates.pglSignalSemaphoreEXT != null, "pglSignalSemaphoreEXT not implemented");
					Delegates.pglSignalSemaphoreEXT(semaphore, numBufferBarriers, p_buffers, numTextureBarriers, p_textures, p_dstLayouts);
					LogCommand("glSignalSemaphoreEXT", null, semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUnsignedBytevEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetUnsignedBytevEXT(Int32 pname, byte* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUnsignedBytei_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetUnsignedBytei_vEXT(Int32 target, UInt32 index, byte* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenSemaphoresEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenSemaphoresEXT(Int32 n, UInt32* semaphores);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteSemaphoresEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteSemaphoresEXT(Int32 n, UInt32* semaphores);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsSemaphoreEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsSemaphoreEXT(UInt32 semaphore);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSemaphoreParameterui64vEXT", ExactSpelling = true)]
			internal extern static unsafe void glSemaphoreParameterui64vEXT(UInt32 semaphore, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSemaphoreParameterui64vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetSemaphoreParameterui64vEXT(UInt32 semaphore, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWaitSemaphoreEXT", ExactSpelling = true)]
			internal extern static unsafe void glWaitSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32* buffers, UInt32 numTextureBarriers, UInt32* textures, Int32* srcLayouts);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSignalSemaphoreEXT", ExactSpelling = true)]
			internal extern static unsafe void glSignalSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32* buffers, UInt32 numTextureBarriers, UInt32* textures, Int32* dstLayouts);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUnsignedBytevEXT(Int32 pname, byte* data);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetUnsignedBytevEXT pglGetUnsignedBytevEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUnsignedBytei_vEXT(Int32 target, UInt32 index, byte* data);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetUnsignedBytei_vEXT pglGetUnsignedBytei_vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenSemaphoresEXT(Int32 n, UInt32* semaphores);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGenSemaphoresEXT pglGenSemaphoresEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteSemaphoresEXT(Int32 n, UInt32* semaphores);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glDeleteSemaphoresEXT pglDeleteSemaphoresEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsSemaphoreEXT(UInt32 semaphore);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glIsSemaphoreEXT pglIsSemaphoreEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSemaphoreParameterui64vEXT(UInt32 semaphore, Int32 pname, UInt64* @params);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glSemaphoreParameterui64vEXT pglSemaphoreParameterui64vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSemaphoreParameterui64vEXT(UInt32 semaphore, Int32 pname, UInt64* @params);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetSemaphoreParameterui64vEXT pglGetSemaphoreParameterui64vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWaitSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32* buffers, UInt32 numTextureBarriers, UInt32* textures, Int32* srcLayouts);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glWaitSemaphoreEXT pglWaitSemaphoreEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSignalSemaphoreEXT(UInt32 semaphore, UInt32 numBufferBarriers, UInt32* buffers, UInt32 numTextureBarriers, UInt32* textures, Int32* dstLayouts);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glSignalSemaphoreEXT pglSignalSemaphoreEXT;

		}
	}

}
