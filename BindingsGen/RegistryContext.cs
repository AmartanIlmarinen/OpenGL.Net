
// Copyright (C) 2015-2016 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL specification context.
	/// </summary>
	public class RegistryContext : ISpecContext
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryContext()
		{
			SpecSerializer.UnknownAttribute += SpecSerializer_UnknownAttribute;
			SpecSerializer.UnknownElement += SpecSerializer_UnknownElement;
		}

		/// <summary>
		/// Construct a RegistryContext.
		/// </summary>
		/// <param name="class">
		/// A <see cref="String"/> that specifies the actual specification to build. It determines:
		/// - The name of the class to be generated (i.e. Gl, Wgl, Glx);
		/// - The features selection to include in the generated sources
		/// </param>
		/// <param name="registryPath">
		/// A <see cref="String"/> that specifies the path of the OpenGL specification to parse.
		/// </param>
		public RegistryContext(string @class, string registryPath)
		{
			// Store the class
			_Class = @class;
			// Set supported APIs
			List<string> apis = new List<string>();

			apis.Add(_Class.ToLower());

			if (_Class == "Gl") {
				// No need to add glcore, since gl is still a superset of glcore
				// apis.Add("glcore");
				// Support GS ES 1/2
				apis.Add("gles1");
				apis.Add("gles2");
			}

			_SupportedApi = apis.ToArray();
			// Loads the extension dictionary
			_ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			// Loads the words dictionary
			_WordsDictionary = SpecWordsDictionary.Load(String.Format("BindingsGen.GLSpecs.{0}Words.xml", @class));
			// Load and parse OpenGL specification
			using (StreamReader sr = new StreamReader(registryPath)) {
				_Registry = ((Registry)SpecSerializer.Deserialize(sr));
				_Registry.Link(this);
			}
		}

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		private readonly string _Class;

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		private readonly string[] _SupportedApi;

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		private readonly Registry _Registry;

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		private readonly SpecWordsDictionary _ExtensionsDictionary;

		/// <summary>
		/// The words dictionary.
		/// </summary>
		private readonly SpecWordsDictionary _WordsDictionary;

		/// <summary>
		/// Notify about unknown OpenGL specification elements.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="XmlSerializer"/> parsing the OpenGL specification.
		/// </param>
		/// <param name="e">
		/// A <see cref="XmlElementEventArgs"/> that specifies the event arguments.
		/// </param>
		private static void SpecSerializer_UnknownElement(object sender, XmlElementEventArgs e)
		{
			if (e.Element.Name == "unused")
				return;
			Console.WriteLine("Unknown element {0} at {1}:{2}.", e.Element.Name, e.LineNumber, e.LinePosition);
		}

		/// <summary>
		/// Notify about unknown OpenGL specification attributes.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="XmlSerializer"/> parsing the OpenGL specification.
		/// </param>
		/// <param name="e">
		/// A <see cref="XmlAttributeEventArgs"/> that specifies the event arguments.
		/// </param>
		private static void SpecSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
		{
			Console.WriteLine("Unknown attribute {0} at {1}:{2}.", e.Attr.Name, e.LineNumber, e.LinePosition);
		}

		/// <summary>
		/// OpenGL specification parser.
		/// </summary>
		private static readonly XmlSerializer SpecSerializer = new XmlSerializer(typeof(Registry));

		#region ISpecContext Implementation

		/// <summary>
		/// The name of the class to be generated.
		/// </summary>
		public string Class { get { return (_Class); } }

		/// <summary>
		/// The set of API supported by generated class.
		/// </summary>
		public string[] SupportedApi { get { return (_SupportedApi); } }

		/// <summary>
		/// Determine whether an API element is supported by the generated class.
		/// </summary>
		/// <param name="api">
		/// A <see cref="String"/> that specify the regular expression of the API element to be evaluated.
		/// </param>
		/// <returns>
		/// It returns true if <paramref name="api"/> specify a supported API.
		/// </returns>
		public bool IsSupportedApi(string api)
		{
			if (api == null)
				throw new ArgumentNullException("api");

			string regexApi = String.Format("^{0}$", api);

			foreach (string supportedApi in _SupportedApi) {
				if (Regex.IsMatch(supportedApi, regexApi))
					return (true);
			}
				

			return (false);
		}

		/// <summary>
		/// The OpenGL specification registry.
		/// </summary>
		public Registry Registry { get { return (_Registry); } }

		/// <summary>
		/// The extension names dictionary.
		/// </summary>
		public SpecWordsDictionary ExtensionsDictionary { get { return (_ExtensionsDictionary); } }

		/// <summary>
		/// The words dictionary.
		/// </summary>
		public SpecWordsDictionary WordsDictionary { get { return (_WordsDictionary); } }

		#endregion
	}
}