<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:fo="http://www.w3.org/1999/XSL/Format"
>
    <xsl:template match="/">
        <xsl:apply-templates select="plan"/>
    </xsl:template>
    <xsl:template match="plan">
        <fo:root>
            <fo:layout-master-set>
                <fo:simple-page-master master-name="romp"
                        page-height="297mm"
                        page-width="21cm"
                        margin="1in"
                >
                    <fo:region-body/>
                </fo:simple-page-master>
            </fo:layout-master-set>
            <xsl:apply-templates select="page"/>
        </fo:root>
    </xsl:template>
    <xsl:template match="page">
        <fo:page-sequence master-reference="romp">
            <fo:flow flow-name="xsl-region-body">
                <xsl:apply-templates select="figure|h1"/>
            </fo:flow>
        </fo:page-sequence>
    </xsl:template>
    <xsl:template match="figure">
        <fo:block><xsl:apply-templates select="img"/></fo:block>
    </xsl:template>
    <xsl:template match="img">
        <fo:external-graphic content-width="15cm">
            <xsl:attribute name="src">
                <xsl:value-of select="@src"/>
            </xsl:attribute>
        </fo:external-graphic>
    </xsl:template>
    <xsl:template match="h1">
        <fo:block><xsl:value-of select="."/></fo:block>
    </xsl:template>
</xsl:stylesheet>


