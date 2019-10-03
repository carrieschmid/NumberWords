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
|For nuumber not mod 1000 < 10,000, concatenates ones word and "thousand" and preconcatenated value representing 100s, 10s and 1s digits."| 3245 | three  thousand two hundred forty five|
|Applies precon 

