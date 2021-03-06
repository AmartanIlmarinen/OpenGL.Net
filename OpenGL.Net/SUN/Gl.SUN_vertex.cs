
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
		/// [GL] Binding for glColor4ubVertex2fSUN.
		/// </summary>
		/// <param name="r">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y)
		{
			Debug.Assert(Delegates.pglColor4ubVertex2fSUN != null, "pglColor4ubVertex2fSUN not implemented");
			Delegates.pglColor4ubVertex2fSUN(r, g, b, a, x, y);
			LogCommand("glColor4ubVertex2fSUN", null, r, g, b, a, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4ubVertex2fvSUN.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4ubVertex2fvSUN(byte[] c, float[] v)
		{
			unsafe {
				fixed (byte* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubVertex2fvSUN != null, "pglColor4ubVertex2fvSUN not implemented");
					Delegates.pglColor4ubVertex2fvSUN(p_c, p_v);
					LogCommand("glColor4ubVertex2fvSUN", null, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4ubVertex3fSUN.
		/// </summary>
		/// <param name="r">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglColor4ubVertex3fSUN != null, "pglColor4ubVertex3fSUN not implemented");
			Delegates.pglColor4ubVertex3fSUN(r, g, b, a, x, y, z);
			LogCommand("glColor4ubVertex3fSUN", null, r, g, b, a, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4ubVertex3fvSUN.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4ubVertex3fvSUN(byte[] c, float[] v)
		{
			unsafe {
				fixed (byte* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubVertex3fvSUN != null, "pglColor4ubVertex3fvSUN not implemented");
					Delegates.pglColor4ubVertex3fvSUN(p_c, p_v);
					LogCommand("glColor4ubVertex3fvSUN", null, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3fVertex3fSUN.
		/// </summary>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color3fVertex3fSUN(float r, float g, float b, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglColor3fVertex3fSUN != null, "pglColor3fVertex3fSUN not implemented");
			Delegates.pglColor3fVertex3fSUN(r, g, b, x, y, z);
			LogCommand("glColor3fVertex3fSUN", null, r, g, b, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3fVertex3fvSUN.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color3fVertex3fvSUN(float[] c, float[] v)
		{
			unsafe {
				fixed (float* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3fVertex3fvSUN != null, "pglColor3fVertex3fvSUN not implemented");
					Delegates.pglColor3fVertex3fvSUN(p_c, p_v);
					LogCommand("glColor3fVertex3fvSUN", null, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Normal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglNormal3fVertex3fSUN != null, "pglNormal3fVertex3fSUN not implemented");
			Delegates.pglNormal3fVertex3fSUN(nx, ny, nz, x, y, z);
			LogCommand("glNormal3fVertex3fSUN", null, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Normal3fVertex3fvSUN(float[] n, float[] v)
		{
			unsafe {
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3fVertex3fvSUN != null, "pglNormal3fVertex3fvSUN not implemented");
					Delegates.pglNormal3fVertex3fvSUN(p_n, p_v);
					LogCommand("glNormal3fVertex3fvSUN", null, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglColor4fNormal3fVertex3fSUN != null, "pglColor4fNormal3fVertex3fSUN not implemented");
			Delegates.pglColor4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
			LogCommand("glColor4fNormal3fVertex3fSUN", null, r, g, b, a, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void Color4fNormal3fVertex3fvSUN(float[] c, float[] n, float[] v)
		{
			unsafe {
				fixed (float* p_c = c)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4fNormal3fVertex3fvSUN != null, "pglColor4fNormal3fVertex3fvSUN not implemented");
					Delegates.pglColor4fNormal3fVertex3fvSUN(p_c, p_n, p_v);
					LogCommand("glColor4fNormal3fVertex3fvSUN", null, c, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fVertex3fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fVertex3fSUN(float s, float t, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTexCoord2fVertex3fSUN != null, "pglTexCoord2fVertex3fSUN not implemented");
			Delegates.pglTexCoord2fVertex3fSUN(s, t, x, y, z);
			LogCommand("glTexCoord2fVertex3fSUN", null, s, t, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fVertex3fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fVertex3fvSUN(float[] tc, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fVertex3fvSUN != null, "pglTexCoord2fVertex3fvSUN not implemented");
					Delegates.pglTexCoord2fVertex3fvSUN(p_tc, p_v);
					LogCommand("glTexCoord2fVertex3fvSUN", null, tc, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4fVertex4fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="p">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglTexCoord4fVertex4fSUN != null, "pglTexCoord4fVertex4fSUN not implemented");
			Delegates.pglTexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
			LogCommand("glTexCoord4fVertex4fSUN", null, s, t, p, q, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4fVertex4fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord4fVertex4fvSUN(float[] tc, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fVertex4fvSUN != null, "pglTexCoord4fVertex4fvSUN not implemented");
					Delegates.pglTexCoord4fVertex4fvSUN(p_tc, p_v);
					LogCommand("glTexCoord4fVertex4fvSUN", null, tc, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor4ubVertex3fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTexCoord2fColor4ubVertex3fSUN != null, "pglTexCoord2fColor4ubVertex3fSUN not implemented");
			Delegates.pglTexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
			LogCommand("glTexCoord2fColor4ubVertex3fSUN", null, s, t, r, g, b, a, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor4ubVertex3fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor4ubVertex3fvSUN(float[] tc, byte[] c, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (byte* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fColor4ubVertex3fvSUN != null, "pglTexCoord2fColor4ubVertex3fvSUN not implemented");
					Delegates.pglTexCoord2fColor4ubVertex3fvSUN(p_tc, p_c, p_v);
					LogCommand("glTexCoord2fColor4ubVertex3fvSUN", null, tc, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor3fVertex3fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTexCoord2fColor3fVertex3fSUN != null, "pglTexCoord2fColor3fVertex3fSUN not implemented");
			Delegates.pglTexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
			LogCommand("glTexCoord2fColor3fVertex3fSUN", null, s, t, r, g, b, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor3fVertex3fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor3fVertex3fvSUN(float[] tc, float[] c, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fColor3fVertex3fvSUN != null, "pglTexCoord2fColor3fVertex3fvSUN not implemented");
					Delegates.pglTexCoord2fColor3fVertex3fvSUN(p_tc, p_c, p_v);
					LogCommand("glTexCoord2fColor3fVertex3fvSUN", null, tc, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTexCoord2fNormal3fVertex3fSUN != null, "pglTexCoord2fNormal3fVertex3fSUN not implemented");
			Delegates.pglTexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
			LogCommand("glTexCoord2fNormal3fVertex3fSUN", null, s, t, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fNormal3fVertex3fvSUN(float[] tc, float[] n, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fNormal3fVertex3fvSUN != null, "pglTexCoord2fNormal3fVertex3fvSUN not implemented");
					Delegates.pglTexCoord2fNormal3fVertex3fvSUN(p_tc, p_n, p_v);
					LogCommand("glTexCoord2fNormal3fVertex3fvSUN", null, tc, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor4fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTexCoord2fColor4fNormal3fVertex3fSUN != null, "pglTexCoord2fColor4fNormal3fVertex3fSUN not implemented");
			Delegates.pglTexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
			LogCommand("glTexCoord2fColor4fNormal3fVertex3fSUN", null, s, t, r, g, b, a, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2fColor4fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord2fColor4fNormal3fVertex3fvSUN(float[] tc, float[] c, float[] n, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_c = c)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fColor4fNormal3fVertex3fvSUN != null, "pglTexCoord2fColor4fNormal3fVertex3fvSUN not implemented");
					Delegates.pglTexCoord2fColor4fNormal3fVertex3fvSUN(p_tc, p_c, p_n, p_v);
					LogCommand("glTexCoord2fColor4fNormal3fVertex3fvSUN", null, tc, c, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4fColor4fNormal3fVertex4fSUN.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="p">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglTexCoord4fColor4fNormal3fVertex4fSUN != null, "pglTexCoord4fColor4fNormal3fVertex4fSUN not implemented");
			Delegates.pglTexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
			LogCommand("glTexCoord4fColor4fNormal3fVertex4fSUN", null, s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4fColor4fNormal3fVertex4fvSUN.
		/// </summary>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void TexCoord4fColor4fNormal3fVertex4fvSUN(float[] tc, float[] c, float[] n, float[] v)
		{
			unsafe {
				fixed (float* p_tc = tc)
				fixed (float* p_c = c)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fColor4fNormal3fVertex4fvSUN != null, "pglTexCoord4fColor4fNormal3fVertex4fvSUN not implemented");
					Delegates.pglTexCoord4fColor4fNormal3fVertex4fvSUN(p_tc, p_c, p_n, p_v);
					LogCommand("glTexCoord4fColor4fNormal3fVertex4fvSUN", null, tc, c, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiVertex3SUN(UInt32 rc, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiVertex3fSUN != null, "pglReplacementCodeuiVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiVertex3fSUN(rc, x, y, z);
			LogCommand("glReplacementCodeuiVertex3fSUN", null, rc, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiVertex3SUN(UInt32[] rc, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiVertex3fvSUN != null, "pglReplacementCodeuiVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiVertex3fvSUN(p_rc, p_v);
					LogCommand("glReplacementCodeuiVertex3fvSUN", null, rc, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor4ubVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiColor4ubVertex3fSUN != null, "pglReplacementCodeuiColor4ubVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
			LogCommand("glReplacementCodeuiColor4ubVertex3fSUN", null, rc, r, g, b, a, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor4ubVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32[] rc, byte[] c, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (byte* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiColor4ubVertex3fvSUN != null, "pglReplacementCodeuiColor4ubVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiColor4ubVertex3fvSUN(p_rc, p_c, p_v);
					LogCommand("glReplacementCodeuiColor4ubVertex3fvSUN", null, rc, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor3fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiColor3fVertex3fSUN != null, "pglReplacementCodeuiColor3fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
			LogCommand("glReplacementCodeuiColor3fVertex3fSUN", null, rc, r, g, b, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor3fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor3fVertex3fvSUN(UInt32[] rc, float[] c, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_c = c)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiColor3fVertex3fvSUN != null, "pglReplacementCodeuiColor3fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiColor3fVertex3fvSUN(p_rc, p_c, p_v);
					LogCommand("glReplacementCodeuiColor3fVertex3fvSUN", null, rc, c, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiNormal3fVertex3fSUN != null, "pglReplacementCodeuiNormal3fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
			LogCommand("glReplacementCodeuiNormal3fVertex3fSUN", null, rc, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32[] rc, float[] n, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiNormal3fVertex3fvSUN != null, "pglReplacementCodeuiNormal3fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiNormal3fVertex3fvSUN(p_rc, p_n, p_v);
					LogCommand("glReplacementCodeuiNormal3fVertex3fvSUN", null, rc, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor4fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiColor4fNormal3fVertex3fSUN != null, "pglReplacementCodeuiColor4fNormal3fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
			LogCommand("glReplacementCodeuiColor4fNormal3fVertex3fSUN", null, rc, r, g, b, a, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiColor4fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32[] rc, float[] c, float[] n, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_c = c)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiColor4fNormal3fVertex3fvSUN != null, "pglReplacementCodeuiColor4fNormal3fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiColor4fNormal3fVertex3fvSUN(p_rc, p_c, p_n, p_v);
					LogCommand("glReplacementCodeuiColor4fNormal3fVertex3fvSUN", null, rc, c, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fVertex3fSUN != null, "pglReplacementCodeuiTexCoord2fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
			LogCommand("glReplacementCodeuiTexCoord2fVertex3fSUN", null, rc, s, t, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32[] rc, float[] tc, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_tc = tc)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fVertex3fvSUN != null, "pglReplacementCodeuiTexCoord2fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiTexCoord2fVertex3fvSUN(p_rc, p_tc, p_v);
					LogCommand("glReplacementCodeuiTexCoord2fVertex3fvSUN", null, rc, tc, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN != null, "pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
			LogCommand("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", null, rc, s, t, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32[] rc, float[] tc, float[] n, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_tc = tc)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN != null, "pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(p_rc, p_tc, p_n, p_v);
					LogCommand("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", null, rc, tc, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN != null, "pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN not implemented");
			Delegates.pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
			LogCommand("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", null, rc, s, t, r, g, b, a, nx, ny, nz, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN.
		/// </summary>
		/// <param name="rc">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="tc">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_vertex")]
		public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32[] rc, float[] tc, float[] c, float[] n, float[] v)
		{
			unsafe {
				fixed (UInt32* p_rc = rc)
				fixed (float* p_tc = tc)
				fixed (float* p_c = c)
				fixed (float* p_n = n)
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN != null, "pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN not implemented");
					Delegates.pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(p_rc, p_tc, p_c, p_n, p_v);
					LogCommand("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", null, rc, tc, c, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubVertex2fSUN", ExactSpelling = true)]
			internal extern static void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubVertex2fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubVertex2fvSUN(byte* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubVertex3fvSUN(byte* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor3fVertex3fvSUN(float* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glNormal3fVertex3fvSUN(float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fVertex3fvSUN(float* tc, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fVertex4fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fVertex4fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fVertex4fvSUN(float* tc, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", ExactSpelling = true)]
			internal extern static void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiVertex3fSUN(UInt32 rc, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiVertex3fvSUN(UInt32* rc, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, byte* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, float* c, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, float* c, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, float* tc, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* n, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
			internal extern static void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
			internal extern static unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* c, float* n, float* v);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4ubVertex2fSUN pglColor4ubVertex2fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubVertex2fvSUN(byte* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4ubVertex2fvSUN pglColor4ubVertex2fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4ubVertex3fSUN pglColor4ubVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubVertex3fvSUN(byte* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4ubVertex3fvSUN pglColor4ubVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor3fVertex3fSUN pglColor3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3fVertex3fvSUN(float* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor3fVertex3fvSUN pglColor3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glNormal3fVertex3fSUN pglNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3fVertex3fvSUN(float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glNormal3fVertex3fvSUN pglNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fSUN pglColor4fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fvSUN pglColor4fNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fVertex3fSUN pglTexCoord2fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fVertex3fvSUN(float* tc, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fVertex3fvSUN pglTexCoord2fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord4fVertex4fSUN pglTexCoord4fVertex4fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fVertex4fvSUN(float* tc, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord4fVertex4fvSUN pglTexCoord4fVertex4fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fSUN pglTexCoord2fColor4ubVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fvSUN pglTexCoord2fColor4ubVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fSUN pglTexCoord2fColor3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fvSUN pglTexCoord2fColor3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fSUN pglTexCoord2fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fvSUN pglTexCoord2fNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fSUN pglTexCoord2fColor4fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fvSUN pglTexCoord2fColor4fNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fSUN pglTexCoord4fColor4fNormal3fVertex4fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fvSUN pglTexCoord4fColor4fNormal3fVertex4fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiVertex3fSUN(UInt32 rc, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fSUN pglReplacementCodeuiVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiVertex3fvSUN(UInt32* rc, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fvSUN pglReplacementCodeuiVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fSUN pglReplacementCodeuiColor4ubVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, byte* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fvSUN pglReplacementCodeuiColor4ubVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fSUN pglReplacementCodeuiColor3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, float* c, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fvSUN pglReplacementCodeuiColor3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fSUN pglReplacementCodeuiNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fvSUN pglReplacementCodeuiNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fSUN pglReplacementCodeuiColor4fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, float* c, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fvSUN pglReplacementCodeuiColor4fNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fSUN pglReplacementCodeuiTexCoord2fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, float* tc, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fvSUN pglReplacementCodeuiTexCoord2fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;

			[RequiredByFeature("GL_SUN_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* c, float* n, float* v);

			[RequiredByFeature("GL_SUN_vertex")]
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;

		}
	}

}
