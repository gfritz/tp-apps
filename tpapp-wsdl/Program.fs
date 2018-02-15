open System
open System.ServiceModel
open FSharp.Data.TypeProviders



type CalculatorService = WsdlService<"http://www.dneonline.com/calculator.asmx?wsdl">
let args = (1,2)

printfn "Per our CalculatorService, %i + %i = %i" (fst args) (snd args) (CalculatorService.GetCalculatorSoap().Add args)
// dotnet build
// 