namespace fsharp_jumpstart_worskhop.Logic

open System
open fsharp_jumpstart_workshop.Types

module Validation = 
    let validateEmail (email : string) : bool =
        let splitEmail = email.Split('@')
        email.Length > 2 && // check length of email to ensure enough characters
        (splitEmail.Length) = 2 && // check that there is only one @ symbol
        (splitEmail // filter through array to ensure 
            |> Array.filter (fun (s : string) -> s.Length = 0)).Length = 0
