module Details.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props

let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "Details page" ]
      p
        [ ]
        [ str "I am a F# developer !" ] ]
