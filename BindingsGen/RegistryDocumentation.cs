
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
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL manual context.
	/// </summary>
	static class RegistryDocumentation
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static RegistryDocumentation()
		{
			TranformEnumerantMan2 = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.EnumerantDoc_Man2.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					TranformEnumerantMan2.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}


			TranformCommandMan2 = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CommandDoc_Man2.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					TranformCommandMan2.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}

			TranformEnumerantMan4 = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.EnumerantDoc_Man4.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					TranformEnumerantMan4.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}

			TranformCommandMan4 = new XslCompiledTransform();
			using (Stream xsltStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.GLSpecs.CommandDoc_Man4.xslt")) {
				using (XmlReader xmlReader = XmlReader.Create(xsltStream)) {
					// Load the XSLT transforming DocBook documentation into C# documentation
					TranformCommandMan4.Load(xmlReader, new XsltSettings(false, true), new XmlUrlResolver());
				}
			}
		}

		/// <summary>
		/// Force the static initialization.
		/// </summary>
		public static void Touch() {  }

		/// <summary>
		/// Documentation verbosity.
		/// </summary>
		/// <remarks>
		/// 0: full documentation
		/// 1: up to parameters documentation
		/// </remarks>
		public static int DocumentationLevel = 1;

		#endregion

		#region Enumerant Documentation

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail"></param>
		public static void GenerateDocumentation(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
			StringBuilder sb = new StringBuilder();

			// GL4 documentation
			if (GenerateDocumentation_GL4(sw, ctx, enumerant))
				return;

			// GL2 documentation
			if (GenerateDocumentation_GL2(sw, ctx, enumerant))
				return;

			// GL4 documentation
			if (GenerateDocumentation_EGL(sw, ctx, enumerant))
				return;

			if (GenerateDocumentation_CL(sw, ctx, enumerant))
				return;

			// Fallback (generic documentation)
			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// Value of {0} symbol{1}.", enumerant.Name, enumerant.IsDeprecated ? " (DEPRECATED)" : String.Empty);
			sw.WriteLine("/// </summary>");
			GenerateDocumentation_Remarks(sw, ctx, enumerant);
		}

		private static bool GenerateDocumentation_GL4(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
			List<EnumerationDocumentationBase> enumDocumentations;

			if (_DocumentationEnumMap4.TryGetValue(enumerant.Name, out enumDocumentations) == false)
				return (false);

			bool arrangeInPara = enumDocumentations.Count > 1;

			sw.WriteLine("/// <summary>");

			foreach (EnumerationDocumentationBase enumDocumentation in enumDocumentations) {
				List<string> enumerantDocLines = SplitDocumentationLines(enumDocumentation.GetDocumentation(ctx, TranformEnumerantMan4));

				if (arrangeInPara)
					sw.WriteLine("/// <para>");
				foreach (string line in enumerantDocLines)
					sw.WriteLine("/// {0}", line);
				if (arrangeInPara)
					sw.WriteLine("/// </para>");
			}
			sw.WriteLine("/// </summary>");
			
			GenerateDocumentation_Remarks(sw, ctx, enumerant);

			return (true);
		}

		private static bool GenerateDocumentation_GL2(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
			List<EnumerationDocumentationBase> enumDocumentations;

			if (_DocumentationEnumMap2.TryGetValue(enumerant.Name, out enumDocumentations) == false)
				return (false);

			bool arrangeInPara = enumDocumentations.Count > 1;

			sw.WriteLine("/// <summary>");

			foreach (EnumerationDocumentationBase enumDocumentation in enumDocumentations) {
				List<string> enumerantDocLines = SplitDocumentationLines(enumDocumentation.GetDocumentation(ctx, TranformEnumerantMan2));

				if (arrangeInPara)
					sw.WriteLine("/// <para>");
				foreach (string line in enumerantDocLines)
					sw.WriteLine("/// {0}", line);
				if (arrangeInPara)
					sw.WriteLine("/// </para>");
			}
			sw.WriteLine("/// </summary>");

			GenerateDocumentation_Remarks(sw, ctx, enumerant);

			return (true);
		}

		private static bool GenerateDocumentation_EGL(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
			List<EnumerationDocumentationBase> enumDocumentations;

			if (_DocumentationEnumMapE.TryGetValue(enumerant.Name, out enumDocumentations) == false)
				return (false);

			bool arrangeInPara = enumDocumentations.Count > 1;

			sw.WriteLine("/// <summary>");

			foreach (EnumerationDocumentationBase enumDocumentation in enumDocumentations) {
				List<string> enumerantDocLines = SplitDocumentationLines(enumDocumentation.GetDocumentation(ctx, TranformEnumerantMan4));

				if (arrangeInPara)
					sw.WriteLine("/// <para>");
				foreach (string line in enumerantDocLines)
					sw.WriteLine("/// {0}", line);
				if (arrangeInPara)
					sw.WriteLine("/// </para>");
			}
			sw.WriteLine("/// </summary>");

			GenerateDocumentation_Remarks(sw, ctx, enumerant);

			return (true);
		}

		private static bool GenerateDocumentation_CL(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
			List<EnumerationDocumentationBase> enumDocumentations;

			if (_DocumentationEnumMapCL.TryGetValue(enumerant.Name, out enumDocumentations) == false)
				return (false);

			bool arrangeInPara = enumDocumentations.Count > 1;

			sw.WriteLine("/// <summary>");

			foreach (EnumerationDocumentationBase enumDocumentation in enumDocumentations) {
				string enumerantDoc = enumDocumentation.GetDocumentation(ctx, TranformEnumerantMan2);
				if (enumerantDoc == null)
					continue;

				List<string> enumerantDocLines = SplitDocumentationLines(enumerantDoc);

				if (arrangeInPara)
					sw.WriteLine("/// <para>");
				foreach (string line in enumerantDocLines)
					sw.WriteLine("/// {0}", line);
				if (arrangeInPara)
					sw.WriteLine("/// </para>");
			}
			sw.WriteLine("/// </summary>");

			GenerateDocumentation_Remarks(sw, ctx, enumerant);

			return (true);
		}

		public static void GenerateDocumentation_Remarks(SourceStreamWriter sw, ISpecContext ctx, Enumerant enumerant)
		{
#if false
			bool requireRemarks = (enumerant.AliasOf.Count > 0);

			if (requireRemarks) {
				sw.WriteLine("/// <remarks>");

#if false
				if (enumerant.AliasOf.Count > 0) {
					sw.WriteLine("/// <para>");
					sw.WriteLine("/// This enumerant is equaivalent to {0}.", SpecificationStyle.GetEnumBindingName(Alias));
					sw.WriteLine("/// </para>");
				}
#endif

				sw.WriteLine("/// </remarks>");
			}
#endif
		}

		#endregion

		#region Command Documentation

		/// <summary>
		/// Generate a <see cref="Command"/> documentation, sourced from OpenGL 2 manual, OpenGL 4 manual or a generic one.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		public static void GenerateDocumentation(SourceStreamWriter sw, ISpecContext ctx, Command command, List<CommandParameter> commandParams)
		{
			StringBuilder sb = new StringBuilder();

			// GL4 documentation
			try {
				if (GenerateDocumentation_GL4(sw, ctx, command, true, commandParams))
					return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL4 documentation: {0}", exception.Message);
			}

			// GL2 documentation
			try {
				if (GenerateDocumentation_GL2(sw, ctx, command, true, commandParams))
					return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate GL2 documentation: {0}", exception.Message);
			}

			// EGL documentation
			try {
				if (GenerateDocumentation_EGL(sw, ctx, command, true, commandParams))
					return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate EGL documentation: {0}", exception.Message);
			}

			// EGL documentation
			try {
				if (GenerateDocumentation_CL(sw, ctx, command, true, commandParams))
					return;
			} catch (Exception exception) {
				sb.AppendFormat("Unable to generate EGL documentation: {0}", exception.Message);
			}

			// Fallback (generic documentation)
			GenerateDocumentation_GL4(sw, ctx, command, false, commandParams);
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 2 manual.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail"></param>
		public static bool GenerateDocumentation_GL2(SourceStreamWriter sw, ISpecContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = null;
			XmlElement root = null;
			XmlNodeList xmlNodes;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

			if (_DocumentationMap2.TryGetValue(command.Prototype.Name, out xml))
				root = xml.DocumentElement;

			if (fail && (root == null))
				return (false);

#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				XmlNode xmlIdentifier = xml.SelectSingleNode("/refentry/refnamediv/refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, TranformCommandMan2, ctx);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

#endregion

#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[term/parameter/text() = '{0}']/listitem/para", param.ImplementationNameRaw);

					XmlNode xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, TranformCommandMan2, ctx);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.Name);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

