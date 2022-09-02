# GitHub CI/CO .NET DocFX Pipeline

> **Copyright:** (C) 2022 by Robert Smith <nightwintertooth@gmail.com>

> **Licensed under:**  DBAD License -> https://dbad-license.org/

Hello!  Looks like you found a hidden gem.  This subrepository is configured to build/test/deploy .NET with DocFX for this repository with github workflows.

----------------
## About

I made efforts to make this modular so you could reuse it (and so can I).   The way I have structured it is by using branches to keep docsfx and gh-pages isolated on they own branches so your master/main repo is very neat and orderly.  gh-pages is completely wiped, there is no need to manage it anymore thanks to docsfx static content generator and this pipeline.

----------------
## Donate

As this thing's an effective drop in replacement for Jekyll for github pages, toss me some spare dev cash if you like it:

https://www.paypal.com/paypalme/snowflowerwolf

Or choose not to donate, just "Don't Be A Dick" - The Buddah.

----------------
## Contribute

> __WARNING:__ Any contribution which modifies the .github directory OR the ``docfx`` branch will **immediately** be put into manual code review for safety automatically by my workflows.

You can of course contribute to improve my CI/CO DocFX library pipeline, but of course, since the core infrastructure of this repository is located here, I will be checking your commits very closely.

----------------