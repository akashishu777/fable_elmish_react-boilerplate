module Global

type Page =
  | Home
  | Counter
  | About
  | Details

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"
  | Details -> "#details"
