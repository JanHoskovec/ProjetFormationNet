<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>

  <xsl:output
      method="html"
      encoding="UTF-8"
      doctype-public="-//W3C//DTD HTML 4.01//EN"
      doctype-system="http://www.w3.org/TR/html4/strict.dtd"
      indent="yes" />
  <xsl:template match="/">
    <html>
      <head>
        <title>Liste des paragraphes</title>
      </head>
      <body>
        <xsl:for-each select="ArrayOfParagraphe/Paragraphe">
          <h4>
            <xsl:value-of select="./Numero"/>.<xsl:value-of select="./Titre"/>
          </h4>
          <p>
            <xsl:value-of select="./Contenu"/>
          </p>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>
