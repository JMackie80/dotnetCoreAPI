Imports dotNetCore.Entity

Public Class EmployeeRepository

    Private dbContext As PCSRoad_DevTest_sammybranchEntities = New PCSRoad_DevTest_sammybranchEntities()

    Public Function GetEmployees(id As Nullable(Of Integer)) As IEnumerable(Of Employee)
        Return dbContext.GetPREmployeeMaster(id).Select(Function(emp) Map(emp)).ToList()
    End Function

    Private Function Map(emp As GetPREmployeeMaster) As Employee
        Dim Employee As New Employee()
        With Employee
            .EmployeeNumber = emp.EmployeeNumber
            .FirstName = emp.FirstName
            .LastName = emp.LastName
            .AddressLine1 = emp.AddressLine1
            .AddressLine2 = emp.AddressLine2
            .City = emp.City
            .State = emp.State
            .ZipCode = emp.ZipCode
            .SocialSecurityNumber = emp.SocialSecurityNumber
            .DriversLicenseNumber = emp.DriversLicenseEndorsements
            .DriversLicenseEndorsements = emp.DriversLicenseEndorsements
            .Gender = emp.Gender
            .Race = emp.Race
            .PhoneNumber = emp.PhoneNumber
            .BirthDate = emp.BirthDate
            .EmergencyName = emp.EmergencyName
            .EmergencyPhoneNumber = emp.EmergencyPhoneNumber
            .DateOfEmployment = emp.DateOfEmployment
            .JobClassification = emp.JobClassification
            .WorkShift = emp.WorkShift
            .Fund = emp.Fund
            .GLDepartment = emp.GLDepartment
            .Activity = emp.Activity
            .Project = emp.Project
            .GLFunction = emp.GLFunction
            .Account = emp.Account
            .SubAccount = emp.SubAccount
            .WorkType = emp.WorkType
            .PayFrequency = emp.PayFrequency
            .EmployeeStatus = emp.EmployeeStatus
            .HourlyRate = emp.HourlyRate
            .EmployeeSalary = emp.EmployeeSalary
            .RateEffectiveDate = emp.RateEffectiveDate
            .TerminationDate = emp.TerminationDate
            .LongevityDate = emp.LongevityDate
            .RetirementEligibleDate = emp.RetirementEligibleDate
            .Department = emp.Department
            .BenefitEligibleDate = emp.BenefitEligibleDate
            .TaxMaritalStatus = emp.TaxMaritalStatus
            .WorkersComp = emp.WorkersComp
            .BlueCrossGroupNumber = emp.BlueCrossGroupNumber
            .BlueCrossService = emp.BlueCrossService
            .MedicalInsurancePlan = emp.MedicalInsurancePlan
            .DentalInsurancePlan = emp.DentalInsurancePlan
            .LifeInsurancePlan = emp.LifeInsurancePlan
            .EmployeeDependants = emp.EmployeeDependants
            .UnionUnit = emp.UnionUnit
            .UnionSeniorityDate = emp.UnionSeniorityDate
            .BenefitAward = emp.BenefitAward
            .ServiceRecognitionHourlyRate_SCRC = emp.ServiceRecognitionHourlyRate_SCRC
            .Userx = emp.Userx
            .MiddleName = emp.MiddleName
            .LastNameSuffix = emp.LastNameSuffix
            .EmployeeName = emp.EmployeeName
        End With
        Return Employee
    End Function

End Class
