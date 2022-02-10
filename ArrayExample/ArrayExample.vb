Module ArrayExample

    Sub Main()
        'SimpleArray()
        'TwoDimensionalArray()
        'ArrayBoundaries()

        Console.Read()
    End Sub

    Sub SimpleArray()

        Dim names(6) As String 'Declare an array of strings with 0 to 6 elements (7 slots)

        'add data to the array
        names(0) = "Shawn"
        names(1) = "Carrie"
        names(2) = "Jamison"
        names(3) = "Tate"
        names(4) = "Bailee"
        names(5) = "Kelcee"
        names(6) = "Nash"

        Console.WriteLine(names(2)) 'accesses an element

    End Sub

    Sub TwoDimensionalArray()
        Dim numbers(9, 9) As Integer
        Dim temp As String

        For row = 0 To 9
            For column = 0 To 9
                numbers(row, column) = row + column
            Next
        Next

        For row = 0 To 9
            For column = 0 To 9
                temp = CStr(numbers(row, column)) & ""
                Console.Write(temp.PadLeft(5))
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub ArrayBoundaries()
        Dim fruits(5) As String

        fruits(0) = "Apple"
        fruits(1) = "Pear"
        fruits(2) = "Orange"
        fruits(3) = "Watermelon"
        fruits(4) = "Lime"
        fruits(5) = "Potatoe..."

        For i = LBound(fruits) To UBound(fruits)
            Console.WriteLine(fruits(i))
        Next
    End Sub


End Module