#endregion

#region Remarks

			xmlNodes = root.SelectNodes("/refentry/refsect1[@id='errors']/para", nsmgr);
			int errorsCount = xmlNodes.Count == 0 ? 0 : xmlNodes.Count;
			bool requiresRemarks = ((root != null) && (DocumentationLevel == 0)) || (errorsCount > 0);

			if (requiresRemarks) {
				sw.WriteLine("/// <remarks>");

#region Description & Associated Gets

				if (root != null && DocumentationLevel == 0) {
					xmlNodes = root.SelectNodes("/refentry/refsect1[@id='description']/para", nsmgr);
					if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
						foreach (XmlNode node in xmlNodes) {
							List<string> para = GetDocumentationLines(node.InnerXml, TranformCommandMan2, ctx);

							foreach (string paraLine in para)
								sw.WriteLine("/// {0}", paraLine);
						}
					}
				

					xmlNodes = root.SelectNodes("/refentry/refsect1[@id='associatedgets']/para", nsmgr);
					if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
						sw.WriteLine("/// <para>");
						sw.WriteLine("/// The associated information is got with the following commands:");
						foreach (XmlNode node in xmlNodes) {
							List<string> para = GetDocumentationLines(node.InnerXml, TranformCommandMan2, ctx);

							sw.WriteLine("/// - {0}", para[0]);
							if (para.Count > 1)
								for (int i = 1; i < para.Count; i++)
									sw.WriteLine("///   {0}", para[i]);
						}
						sw.WriteLine("/// </para>");
					}

				}

#endregion

				if (errorsCount > 0) {
					if ((command.Flags & CommandFlags.NoGetError) != 0) {
						sw.WriteLine("/// <para>The exception{0} below won't be thrown; caller must check result manually.</para>", errorsCount > 1 ? "s" : String.Empty);
					} else {
						// sw.WriteLine("<para>The exception{0} below are thrown if compiled with DEBUG symbol.</para>", errorsCount > 1 ? "s" : String.Empty);
					}
				}

				sw.WriteLine("/// </remarks>");
			}

#endregion

#region Errors

			if (root != null) {
				xmlNodes = root.SelectNodes("/refentry/refsect1[@id='errors']/para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						sw.WriteLine("/// <exception cref=\"KhronosException\">");

						StringBuilder sb = new StringBuilder();

						sb.Append(GetDocumentationLine(node.InnerXml, TranformCommandMan2, ctx));

						List<string> lines = SplitDocumentationLines(sb.ToString());

						foreach (string line in lines)
							sw.WriteLine("/// {0}", line);

						sw.WriteLine("/// </exception>");
					}
				}
			}

#endregion

#region See Also

			if (root != null) {
				xmlNodes = root.SelectNodes("/refentry/refsect1[@id='seealso']/para/citerefentry/refentrytitle", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);
						if (implementationName != String.Empty)
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
						else
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
					}
				}
			}

#endregion

			return (true);
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail"></param>
		public static bool GenerateDocumentation_GL4(SourceStreamWriter sw, ISpecContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = null;
			XmlElement root = null;
			XmlNodeList xmlNodes;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			if (_DocumentationMap4.TryGetValue(command.Prototype.Name, out xml))
				root = xml.DocumentElement;

			if (fail && (root == null))
				return (false);

#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				XmlNode xmlIdentifier = xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, TranformCommandMan4, ctx);
			}
			
			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

#endregion

