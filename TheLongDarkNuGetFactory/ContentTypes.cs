﻿namespace TheLongDarkNuGetFactory;

internal static class ContentTypes
{
	public const string Path = "[Content_Types].xml";
	public const string Content = """
		<?xml version="1.0" encoding="utf-8"?>
		<Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
		  <Default Extension="rels" ContentType="application/vnd.openxmlformats-package.relationships+xml" />
		  <Default Extension="psmdcp" ContentType="application/vnd.openxmlformats-package.core-properties+xml" />
		  <Default Extension="dll" ContentType="application/octet" />
		  <Default Extension="xml" ContentType="application/octet" />
		  <Default Extension="md" ContentType="application/octet" />
		  <Default Extension="nuspec" ContentType="application/octet" />
		</Types>
		""";
}
