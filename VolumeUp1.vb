dim xml = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)
dim DynamicInput1 as String = (x.SelectSingleNode("/vmix/dynamic/input1").InnerText)
API.Function("SetVolume", Input:=DynamicInput1, Value:="+=1")
