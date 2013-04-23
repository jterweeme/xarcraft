<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"

>
    <xsl:template match="/">
        <xsl:apply-templates select="plan"/>
    </xsl:template>
    <xsl:template match="plan">
        <html>
			<head>
				<title>Plan</title>
			</head>
			<body>
				<xsl:apply-templates select="page"/>
			</body>
        </html>
    </xsl:template>
	<xsl:template match="page">
		<xsl:apply-templates select="dl|h1|h2|hgroup|ul"/>
	</xsl:template>
	<xsl:template match="dl|h1|h2|hgroup|ul">
		<xsl:copy-of select="."/>
	</xsl:template>
</xsl:stylesheet>

