dim xml = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)
dim Volume As Decimal = (x.SelectSingleNode("/vmix/audio/master/@meterF1").Value)
'Console.WriteLine(Volume)
API.Function("Play", Input:="lowvolumealert.gtzip")
API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="1")

Dim MinLevel as Decimal = 0.005
do while true
  xml = API.XML()
  x.loadxml(xml)
  Volume = (x.SelectSingleNode("/vmix/audio/master/@meterF1").Value)
  'Console.WriteLine(Volume)
  if Volume<MinLevel then
    API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="2")
    Sleep(500)
    API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="3")
    Sleep(500)
  end if
  if Volume>MinLevel then
    API.Function("SelectIndex", Input:="lowvolumealert.gtzip", Value:="1")
    Sleep(500)
  end if
loop
