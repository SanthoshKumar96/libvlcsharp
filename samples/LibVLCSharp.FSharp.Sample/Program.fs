﻿open System
open LibVLCSharp.Shared

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    Core.Initialize()
    let libVLC = new LibVLC()
    let mp = new MediaPlayer(libVLC)
    mp.Play(new Media(libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"))) |> ignore
    let result = Console.ReadKey()
    0