#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					XmlNode xmlIdentifier = null;
					List<string> paramAliases = new List<string>();

					paramAliases.Add(param.ImplementationNameRaw.ToLowerInvariant());
					if (param.Name == "x") paramAliases.Add("v0");
					if (param.Name == "y") paramAliases.Add("v1");
					if (param.Name == "z") paramAliases.Add("v2");
					if (param.Name == "w") paramAliases.Add("v3");

					foreach (string paramAlias in paramAliases) {
						string xpathbase = String.Format(
							"/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text()='{2}']",

							"translate(@xml:id,'ABCDEFGHIJKLMNOPQRSTUVWXYZ123456790','abcdefghijklmnopqrstuvwxyz123456790')",						// @xml:id
							"translate(x:term/x:parameter/text(),'ABCDEFGHIJKLMNOPQRSTUVWXYZ123456790','abcdefghijklmnopqrstuvwxyz123456790')",		// x:term/x:parameter/text()
							paramAlias.ToLowerInvariant()
						);

						if ((xmlIdentifier = root.SelectSingleNode(xpathbase, nsmgr)) != null) {
							if ((xmlIdentifier = xmlIdentifier.SelectSingleNode("x:listitem/x:para", nsmgr)) != null)
								break;
						}

						string xpath = String.Format(
							"/x:refentry/x:refsect1[{0}='parameters']/x:variablelist/x:varlistentry[{1}='{2}']/x:listitem/x:para",

							"translate(@xml:id,'ABCDEFGHIJKLMNOPQRSTUVWXYZ123456790','abcdefghijklmnopqrstuvwxyz123456790')",						// @xml:id
							"translate(x:term/x:parameter/text(),'ABCDEFGHIJKLMNOPQRSTUVWXYZ123456790','abcdefghijklmnopqrstuvwxyz123456790')",		// x:term/x:parameter/text()
							paramAlias.ToLowerInvariant()
						);

						if ((xmlIdentifier = root.SelectSingleNode(xpath, nsmgr)) != null)
							break;
					}
					
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, TranformCommandMan4, ctx);
					else {
						if (_WarningLog != null)
							_WarningLog.WriteLine("Missing documentation: {0}.{1}.{2}", ctx.Class, command.GetImplementationName(ctx), param.Name);
						Console.WriteLine("Unable to to document {0}.{1}.{2}", ctx.Class, command.GetImplementationName(ctx), param.Name);
					}
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationNameRaw);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

#endregion

#region Remarks

			xmlNodes = null;
			if (root != null)
				xmlNodes = root.SelectNodes("/x:refentry/x:refsect1[@xml:id='errors']/x:para", nsmgr);
			int errorsCount = (xmlNodes == null) || (xmlNodes.Count == 0) ? 0 : xmlNodes.Count;

			if (ctx.Class == "Glx")
				errorsCount = 0;		// Bad semantic for GLX errors: no exception is actually thrown

			bool requiresRemarks = ((root != null) && (DocumentationLevel == 0)) || (errorsCount > 0);

			if (requiresRemarks) {
				sw.WriteLine("/// <remarks>");

#region Description & Associated Gets

				if (root != null && DocumentationLevel == 0) {
					xmlNodes = root.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:para", nsmgr);
					if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
						foreach (XmlNode node in xmlNodes) {
							List<string> para = GetDocumentationLines(node.InnerXml, TranformCommandMan4, ctx);

							foreach (string paraLine in para)
								sw.WriteLine("/// {0}", paraLine);
						}
					}
				
					xmlNodes = root.SelectNodes("/x:refentry/x:refsect1[@xml:id='associatedgets']/x:para", nsmgr);
					if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
						sw.WriteLine("/// <para>");
						sw.WriteLine("/// The associated information is got with the following commands:");
						foreach (XmlNode node in xmlNodes) {
							List<string> para = GetDocumentationLines(node.InnerXml, TranformCommandMan4, ctx);

							sw.WriteLine("/// - {0}", para[0]);
							if (para.Count > 1)
								for (int i = 1; i < para.Count; i++)
									sw.WriteLine("///   {0}", para[i]);
						}
						sw.WriteLine("/// </para>");
					}
				}

#endregion

				if (errorsCount > 0) {
					if ((command.Flags & CommandFlags.NoGetError) != 0) {
						sw.WriteLine("/// <para>The exception{0} below won't be thrown; caller must check result manually.</para>", errorsCount > 1 ? "s" : String.Empty);
					} else {
						// sw.WriteLine("<para>The exception{0} below are thrown if compiled with DEBUG symbol.</para>", errorsCount > 1 ? "s" : String.Empty);
					}
				}

				sw.WriteLine("/// </remarks>");
			}

#endregion

#region Errors

			if (root != null) {
				xmlNodes = root.SelectNodes("/x:refentry/x:refsect1[@xml:id='errors']/x:para", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						sw.WriteLine("/// <exception cref=\"InvalidOperationException\">");

						StringBuilder sb = new StringBuilder();

						sb.Append(GetDocumentationLine(node.InnerXml, TranformCommandMan4, ctx));

						List<string> lines = SplitDocumentationLines(sb.ToString());

						foreach (string line in lines)
							sw.WriteLine("/// {0}", line);

						sw.WriteLine("/// </exception>");
					}
				}
			}

#endregion

#region See Also

			if (root != null) {
				xmlNodes = root.SelectNodes("/x:refentry/x:refsect1[@xml:id='seealso']/x:para/x:citerefentry/x:refentrytitle", nsmgr);
				if ((xmlNodes != null) && (xmlNodes.Count > 0)) {
					foreach (XmlNode node in xmlNodes) {
						string implementationName = ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText);
						if (implementationName != String.Empty)
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, ctx.WordsDictionary.GetOverridableName(ctx, node.InnerText).Substring(ctx.Class.Length));
						else
							sw.WriteLine("/// <seealso cref=\"{0}.{1}\"/>", ctx.Class, node.InnerText);
					}
				}
			}

#endregion

			return (true);
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail"></param>
		public static bool GenerateDocumentation_EGL(SourceStreamWriter sw, ISpecContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = null;
			XmlElement root = null;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			if (_DocumentationMapE.TryGetValue(command.Prototype.Name, out xml))
				root = xml.DocumentElement;

			if (fail && (root == null))
				return (false);

#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				XmlNode xmlIdentifier = xml.SelectSingleNode("/x:refentry/x:refnamediv/x:refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, TranformCommandMan4, ctx);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

#endregion

#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					string xpath = String.Format("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry[x:term/x:parameter/text() = '{0}']/x:listitem/x:para", param.ImportName);

					XmlNode xmlIdentifier = root.SelectSingleNode(xpath, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, TranformCommandMan4, ctx);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationNameRaw);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

