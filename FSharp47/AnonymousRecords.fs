module AnonymousRecords

open System

/// Shows how to create and use anonymous records
module Basics =
    let getCircleStats radius =
        let d = radius * 2.0
        let a = Math.PI * (radius ** 2.0)
        let c = 2.0 * Math.PI * radius

        {| Diameter = d; Area = a; Circumference = c |}

    let basicAnonRecordsDemo () =
        let r = 2.0
        let stats = getCircleStats r
        printfn "Circle with radius: %f has diameter %f, area %f, and circumference %f"
            r stats.Diameter stats.Area stats.Circumference



/// Shows how to embed anonymous records in unions
module AnonymousRecordsWithTyes =
    type FullName = { FirstName: string; LastName: string }

    // Note that using a named for Manager and Executive would require mutually recursive definitions.
    type Employee =
        | Engineer of FullName
        | Manager of {| Name: FullName; Reports: Employee list |}
        | Executive of {| Name: FullName; Reports: Employee list; Assistant: Employee |}

    let getFirstName e =
        match e with
        | Engineer fullName -> fullName.FirstName
        | Manager m -> m.Name.FirstName
        | Executive ex -> ex.Name.FirstName


/// Shows how to construct new anonymous records from existing ones
module CopyAndUpdate =
    let demo () =
        let data = {| X = 1; Y = 2 |}
        printfn "data is %A" data

        let data' = {| data with Y = 3 |}
        printfn "data' is %A" data'
