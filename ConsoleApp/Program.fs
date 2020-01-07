open System
open Example
open System.Buffers

type BaseMessage = 
  struct
    val Payload : ReadOnlySequence<byte>
    new (payload: ReadOnlySequence<byte>) = { Payload = payload }
  end

type MyClass() =

  interface IMessageReader<BaseMessage> with
      member this.TryParseMessage(input: inref<ReadOnlySequence<byte>>, consumed: byref<SequencePosition>, examined: byref<SequencePosition>, message: byref<BaseMessage>): bool = 
          failwith "Not Implemented"


//  //member this.TryParseMessage(input: inref<ReadOnlySequence<byte>>, consumed: byref<SequencePosition>, examined: byref<SequencePosition>, message: byref<BaseMessage>): bool = 
//  //  raise (System.NotImplementedException())

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
