//-----------------------------------------------------------------------
// <copyright file="SingleControlGenerator.cs" company="MyToolkit">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>http://mytoolkit.codeplex.com/license</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

#if WINRT
using Windows.UI.Xaml;
#else
using System.Windows;
#endif

namespace MyToolkit.Controls.HtmlTextBlockImplementation
{
	public abstract class SingleControlGenerator : IControlGenerator
	{
		public DependencyObject[] Generate(HtmlNode node, IHtmlTextBlock textBlock)
		{
			var ctrl = GenerateSingle(node, textBlock);
			if (ctrl != null)
				return new [] { ctrl };
			return null; 
		}

		public abstract DependencyObject GenerateSingle(HtmlNode node, IHtmlTextBlock textBlock);
	}
}