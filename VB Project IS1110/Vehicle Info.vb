Public Class VehicleInfo
    ' changed from car class and van class to vehicle class
    Public Property strCarType As String
    Public Property strVanType As String
    Public Property numDaysRent As Int32

    Public Property hasChildSeat As Boolean
    Public Property hasSkiEquipment As Boolean
    Public Property hasRoofMount As Boolean
    Public Property hasAdditionalDriver As Boolean
    Public Property hasInsuranceCollision As Boolean
    Public Property hasInsuranceTheft As Boolean
    Public Property hasInsuranceContent As Boolean

    Public Function calculateDay(ByVal numWeeks As Int32, ByVal numDays As Int32) As Int32
        Dim intReturnValue As Int32 = (numWeeks * 7) + numDays
        Return intReturnValue
    End Function
    'function calculates integer value from weeks and days given




End Class