#endregion

			return (true);
		}

		/// <summary>
		/// Generate a <see cref="Command"/> documentation using the OpenGL 4 manual.
		/// </summary>
		/// <param name="sw">
		/// A <see cref="SourceStreamWriter"/> used to write the documentation of <paramref name="command"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="RegistryContext"/> that defines the OpenGL specification.
		/// </param>
		/// <param name="command">
		/// The <see cref="Command"/> to be documented.
		/// </param>
		/// <param name="fail"></param>
		public static bool GenerateDocumentation_CL(SourceStreamWriter sw, ISpecContext ctx, Command command, bool fail, List<CommandParameter> commandParams)
		{
			XmlDocument xml = null;
			XmlElement root = null;

			XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
			nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
			//nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

			if (_DocumentationMapCL.TryGetValue(command.Prototype.Name, out xml))
				root = xml.DocumentElement;

			if (fail && (root == null))
				return (false);

			#region Summary

			string purpose = String.Format("Binding for {0}.", command.Prototype.Name);

			if (root != null) {
				XmlNode xmlIdentifier = xml.SelectSingleNode("/refentry/refnamediv/refpurpose", nsmgr);
				if (xmlIdentifier != null)
					purpose = GetDocumentationLine(xmlIdentifier.InnerText, TranformCommandMan2, ctx);
			}

			sw.WriteLine("/// <summary>");
			sw.WriteLine("/// {0}", purpose);
			sw.WriteLine("/// </summary>");

			#endregion

			#region Parameters

			foreach (CommandParameter param in commandParams) {
				List<string> paramDoc = new List<string>();

				// Note: in the case of overloaded methods, some parameters are implicit. Skip the documentation for those parameters.
				if (param.IsImplicit(ctx, command))
					continue;

				// Default
				paramDoc.Add(String.Format("A <see cref=\"T:{0}\"/>.", param.GetImplementationType(ctx, command)));

				if (root != null) {
					XmlNode xmlIdentifier;

					string xpath1 = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[normalize-space(term/varname/text()) = '{0}']/listitem/para", param.ImportName);
					xmlIdentifier = root.SelectSingleNode(xpath1, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, TranformCommandMan4, ctx);

					string xpath2 = String.Format("/refentry/refsect1[@id='parameters']/variablelist/varlistentry[normalize-space(term/text()) = '{0}']/listitem/para", param.ImportName);
					xmlIdentifier = root.SelectSingleNode(xpath2, nsmgr);
					if (xmlIdentifier != null)
						paramDoc = GetDocumentationLines(xmlIdentifier.InnerXml, TranformCommandMan4, ctx);
				}

				sw.WriteLine("/// <param name=\"{0}\">", param.ImplementationNameRaw);
				foreach (string line in paramDoc)
					sw.WriteLine("/// {0}", line);
				sw.WriteLine("/// </param>");
			}

			#endregion

			return (true);
		}

		#endregion

		#region Text Processing

		/// <summary>
		/// Translate the XHTML documentation using a <see cref="XslCompiledTransform"/>.
		/// </summary>
		/// <param name="documentation">
		/// The XHTML documentation to be translated.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> defining the transformation process.
		/// </param>
		/// <returns>
		/// It returns <paramref name="documentation"/> processed with <paramref name="transform"/>.
		/// </returns>
		private static string ProcessXmlDocumentation(string documentation, XslCompiledTransform transform, ISpecContext ctx)
		{
			string transformedXml;

			using (StringWriter sw = new StringWriter()) {
				XsltArgumentList xsltArgs = new XsltArgumentList();

				xsltArgs.AddParam("class", String.Empty, ctx.Class);

				XmlDocument xmlDocumentation = new XmlDocument();
				StringBuilder xmlBulder = new StringBuilder();

				xmlBulder.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
				xmlBulder.Append("<documentation>");
				xmlBulder.Append(documentation);
				xmlBulder.Append("</documentation>");

				xmlDocumentation.LoadXml(xmlBulder.ToString());

				transform.Transform(xmlDocumentation.DocumentElement.CreateNavigator(), xsltArgs, sw);

				transformedXml = sw.ToString();

				// Untag elements
				transformedXml = transformedXml.Replace("see_cref", "see cref");
				transformedXml = transformedXml.Replace("paramref_name", "paramref name");
			}

			return (transformedXml);
		}

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform TranformCommandMan2;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform TranformEnumerantMan2;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 4 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform TranformCommandMan4;

		/// <summary>
		/// The <see cref="XslCompiledTransform"/> to translate OpenGL 2 manual documentation into C# code documentation.
		/// </summary>
		private static readonly XslCompiledTransform TranformEnumerantMan4;

		/// <summary>
		/// Code documentation trimming.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> that specifies the documentation to be trimmed.
		/// </param>
		/// <returns>
		/// It returns <paramref name="documentation"/>, after having removed all new lines characters and reduced contiguous
		/// white spaces.
		/// </returns>
		private static string TrimXmlDocumentation(string documentation)
		{
			// Remove carriage returns
			documentation = Regex.Replace(documentation, @"(\r|\n)", String.Empty);
			// Trim white spaces
			documentation = Regex.Replace(documentation, @"(\t| )", " "); ;
			documentation = documentation.Trim();
			// Replace multi white spaces with a single one
			documentation = Regex.Replace(documentation, " +", " ");

			return (documentation);
		}

		private static string BeautifyDocumentation(string documentation)
		{
			if (documentation.Length > 0 && Char.IsLower(documentation[0]))
				documentation = Char.ToUpper(documentation[0]) + documentation.Substring(1);

			return (documentation);
		}

		/// <summary>
		/// Translate the XHTML documentation into code documentation.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> taht specifies the XHTML documentation.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> used to translate the XHTML documentation into code documentation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:List{String}"/> that specifies <paramref name="documentation"/> string.
		/// </returns>
		private static string GetDocumentationLine(string documentation, XslCompiledTransform transform, ISpecContext ctx)
		{
			documentation = ProcessXmlDocumentation(documentation, transform, ctx);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			return (documentation);
		}

		/// <summary>
		/// Translate the XHTML documentation into code documentation, splitting it into a sequence of lines.
		/// </summary>
		/// <param name="documentation">
		/// A <see cref="String"/> taht specifies the XHTML documentation.
		/// </param>
		/// <param name="transform">
		/// The <see cref="XslCompiledTransform"/> used to translate the XHTML documentation into code documentation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:List{String}"/> that specifies <paramref name="documentation"/> string, after
		/// having processes and splitted into multiple lines.
		/// </returns>
		/// <remarks>
		/// The maximum line size is 120 columns.
		/// </remarks>
		private static List<string> GetDocumentationLines(string documentation, XslCompiledTransform transform, ISpecContext ctx)
		{
			documentation = ProcessXmlDocumentation(documentation, transform, ctx);
			documentation = TrimXmlDocumentation(documentation);
			//documentation = BeautifyDocumentation(documentation);

			return (SplitDocumentationLines(documentation));
		}

		public static List<string> SplitDocumentationLines(string documentation)
		{
			const int MAX_LINE_LENGTH = 120;

			List<string> documentationLines = new List<string>();
			string[] documentationTokens = Regex.Split(documentation, " ");
			StringBuilder documentationLine = new StringBuilder();

			for (int i = 0; i < documentationTokens.Length; i++) {
				if (documentationLine.Length + documentationTokens[i].Length > MAX_LINE_LENGTH) {
					documentationLines.Add(documentationLine.ToString());
					documentationLine = new StringBuilder();
					documentationLine.Append(documentationTokens[i]);
				} else {
					documentationLine.Append(documentationTokens[i]);
				}
				if (i < documentationTokens.Length - 1)
					documentationLine.Append(" ");
			}
			if (documentationLine.Length > 0)
				documentationLines.Add(documentationLine.ToString());

			return (documentationLines);
		}

		public static List<string> SplitDocumentationPeriods(string documentation)
		{
			string[] periods = Regex.Split(documentation, @"(\.|\,)( |\n|\t|$)");

			return (new List<string>(periods));
		}

		#endregion

		#region Documentation Scanning

		/// <summary>
		/// Index all documented OpenGL commands the the OpenGL 2 manual.
		/// </summary>
		public static void ScanDocumentation_GL2()
		{
			Console.WriteLine("Scanning registry documentation (GL2)...");

			List<string> documentationFiles = new List<string>(Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL2")));

			documentationFiles = documentationFiles.FindAll(delegate(string item) {
				return (item.ToLowerInvariant().EndsWith(".xml"));
			});

			List<List<string>> documentationJobs = new List<List<string>>();
			int jobSize = documentationFiles.Count / Environment.ProcessorCount + 1;
			int jobReminder = documentationFiles.Count % jobSize;

			for (int i = 0; i < Environment.ProcessorCount - 1; i++)
				documentationJobs.Add(documentationFiles.GetRange(i * jobSize, jobSize));
			documentationJobs.Add(documentationFiles.GetRange(jobSize * (Environment.ProcessorCount - 1), Math.Min(jobSize, jobReminder == 0 ? jobSize : jobReminder)));

			int jobsRemaining = Environment.ProcessorCount;

			LocalXhtmlXmlResolver.Touch();

			Dictionary<string, XmlDocument> commandsMap = _DocumentationMap2;
			Dictionary<string, List<EnumerationDocumentationBase>> enumerantsMap = _DocumentationEnumMap2;

			using (ManualResetEvent waitThreads = new ManualResetEvent(false)) {
				foreach (List<string> items in documentationJobs) {
					ThreadPool.QueueUserWorkItem(delegate(object state) {
						List<string> files = (List<string>)state;

						foreach (string documentationFile in files) {
							XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
							nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");

							try {
								// Load XML file
								using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
									XmlDocument xml = new XmlDocument();
									XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

									xmlReaderSettings.ProhibitDtd = false;
									xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "GLMan/DTD"));

									using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings)) {
										xml.Load(xmlReader);
									}

									XmlNodeList funcprotos = xml.SelectNodes("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);

									if (funcprotos.Count == 0)
										continue;

									foreach (XmlNode item in funcprotos) {
										
											if (!Regex.IsMatch(item.InnerText, "^(gl|wgl|glx).*"))
												continue;
											if (commandsMap.ContainsKey(item.InnerText))
												continue;

										lock (documentationJobs) {
											commandsMap.Add(item.InnerText, xml);
										}
									}

									// Extract enumeration documentation:
									XmlNodeList enumerants = xml.SelectNodes("/refentry/refsect1[@id='description']/variablelist/varlistentry", nsmgr);

									foreach (XmlNode enumerant in enumerants) {
										XmlNode enumerantId = enumerant.SelectSingleNode("term/constant", nsmgr);
										if (enumerantId == null)
											continue;

										XmlNode enumerantDoc = enumerant.SelectSingleNode("listitem", nsmgr);
										if (enumerantDoc == null)
											continue;

										if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_).*"))
											continue;

										lock (documentationJobs) {
											if (!enumerantsMap.ContainsKey(enumerantId.InnerText))
												enumerantsMap.Add(enumerantId.InnerText, new List<EnumerationDocumentationBase>());
											enumerantsMap[enumerantId.InnerText].Add(new EnumerationDocumentationGetParam(xml, funcprotos[0].InnerText, enumerantDoc));
										}
									}

									lock (documentationJobs) {
										Console.Write("\r    Scanned {0} commands and {1} enumerants...", commandsMap.Count, enumerantsMap.Count);
									}
								}
							} catch {
								continue;
							}
						}

						if (Interlocked.Decrement(ref jobsRemaining) == 0)
							waitThreads.Set();

					}, items);
				}

				waitThreads.WaitOne();
			}

			Console.WriteLine("\r\tFound documentation for {0} commands and {1} enumerants.", _DocumentationMap2.Count, _DocumentationEnumMap2.Count);
		}

		/// <summary>
		/// Index all documented OpenGL commands the the OpenGL 4 manual.
		/// </summary>
		public static void ScanDocumentation_GL4()
		{
			Console.WriteLine("Scanning registry documentation (GL4)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/GL4"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;
				if (Regex.IsMatch(Path.GetFileNameWithoutExtension(documentationFile), @"(gl|wgl|glX)\w+") == false)
					continue;

				try {
					// Load XML file
					using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
						XmlDocument xml = new XmlDocument();
						XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
						nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
						nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

						XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
						XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

						xmlReaderSettings.ProhibitDtd = false;
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
						xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(documentationFile);
						xmlReaderSettings.IgnoreComments = true;
						xmlReaderSettings.IgnoreProcessingInstructions = true;
						xmlReaderSettings.CheckCharacters = false;
						xmlReaderSettings.ValidationType = ValidationType.None;
						xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

						using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
							xml.Load(xmlReader);
						}

						XmlNodeList xmlIdentifiers = xml.DocumentElement.SelectNodes("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);

						if (xmlIdentifiers.Count == 0)
							continue;

						foreach (XmlNode xmlIdentifier in xmlIdentifiers) {
							if (!Regex.IsMatch(xmlIdentifier.InnerText, "^(gl|wgl|glX).*"))
								continue;
							if (_DocumentationMap4.ContainsKey(xmlIdentifier.InnerText))
								continue;

							_DocumentationMap4.Add(xmlIdentifier.InnerText, xml);
						}

						XmlNodeList enumerants;

						// Extract enumeration documentation: Get command parameters
						enumerants = xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:variablelist/x:varlistentry", nsmgr);

						foreach (XmlNode enumerant in enumerants) {
							XmlNode enumerantId = enumerant.SelectSingleNode("x:term/x:constant", nsmgr);
							if (enumerantId == null)
								continue;

							XmlNode enumerantDoc = enumerant.SelectSingleNode("x:listitem", nsmgr);
							if (enumerantDoc == null)
								continue;

							if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_).*"))
								continue;

							if (!_DocumentationEnumMap4.ContainsKey(enumerantId.InnerText))
								_DocumentationEnumMap4.Add(enumerantId.InnerText, new List<EnumerationDocumentationBase>());

							_DocumentationEnumMap4[enumerantId.InnerText].Add(new EnumerationDocumentationGetParam(xml, xmlIdentifiers[0].InnerText, enumerantDoc));
						}

#if false
						// Extract enumeration documentation: Set command parameters
						enumerants = xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='parameters']/x:variablelist/x:varlistentry/x:listitem/x:para/x:constant", nsmgr);

						foreach (XmlNode enumerant in enumerants) {
							string enumerantId = enumerant.InnerText;
							if (enumerantId == null)
								continue;

							if (!Regex.IsMatch(enumerantId, "^(GL_|WGL_|GLX_).*"))
								continue;

							if (!sDocumentationEnumMap4.ContainsKey(enumerantId))
								sDocumentationEnumMap4.Add(enumerantId, new List<EnumerationDocumentationBase>());

							sDocumentationEnumMap4[enumerantId].Add(new EnumerationDocumentationSetParam(xml, xmlIdentifiers[0].InnerText, enumerant));
						}
#endif
					}
				} catch (Exception) {
					continue;
				}
			}

			Console.WriteLine("\tFound documentation for {0} commands and {1} enumerants.", _DocumentationMap4.Count, _DocumentationEnumMap4.Count);
		}

		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		public static void ScanDocumentation_EGL()
		{
			Console.WriteLine("Scanning registry documentation (EGL)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/EGL"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;

				try {
					// Load XML file
					using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
						XmlDocument xml = new XmlDocument();

						XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
						nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
						nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

						XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
						XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

						xmlReaderSettings.ProhibitDtd = false;
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
						xmlReaderSettings.XmlResolver = null;
						xmlReaderSettings.IgnoreComments = true;
						xmlReaderSettings.CheckCharacters = false;
						xmlReaderSettings.ValidationType = ValidationType.None;
						xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

						using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
							xml.Load(xmlReader);
						}

						XmlNodeList xmlIdentifiers = xml.DocumentElement.SelectNodes("/x:refentry/x:refsynopsisdiv/x:funcsynopsis/x:funcprototype/x:funcdef/x:function", nsmgr);

						if (xmlIdentifiers.Count == 0)
							continue;

						foreach (XmlNode xmlIdentifier in xmlIdentifiers) {
							if (!Regex.IsMatch(xmlIdentifier.InnerText, "^(gl|wgl|glX|egl).*"))
								continue;
							if (_DocumentationMapE.ContainsKey(xmlIdentifier.InnerText))
								continue;

							_DocumentationMapE.Add(xmlIdentifier.InnerText, xml);
						}

						// Extract enumeration documentation:
						XmlNodeList enumerants = xml.SelectNodes("/x:refentry/x:refsect1[@xml:id='description']/x:variablelist/x:varlistentry", nsmgr);

						foreach (XmlNode enumerant in enumerants) {
							XmlNode enumerantId = enumerant.SelectSingleNode("x:term/x:constant", nsmgr);
							if (enumerantId == null)
								continue;

							XmlNode enumerantDoc = enumerant.SelectSingleNode("x:listitem", nsmgr);
							if (enumerantDoc == null)
								continue;

							if (!Regex.IsMatch(enumerantId.InnerText, "^(GL_|WGL_|GLX_|EGL_).*"))
								continue;

							if (!_DocumentationEnumMapE.ContainsKey(enumerantId.InnerText))
								_DocumentationEnumMapE.Add(enumerantId.InnerText, new List<EnumerationDocumentationBase>());

							_DocumentationEnumMapE[enumerantId.InnerText].Add(new EnumerationDocumentationGetParam(xml, xmlIdentifiers[0].InnerText, enumerantDoc));
						}
					}
				} catch (Exception) {
					continue;
				}
			}



			Console.WriteLine("\tFound documentation for {0} commands.", _DocumentationMapE.Count);
		}

		/// <summary>
		/// Index all documented OpenGL commands the the EGL manual.
		/// </summary>
		public static void ScanDocumentation_CL()
		{
			Console.WriteLine("Scanning registry documentation (CL)...");

			foreach (string documentationFile in Directory.GetFiles(Path.Combine(Program.BasePath, "GLMan/CL"))) {
				if (documentationFile.ToLowerInvariant().EndsWith(".xml") == false)
					continue;
				if (Regex.IsMatch(Path.GetFileName(documentationFile), "^cl[A-Z].*") == false)
					continue;

				try {
					// Load XML file
					using (FileStream fs = new FileStream(documentationFile, FileMode.Open, FileAccess.Read)) {
						XmlDocument xml = new XmlDocument();

						XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
						nsmgr.AddNamespace("mml", "http://www.w3.org/2001/XMLSchema-instance");
						//nsmgr.AddNamespace("x", "http://docbook.org/ns/docbook");

						XmlParserContext context = new XmlParserContext(null, nsmgr, null, XmlSpace.Default);
						XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();

						xmlReaderSettings.ProhibitDtd = false;
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
						xmlReaderSettings.XmlResolver = new LocalXhtmlXmlResolver(Path.Combine(Program.BasePath, "GLMan/CL"), Path.Combine(Program.BasePath, "GLMan/DTD"));
						xmlReaderSettings.IgnoreComments = true;
						xmlReaderSettings.CheckCharacters = false;
						xmlReaderSettings.ValidationType = ValidationType.None;
						xmlReaderSettings.ValidationFlags = XmlSchemaValidationFlags.None;

						using (XmlReader xmlReader = XmlReader.Create(fs, xmlReaderSettings, context)) {
							xml.Load(xmlReader);
						}

						XmlNodeList xmlIdentifiers = xml.DocumentElement.SelectNodes("/refentry/refsynopsisdiv/funcsynopsis/funcprototype/funcdef/function", nsmgr);

						if (xmlIdentifiers.Count == 0)
							continue;

						foreach (XmlNode xmlIdentifier in xmlIdentifiers) {
							string functionName = xmlIdentifier.InnerText.Trim();

							if (!Regex.IsMatch(functionName, "^(cl).*"))
								continue;
							if (_DocumentationMapCL.ContainsKey(functionName))
								continue;

							_DocumentationMapCL.Add(functionName, xml);
						}

						// Extract enumeration documentation:
						XmlNodeList enumerants = xml.SelectNodes("/refentry/refsect1[@id='parameters']/variablelist/varlistentry/listitem/informaltable/tgroup/tbody/row", nsmgr);

						foreach (XmlNode enumerant in enumerants) {
							XmlNode enumerantId = enumerant.SelectSingleNode("entry/constant", nsmgr);
							if (enumerantId == null)
								continue;

							string enumerantIdText = Regex.Replace(enumerantId.InnerText.Trim(), @"[\b\n\r]", String.Empty);
							string commandName = xmlIdentifiers[0].InnerText.Trim();
							
							if (!Regex.IsMatch(enumerantIdText, "^(CL_).*"))
								continue;

							XmlNode enumerantDoc = enumerant.SelectSingleNode("entry[last()]", nsmgr);
							if (enumerantDoc == null)
								continue;

							if (!_DocumentationEnumMapCL.ContainsKey(enumerantIdText))
								_DocumentationEnumMapCL.Add(enumerantIdText, new List<EnumerationDocumentationBase>());

							_DocumentationEnumMapCL[enumerantIdText].Add(new EnumerationDocumentationGetParam(xml, commandName, enumerantDoc));
						}
					}
				} catch (Exception) {
					continue;
				}
			}

			Console.WriteLine("\tFound documentation for {0} commands.", _DocumentationMapCL.Count);
		}

		private abstract class EnumerationDocumentationBase
		{
			public EnumerationDocumentationBase(XmlDocument xml, string command, XmlNode docNode)
			{
				if (xml == null)
					throw new ArgumentNullException("xml");
				if (command == null)
					throw new ArgumentNullException("command");
				if (docNode == null)
					throw new ArgumentNullException("docNode");
				Document = xml;
				CommandRef = command;
				EnumNode = docNode;
			}

			public abstract string GetDocumentation(ISpecContext ctx, XslCompiledTransform transform);

			protected readonly XmlDocument Document;

			protected readonly string CommandRef;

			protected readonly XmlNode EnumNode;
		}

		private class EnumerationDocumentationGetParam : EnumerationDocumentationBase
		{
			public EnumerationDocumentationGetParam(XmlDocument xml, string command, XmlNode docNode)
				: base(xml, command, docNode)
			{
				
			}

			public override string GetDocumentation(ISpecContext ctx, XslCompiledTransform transform)
			{
				Command commandRef = ctx.Registry.GetCommand(CommandRef);
				if (commandRef == null)
					return (null);

				StringBuilder doc = new StringBuilder();

				doc.AppendFormat("{0}.{1}: ", ctx.Class, commandRef.GetImplementationName(ctx));

				string actualDoc = GetDocumentationLine(EnumNode.InnerXml, transform, ctx);
				actualDoc = SpecificationStyle.EnsureFirstLowerCase(actualDoc);
				doc.Append(actualDoc);

				return (doc.ToString());
			}
		}

		private class EnumerationDocumentationSetParam : EnumerationDocumentationBase
		{
			public EnumerationDocumentationSetParam(XmlDocument xml, string command, XmlNode docNode)
				: base(xml, command, docNode)
			{
				EnumDescriptionNode = docNode.ParentNode;
			}

			public override string GetDocumentation(ISpecContext ctx, XslCompiledTransform transform)
			{
				Command commandRef = ctx.Registry.GetCommand(CommandRef);
				StringBuilder doc = new StringBuilder();

				doc.AppendFormat("{0}.{1}: ", ctx.Class, commandRef.GetImplementationName(ctx));

				List<string> periods = SplitDocumentationPeriods(EnumDescriptionNode.InnerXml);

				for (int i = 0; (i < 1) && (i < (periods.Count - 1)); i++) {
					string documentationLine = GetDocumentationLine(periods[i], transform, ctx);

					if (documentationLine.Length == 0)
						continue;

					doc.AppendFormat("{0}", GetDocumentationLine(periods[i], transform, ctx));
				}

				return (doc.ToString());
			}

			protected readonly XmlNode EnumDescriptionNode;
		}

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, XmlDocument> _DocumentationMap2 = new Dictionary<string, XmlDocument>();

		/// <summary>
		/// Map between the GL enumerant name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, List<EnumerationDocumentationBase>> _DocumentationEnumMap2 = new Dictionary<string, List<EnumerationDocumentationBase>>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, XmlDocument> _DocumentationMap4 = new Dictionary<string, XmlDocument>();

		/// <summary>
		/// Map between the GL enumerant name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, List<EnumerationDocumentationBase>> _DocumentationEnumMap4 = new Dictionary<string, List<EnumerationDocumentationBase>>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, XmlDocument> _DocumentationMapE = new Dictionary<string, XmlDocument>();

		/// <summary>
		/// Map between the GL enumerant name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, List<EnumerationDocumentationBase>> _DocumentationEnumMapE = new Dictionary<string, List<EnumerationDocumentationBase>>();

		/// <summary>
		/// Map between the GL command name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, XmlDocument> _DocumentationMapCL = new Dictionary<string, XmlDocument>();

		/// <summary>
		/// Map between the GL enumerant name and the relative documentation.
		/// </summary>
		private static readonly Dictionary<string, List<EnumerationDocumentationBase>> _DocumentationEnumMapCL = new Dictionary<string, List<EnumerationDocumentationBase>>();

		/// <summary>
		/// XHTML/XML DTD entity resolver.
		/// </summary>
		class LocalXhtmlXmlResolver : XmlUrlResolver
		{
			static LocalXhtmlXmlResolver()
			{
				KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"] = "http://www.oasis-open.org/docbook/xml/mathml/1.1CR1/dbmathml.dtd";
				LocalDtdPaths[KnownUris["-//OASIS//DTD DocBook MathML Module V1.1b1//EN"]] = "dbmathml.dtd";

				KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/docbookx.dtd";
				LocalDtdPaths[KnownUris["-//OASIS//DTD DocBook XML V4.3//EN"]] = "docbookx.dtd";

				KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbnotnx.mod";
				LocalDtdPaths[KnownUris["-//OASIS//ENTITIES DocBook Notations V4.3//EN"]] = "dbnotnx.mod";

				KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"] = "http://www.oasis-open.org/docbook/xml/4.3/dbcentx.mod";
				LocalDtdPaths[KnownUris["-//OASIS//ENTITIES DocBook Character Entities V4.3//EN"]] = "dbcentx.mod";

				KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"] = "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd";
				LocalDtdPaths[KnownUris["-//W3C//DTD XHTML 1.0 Transitional//EN"]] = "xhtml1-transitional.dtd";

				_DtdPath = Path.Combine(Program.BasePath, "GLMan/DTD");

				string[] dtdFiles;

				dtdFiles = Directory.GetFiles(_DtdPath, "*.dtd");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(_DtdPath, "*.mod");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');

				dtdFiles = Directory.GetFiles(_DtdPath, "*.ent");
				foreach (string dtdFile in dtdFiles)
					LocalDtdRelPaths[dtdFile] = dtdFile.Replace('\\', '/');
			}

			public LocalXhtmlXmlResolver(string documentPath)
			{
				ManDirectoryPath = null;
				DtdPath = Path.GetDirectoryName(documentPath);
			}

			public LocalXhtmlXmlResolver(string manDirectory, string documentPath)
			{
				ManDirectoryPath = manDirectory;
				DtdPath = Path.GetDirectoryName(documentPath);
			}

			public readonly string DtdPath;

			public readonly string ManDirectoryPath;

			public static void Touch() { }

			private static readonly Dictionary<string, string> KnownUris = new Dictionary<string, string>();
			private static readonly Dictionary<string, string> LocalDtdPaths = new Dictionary<string, string>();

			private static readonly Dictionary<string, string> LocalDtdRelPaths = new Dictionary<string, string>();


			private static string _DtdPath;

			public override Uri ResolveUri(Uri baseUri, string relativeUri)
			{
				lock (_SyncObject) {
					return KnownUris.ContainsKey(relativeUri) ?
						new Uri(KnownUris[relativeUri]) :
						base.ResolveUri(baseUri, relativeUri)
						;
				}
			}

			public override object GetEntity(Uri absoluteUri, string role, System.Type ofObjectToReturn)
			{
				if (absoluteUri == null)
					throw new ArgumentNullException("absoluteUri");

				lock (_SyncObject) {

					//resolve resources from cache (if possible)
					if ((absoluteUri.Scheme == "http") && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = absoluteUri.OriginalString.Substring(absoluteUri.OriginalString.LastIndexOf("/") + 1);
						bool relative = false;

						foreach (string key in LocalDtdRelPaths.Keys) {
							if (key.EndsWith(localPath) == true) {
								LocalDtdPaths[absoluteUri.OriginalString] = localPath;
								relative = true;
								break;
							}
						}


						if ((relative == false) && (LocalDtdPaths.ContainsKey(absoluteUri.OriginalString) == false)) {
							Console.Write("Downloading {0}...", absoluteUri);

							WebRequest webRequest;
							WebResponse webResponse = null;
							int tries = 0;
							bool done = false;

							do {
								try {
									webRequest = WebRequest.Create(absoluteUri);
									webRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
									webRequest.Timeout = 1000;
									webResponse = webRequest.GetResponse();
									done = true;
									Console.WriteLine(". done!");
								} catch (Exception) {
									Console.Write(".");
									tries++;
								}
							} while ((done == false) && (tries < 3));

							if (done == true) {
								localPath = localPath.Substring(localPath.LastIndexOf("/") + 1);

								using (StreamWriter fs = new StreamWriter(Path.Combine(_DtdPath, localPath), false)) {
									Stream rStream = webResponse.GetResponseStream();

									using (StreamReader sr = new StreamReader(rStream)) {
										string contents = sr.ReadToEnd();

										fs.Write(contents);
									}
								}

								LocalDtdPaths[absoluteUri.OriginalString] = localPath;
							} else {
								Console.WriteLine("not done");
								return null;
							}
						}

						return (new FileStream(Path.Combine(_DtdPath, LocalDtdPaths[absoluteUri.OriginalString]), FileMode.Open, FileAccess.Read));
					} else if ((absoluteUri.Scheme == "file") && (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream))) {
						string localPath = Path.GetFileName(absoluteUri.OriginalString);

						if (File.Exists(Path.Combine(DtdPath, localPath)))
							return (new FileStream(Path.Combine(DtdPath, localPath), FileMode.Open, FileAccess.Read));
						else if (ManDirectoryPath != null && File.Exists(Path.Combine(ManDirectoryPath, localPath)))
							return (new FileStream(Path.Combine(ManDirectoryPath, localPath), FileMode.Open, FileAccess.Read));
						else
							return (new FileStream(Path.Combine(DtdPath, localPath), FileMode.Open, FileAccess.Read));
					}

					//otherwise use the default behavior of the XmlUrlResolver class (resolve resources from source)
					return base.GetEntity(absoluteUri, role, ofObjectToReturn);
				}
			}

			private static readonly object _SyncObject = new object();
		}

		#endregion

		#region Logging

		public static void CreateLog()
		{
			_WarningLog = new StreamWriter("../../DocWarnings.txt");
		}

		public static void CloseLog()
		{
			_WarningLog.Close();
			_WarningLog = null;
		}

		/// <summary>
		/// Stream used for logging documentation warnings.
		/// </summary>
		private static StreamWriter _WarningLog;

		#endregion
	}
}
