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
                <xsl:apply-templates select="dl|figure|h1|h2|hgroup"/>
            </fo:flow>
        </fo:page-sequence>
    </xsl:template>
    <xsl:template match="figure">
        <xsl:apply-templates select="figcaption|img"/>
    </xsl:template>
    <xsl:template match="img">
        <fo:block>
        <fo:external-graphic content-width="15cm">
            <xsl:attribute name="src">
                <xsl:value-of select="@src"/>
            </xsl:attribute>
        </fo:external-graphic>
        </fo:block>
    </xsl:template>
    <xsl:template match="dl">
        <xsl:apply-templates select="dd|dt"/>
    </xsl:template>
    <xsl:template match="hgroup">
        <xsl:apply-templates select="h1|h2"/>
    </xsl:template>
    <xsl:template match="dt|figcaption">
        <fo:block><xsl:value-of select="."/></fo:block>
    </xsl:template>
    <xsl:template match="dd">
        <fo:block margin-left="20pt"><xsl:value-of select="."/></fo:block>
    </xsl:template>

    <xsl:template match="h1">
        <fo:block font-size="32px"><xsl:value-of select="."/></fo:block>
    </xsl:template>
    <xsl:template match="h2">
        <fo:block font-size="24px"><xsl:value-of select="."/></fo:block>
    </xsl:template>

</xsl:stylesheet>


