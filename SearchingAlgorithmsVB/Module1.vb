Module Module1

    Sub Main()





    End Sub
    Sub demoLinearSearch()
        Dim numbers As Integer() = {7, 3, 9, 1, 8, 6, 4, 10}
        Dim found As Boolean = False
        Dim index As Integer = 0
        Dim numToFind As Integer
        Console.Write("Enter number to find: ")
        numToFind = Console.ReadLine
        While Not found And index < numbers.Length
            If numbers(index) = numToFind Then
                found = True
            End If
            index += 1
        End While
        Console.WriteLine(found)
    End Sub
    ' Function which returns index when found or -1 if not
    Function FindPositionLinearSearch(array() As Integer, numToFind As Integer) As Integer
        Dim index As Integer = 0
        While index < array.Length
            If array(index) = numToFind Then
                Return index
            End If
            index += 1
        End While
        Return -1
    End Function

    ' Function which returns true/false if string is in array
    Function findIfValuePresent(value As String, array() As String) As Boolean

        Dim index As Integer = 0
        While index < array.Length
            If array(index) = value Then
                Return True
            End If
            index += 1
        End While
        Return False
    End Function
    Sub demoBinarySearch()
        Dim array As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim numToFind As Integer
        Dim found As Boolean = False
        Console.Write("Enter a number to find: ")
        numToFind = Console.ReadLine
        Dim starter, ender, mid As Integer
        starter = 0
        ender = array.Length - 1
        Do
            mid = (starter + ender) \ 2
            If array(mid) = numToFind Then
                found = True
            ElseIf numToFind > array(mid) Then
                starter = mid + 1
            Else
                ender = mid - 1
            End If
        Loop While starter < ender And Not found
        Console.WriteLine(found)
    End Sub
    Sub DemoBinarySearch2()
        Dim array As String() = {"apple", "banana", "pear", "pineapple", "plum"}
        Dim wordToFind As String
        Dim found As Boolean
        Console.Write("Enter word to find: ")
        wordToFind = Console.ReadLine
        Dim starter, ender, mid As Integer
        starter = 0
        ender = array.Length - 1
        Do
            mid = (starter + ender) \ 2
            If array(mid) = wordToFind Then
                found = True
            ElseIf String.Compare(wordToFind, array(mid)) = 1 Then
                starter = mid + 1
            Else
                ender = mid - 1
            End If
        Loop While starter < ender And Not found
        Console.WriteLine(found)
    End Sub

End Module
