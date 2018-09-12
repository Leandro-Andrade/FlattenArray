# FlattenArray
Converts a nested jagged array (e.g. `[[1,2,[3]],4]`) into a flat (`[1,2,3,4]`), single array of integers

# Requirements
.NET Core

# How to use it
1. Import the dll as a reference or add the project into your solution and reference it.
2. Use the extension method method `.ToFlat()` to any array of objects you may have. 
Example:
```
var myNestedArray = new object[] {1, 2, new object[] {new object[] {3}}};
var flatArray = myNestedArray.ToFlat();
``` 

3. It returns an array of integers `int[]`.

## Constraints
* It expects an argument of type `object[]`
* Do NOT use `int[]` for any nested members (to be improved - this is due to limitations of C# to have a nested jagged array strongly typed).
