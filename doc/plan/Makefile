all: diagrammen plan.pdf

diagrammen: klassen.svg

klassen.svg: klassen.uxf
	umlet -action=convert -format=svg -filename=klassen.uxf

plan.pdf: plan.xml pdf.xsl diagrammen
	fop -xml plan.xml -xsl pdf.xsl -pdf plan.pdf


