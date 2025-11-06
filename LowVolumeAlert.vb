dim xml = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)
dim Volume As Decimal = (x.SelectSingleNode("/vmix/audio/master/@meterF1").Value)
API.Function("Play", Input:="lowvolumealert.gtzip")
API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="1")

Dim minLevel as Decimal = 0.005
Dim quietCount=0
do while true
  xml = API.XML()
  x.loadxml(xml)
  Volume = (x.SelectSingleNode("/vmix/audio/master/@meterF1").Value)
  if Volume<minLevel then quietCount=quietCount+1
  if quietCount>=10 then
    if quietCount=10 then API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="2")
    if quietCount=20 then API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="3")
    if quietCount>30 then quietCount=9
    'Console.WriteLine(quietCount)
  end if
  if Volume>minLevel then
    API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="1")
    quietCount=0
  end if
  Sleep(100)
loop
