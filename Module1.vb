
Imports System.Xml

Module Module1

    Sub Main()

        'Retrieve XML document   
        Dim reader As XmlTextReader = New XmlTextReader("http://weather.yahooapis.com/forecastrss?w=2353991")



        While reader.Read()

            Try

                'Finds the tag 
                If reader.IsStartElement("yweather:condition") Then

                    'Finds the attribute
                    Console.WriteLine(reader.GetAttribute("temp"))

                End If

            Catch ex As InvalidCastException
                Console.WriteLine("Invalid Data")

            Catch ex As Exception
                Console.WriteLine("Error occurred")

            End Try


        End While



    End Sub






End Module
