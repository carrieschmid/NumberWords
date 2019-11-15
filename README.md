# Number Words
10/1/19

#### _Project to count coins in C#._

#### By _**Carrie Schmid**_

## Description

_A project to practice coding in C#._


## Support and contact details


_Carrie Schmid: carriepederson7@gmail.com_

## Technologies Used

_C#_

### License

*MIT Liscence*

Copyright (c) 2019 **_Carrie Schmid_**

|Behavior|Input|Output|
|----|------|-----|
|Ignores non-numeric inputs| se, # | Please enter a number|
|Accepts numeric input under 1,000,000| 100 | one hundred|
|Convert 0-9 to a single word| 9| nine|
|Convert 10-19 to a single word| 10 | ten|
|Convert mod 10 < 100 to a single word| 20 | twenty|
|Use 0-9 single word and concatenate "hundred" for numbers mod 100 < 1000 | 200| two hundred|
|For number not mod 10 < 100, concatenate tens word and ones word| 21| twenty one|
|For number not mod 100< 1000, concatenates ones word and "hundred" and preconcatenated value representing 10s and 1s digits |221| two hundred twenty one|
|For number not mod 1000 < 10,000, concatenates ones word and "thousand" and preconcatenated value representing 100s, 10s and 1s digits."| 3245 | three  thousand two hundred forty five|
|For number not mod 1000 < 100,000, concatenates tens and/or ones word and "thousand" and preconcatenated value representing 100s, 10s and 1s digits."| 23245 | twenty three thousand two hundred forty five|
|For number not mod 1000 < 1,000,000, concatenates hundred and/or tens and/or ones word and "thousand" and preconcatenated value representing 100s, 10s and 1s digits."| 123245 | one hundred twenty three thousand two hundred forty five|



|Behavior|Input|Output|
|----|------|-----|
|Ignores non-numeric inputs| se, # | Please enter a number|
|Accepts numeric input under 1,000,000| 100 | one hundred|
|Convert 0-9 to a single word| 9| nine|
|Convert mod 10 < 100 to a single word| 20 | twenty|
|Convert 10-19 to a single word when 10s digit equals 1 | 10 | ten|
| Concate ones and tens words together when value is not mod 10 < 100 | 25 | twenty five |
|Use 0-9 single word and concatenate "hundred" for numbers mod 100 < 1000 | 200| two hundred|
|Ignore digits when it equals 0 for all places except ones digit | 209 | two hundred nine |
|Perform rules for hundreds, tens and ones for thousands digits and then concatenate 'thousand'|234000|Two hundred thirty four thousand |
|Concatenate thousands digit words to words representing hundreds digits | 234567 | Two hundred thirty four thousand five hundred sixty seven |
