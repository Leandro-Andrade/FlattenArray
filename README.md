# FlattenArray
Converts a nested jagged array into a flat, single array of integers

# Requirements
.NET Core 2.0 or above

# How to use it
1. Import the library and instantiate the ArrayHelper.
2. Use the method `ToFlat()` to convert it.
3. It returns an array of integers `int[]`.

## Constraints
* It expects an argument of type `object[]`
* Do NOT use `int[]` for any nested members (to be improved - this is due to limitations of C# to have a nested jagged array strongly typed).
