# Scrabble App

## by Mikah Mathews & Julia Seidman (2020)

## Description

This app will allow a user to find out how much a word is worth in scrabble.

## Setup

Install .NET, type "dotnet run" in your terminal while within the project directory. Enjoy.

## Technology

#### C#
#### .NET
#### MSTest

## Specs

|Behavior|Input|Output|
|-----|-----|-----|
|Program will accept word from user| Bananas| Bananas|
|Program will separate word into letters| Bananas| [B, a, n, a, n, a, s]|
|Program will set word score to zero|0|0|
|Program will access value of each letter in word|b|score = 3|
|Program will display value of each letter | b a n a n a s | 3 1 1 1 1 1 1 |
|Program will return word score|bananas|word score = 9|
|Stretch spec: Program will allow user to specify whether it is a double point letter or word|double| word score = 18|


## Legal

#### MIT License

### Copyright (c) 2020 Mikah Mathews & Julia Seidman

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
