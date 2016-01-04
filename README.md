# IntelliDex
The wox plugin for pokemon fans

![](/medias/demo.gif)

This is still in heavy development, do not expect too much for now.

## Usage

Each examples in this section will outline basics of IntelliDex.

* Note that many of those are unimplemented and only serve as a draft for future releases.

* Angled brackets (`< >`) = required parameters
* Square brackets (`[ ]`) = optional parameters

---

**Checking basic information**

`dex <pokemon>`

* Where `<pokemon>` is a Pokemon
  * Only parts of a pokemon's name can be entered rather than the whole name.

---

**Checking learnsets**

`dex <pokemon> learnset <gen|game> [method]`

* `learnset` can be replaced with `ls` as a shorthand symbol
* `<gen|game>` is either ...
  * A generation (i.e `II`, `IV`, `3`, `2`)
  * A game (i.e `red`, `emerald`, `hgss`, `xy`)
* An optional gain method (i.e `tm`, `egg`, `levelup`, `lvl`)
  * By level up is assumed to be the default

---


## Credits

* [Veekun's Pokemon csv information database](https://github.com/veekun/pokedex)
* [CsvHelper for csv parsing](http://csvhelper.com/)